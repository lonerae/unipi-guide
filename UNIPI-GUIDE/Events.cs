using System;
using System.Data.SQLite;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Button = System.Windows.Forms.Button;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.AxHost;

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
        string connectionString = "DataSource = unipiGuide.db;Version = 3";
        SQLiteConnection connection;

        List<DateTime> eventDates = new List<DateTime>();
        int currentPage = 1;
        int commentsPerPage = 3;

        List<int> voteList = new List<int>();
        enum BUTTON_ACTIONS
        {
            UP,
            DOWN,
            UNPRESSED
        }
        List<BUTTON_ACTIONS> buttonPressed = new List<BUTTON_ACTIONS>();

       

        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            showComments(currentPage);

            // adding based on SELECT query
            eventDates.Add(new DateTime(2023, 9, 5));
            eventDates.Add(new DateTime(2023, 9, 10));
            calendar.BoldedDates = eventDates.ToArray();

            if (!isLogged())
            {
                uploadBtn.Enabled = false;
                clearBtn.Enabled = false;
                warnLabel.Visible = true;
            }
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (eventDates.Contains(calendar.SelectionRange.Start))
            {
                // event description based on SELECT...WHERE query
               eventDescrBox.Text = "Lorem ipsum " + calendar.SelectionRange.Start.ToShortDateString() + " ipsum lorem.";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentPage += 1;
            showComments(currentPage);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentPage == 1) return;
            currentPage -= 1;
            showComments(currentPage);
        }

        private void pageBtn_Click(object sender, EventArgs e)
        {
            if (pageBox.Text.All(char.IsDigit) &&
                int.Parse(pageBox.Text) > 0)
            {
                currentPage = int.Parse(pageBox.Text);
                showComments(currentPage);
            }
        }

        private void showComments(int currentPage)
        {
            int index = (currentPage - 1) * commentsPerPage + 1;
            commentsPanel.Controls.Clear();

            connection.Open();
            int start = index - 1;
            int end = index + commentsPerPage;
            string selectSQL = "SELECT * FROM comment WHERE id>@start AND id<@end";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Size = new Size(commentsPanel.Width, commentBox.Height);

                RichTextBox bodyBox = new RichTextBox();
                bodyBox.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                bodyBox.Text = reader.GetString(2);
                bodyBox.ReadOnly = true;

                LinkLabel authorLabel = new LinkLabel();
                authorLabel.RightToLeft = RightToLeft.Yes;
                authorLabel.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                authorLabel.Text = reader.GetString(1);
                authorLabel.Location = new Point(bodyBox.Location.X, bodyBox.Location.Y + bodyBox.Height + 10);

                Button upvote = new System.Windows.Forms.Button();
                upvote.Size = new Size(25, commentBox.Height / 3);
                upvote.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, bodyBox.Location.Y);
                upvote.Text = "+1";
                upvote.Name = "u" + reader.GetInt32(0).ToString();
                RichTextBox ratingBox = new RichTextBox();
                ratingBox.Size = new Size(25, commentBox.Height / 3);
                ratingBox.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, upvote.Location.Y + upvote.Height);
                ratingBox.Text = reader.GetInt32(3).ToString();
                ratingBox.ReadOnly = true;
                Button downvote = new System.Windows.Forms.Button();
                downvote.Size = new Size(25, commentBox.Height / 3);
                downvote.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, ratingBox.Location.Y + ratingBox.Height);
                downvote.Text = "-1";
                downvote.Name = "d" + reader.GetInt32(0).ToString();

                panel.Controls.Add(bodyBox);
                panel.Controls.Add(authorLabel);
                panel.Controls.Add(upvote);
                panel.Controls.Add(ratingBox);
                panel.Controls.Add(downvote);

                buttonPressed.Add(BUTTON_ACTIONS.UNPRESSED);
                voteList.Add(reader.GetInt32(3));

                if (!isLogged())
                {
                    upvote.Enabled = false;
                    downvote.Enabled = false;
                }
                else
                {
                    upvote.Click += new EventHandler(addVote);
                    downvote.Click += new EventHandler(subtractVote);
                }

                commentsPanel.Controls.Add(panel);
            }
            command.Dispose();
            connection.Close();
        }

        private void addVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            setVote(btn, 1, BUTTON_ACTIONS.UP);
        }

        private void subtractVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            setVote(btn, -1, BUTTON_ACTIONS.DOWN);
        }

        private void setVote(Button btn, int value, BUTTON_ACTIONS action)
        {
            int id = Int32.Parse(btn.Name.Substring(1));
            BUTTON_ACTIONS prevValue = buttonPressed[id - 1];
            if (prevValue == action) return;

            connection.Open();
            string updateSQL = "UPDATE comment SET rating = @value WHERE id = @id";
            SQLiteCommand command = new SQLiteCommand(updateSQL, connection);
            command.Parameters.AddWithValue("@value", voteList[id - 1] + value);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            if (prevValue == BUTTON_ACTIONS.UNPRESSED)
            {
                buttonPressed[id - 1] = action;
            }
            else if (prevValue != action) 
            {
                buttonPressed[id - 1] = BUTTON_ACTIONS.UNPRESSED;
            }
            voteList[id - 1] = voteList[id - 1] + value;
            showComments(currentPage);

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQL = "SELECT * FROM Student";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText(reader.GetString(2) + ", " + reader.GetString(3));
                richTextBox1.AppendText(Environment.NewLine);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            String selectSQL = "SELECT * FROM Student WHERE am='" + textBox1.Text + "'";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                richTextBox1.AppendText(reader.GetString(0) + ", " + reader.GetString(1));
                richTextBox1.AppendText(Environment.NewLine);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            String insertSQL = "INSERT INTO Student VALUES('mppl2225','Eleni','eln@gmail.com','12345')";
            SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
            int rowsAffected = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            MessageBox.Show(rowsAffected.ToString(), "# of records inserted");
        }*/
    }
}
