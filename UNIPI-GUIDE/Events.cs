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

            addEvents();   
            if (!isLogged())
            {
                uploadBtn.Enabled = false;
                clearBtn.Enabled = false;
                warnLabel.Visible = true;
            }
        }

        private void addEvents()
        {
            connection.Open();
            string selectSQL = "SELECT * FROM event";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                eventDates.Add(new DateTime(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
            }
            calendar.BoldedDates = eventDates.ToArray();
            command.Dispose();
            connection.Close();
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!eventDates.Contains(calendar.SelectionRange.Start))
            {
                eventDescrBox.Clear();
                return;
            }
            connection.Open();
            string selectSQL = "SELECT description FROM event WHERE year=@year AND month=@month AND day=@day";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@year", calendar.SelectionRange.Start.Year);
            command.Parameters.AddWithValue("@month", calendar.SelectionRange.Start.Month);
            command.Parameters.AddWithValue("@day", calendar.SelectionRange.Start.Day);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.Read()) eventDescrBox.Text = reader.GetString(0);
            command.Dispose();
            connection.Close();
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
            //int index = (currentPage - 1) * commentsPerPage + 1;
            commentsPanel.Controls.Clear();

            connection.Open();
            string countSQL = "SELECT count(*) FROM comment";
            SQLiteCommand command = new SQLiteCommand(countSQL, connection);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());

            string selectSQL = "SELECT * FROM comment ORDER BY id DESC LIMIT @limit OFFSET @offset";
            command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@limit", commentsPerPage);
            command.Parameters.AddWithValue("@offset", commentsPerPage * (currentPage - 1));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Size = new Size(commentsPanel.Width, commentBox.Height);

                RichTextBox bodyBox = new RichTextBox();
                bodyBox.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                bodyBox.Text = reader.GetString(2);
                bodyBox.Font = new Font("Arial", 18);
                bodyBox.ReadOnly = true;

                LinkLabel authorLabel = new LinkLabel();
                authorLabel.RightToLeft = RightToLeft.Yes;
                authorLabel.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                authorLabel.Text = reader.GetString(1);
                authorLabel.Location = new Point(bodyBox.Location.X, bodyBox.Location.Y + bodyBox.Height + 10);

                RichTextBox ratingBox = new RichTextBox();
                ratingBox.Size = new Size(50, commentBox.Height / 2);
                ratingBox.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, bodyBox.Location.Y);
                ratingBox.Text = reader.GetInt32(3).ToString();
                ratingBox.Font = new Font("Arial", 16, FontStyle.Bold);
                Button downvote = new Button();
                downvote.Size = new Size(25, commentBox.Height / 2);
                downvote.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, ratingBox.Location.Y + ratingBox.Height);
                downvote.Font = new Font("Arial", 16, FontStyle.Bold);
                downvote.Text = "-";
                downvote.Name = "d" + reader.GetInt32(0).ToString();
                Button upvote = new Button();
                upvote.Size = new Size(25, commentBox.Height / 2);
                upvote.Location = new Point(downvote.Location.X + downvote.Width, ratingBox.Location.Y + ratingBox.Height);
                upvote.Font = new Font("Arial", 16, FontStyle.Bold);
                upvote.Text = "+";
                upvote.Name = "u" + reader.GetInt32(0).ToString();
                ratingBox.ReadOnly = true;

                panel.Controls.Add(bodyBox);
                panel.Controls.Add(authorLabel);
                panel.Controls.Add(ratingBox);
                panel.Controls.Add(upvote);
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

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (!commentBox.Text.Equals(""))
            {
                connection.Open();
                String insertSQL = "INSERT INTO comment (author, body, rating) VALUES(@author, @body, 0)";
                SQLiteCommand command = new SQLiteCommand(insertSQL, connection);
                command.Parameters.AddWithValue("@author", getUsername());
                command.Parameters.AddWithValue("@body", commentBox.Text);
                int rowsAffected = command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Επιτυχής ανάρτηση!", "Info");
                showComments(currentPage);
            }
        }
    }
}
