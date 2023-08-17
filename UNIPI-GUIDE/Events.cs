using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
        string connectionString = "DataSource = unipiGuide.db;Version = 3";
        SQLiteConnection connection;

        List<DateTime> eventDates = new List<DateTime>();
        int currentPage = 1;
        int commentsPerPage = 3;
        int maxPages;

        List<int> voteList = new List<int>();
        // same as rating_actions
        enum BUTTON_ACTIONS
        {
            UPVOTE,
            DOWNVOTE
        }

        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);
            showComments(currentPage);
            setPagination();
            pageDropdown.SelectedIndex = 0;
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
            //TODO: multiple events in same day???
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
            if (currentPage >= maxPages) return;
            currentPage += 1;
            showComments(currentPage);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) return;
            currentPage -= 1;
            showComments(currentPage);
        }

        private void setPagination()
        {
            connection.Open();
            string countSQL = "SELECT count(*) FROM comment";
            SQLiteCommand command = new SQLiteCommand(countSQL, connection);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
            maxPages = (int)Math.Ceiling((double)count / commentsPerPage);

            for (int i = 1; i <= maxPages; i++)
            {
                pageDropdown.Items.Add(i.ToString());
            }
        }

        private void showComments(int currentPage)
        {
            commentsPanel.Controls.Clear();
            connection.Open();
            string selectSQL = "SELECT * FROM comment ORDER BY id DESC LIMIT @limit OFFSET @offset";
            SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
            command.Parameters.AddWithValue("@limit", commentsPerPage);
            command.Parameters.AddWithValue("@offset", commentsPerPage * (currentPage - 1));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Size = new Size(commentsPanel.Width, commentBox.Height);
                panel.Name = "p" + reader.GetInt32(0).ToString();

                RichTextBox bodyBox = new RichTextBox();
                bodyBox.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                bodyBox.Text = reader.GetString(2);
                bodyBox.Font = new Font("Arial", 18);
                bodyBox.ReadOnly = true;

                LinkLabel authorLabel = new LinkLabel();
                authorLabel.RightToLeft = RightToLeft.Yes;
                authorLabel.Size = new Size(commentsPanel.Width - 100, commentBox.Height / 2);
                authorLabel.Text = findUsername(reader.GetInt32(1));
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
            setVotes();
            command.Dispose();
            connection.Close();
        }

        private void addVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //vote(btn, 1, BUTTON_ACTIONS.UPVOTE);
        }

        private void subtractVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //vote(btn, -1, BUTTON_ACTIONS.DOWNVOTE);
        }
        /*
        private void vote(Button btn, int value, BUTTON_ACTIONS action)
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
        */
        private void setVotes()
        {
            String findUser = "SELECT id FROM user WHERE username=@username";
            SQLiteCommand findUserCommand = new SQLiteCommand(findUser, connection);
            findUserCommand.Parameters.AddWithValue("@username", getUsername());
            SQLiteDataReader findUserReader = findUserCommand.ExecuteReader();
            if (findUserReader.Read())
            {
                String findVotes = "SELECT commentId, actionId  FROM user_rating WHERE userId=@userId";
                SQLiteCommand findVotesCommand = new SQLiteCommand(findVotes, connection);
                findVotesCommand.Parameters.AddWithValue("@userId", findUserReader.GetInt32(0));
                SQLiteDataReader findVotesReader = findVotesCommand.ExecuteReader();
                foreach (Control c in commentsPanel.Controls) Console.WriteLine(c.Name);
                while (findVotesReader.Read())
                {
                    Panel parent = (Panel)commentsPanel.Controls["p" + findVotesReader.GetInt32(0).ToString()];
                    if (parent != null)
                    {
                        string res;
                        Button temp;
                        switch (findVotesReader.GetInt32(1))
                        {
                            case 1:
                                res = "u" + findVotesReader.GetInt32(0).ToString();
                                temp = (Button)parent.Controls.Find(res, true).FirstOrDefault();
                                temp.BackColor = Color.Green;
                                break;
                            case 2:
                                res = "d" + findVotesReader.GetInt32(0).ToString();
                                temp = (Button)parent.Controls.Find(res, true).FirstOrDefault();
                                temp.BackColor = Color.Red;
                                break;
                            default:
                                break;
                        }
                    }
                }
                findVotesCommand.Dispose();
            }
            findUserCommand.Dispose();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (!commentBox.Text.Equals(""))
            {
                connection.Open();
                String selectSQL = "SELECT id FROM user WHERE username=@username";
                SQLiteCommand command = new SQLiteCommand(selectSQL, connection);
                command.Parameters.AddWithValue("@username", getUsername());
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    String insertSQL = "INSERT INTO comment (userId, body, rating) VALUES(@author, @body, 0)";
                    command = new SQLiteCommand(insertSQL, connection);
                    command.Parameters.AddWithValue("@author", reader.GetInt32(0));
                    command.Parameters.AddWithValue("@body", commentBox.Text);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Επιτυχής ανάρτηση!", "Info");
                    setPagination();
                    showComments(currentPage);
                }
                else
                {
                    MessageBox.Show("Άκυρος χρήστης", "Warning");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            commentBox.Clear();
        }

        private void pageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 page = Int32.Parse(pageDropdown.SelectedItem.ToString());
                if (page > 0 && page <= maxPages)
                {
                    currentPage = page;
                    showComments(currentPage);
                }
            }
            catch (Exception)
            {

            }
        }

        private string findUsername(int id)
        {
            String findUser = "SELECT username FROM user WHERE id=@id";
            SQLiteCommand findUserCommand = new SQLiteCommand(findUser, connection);
            findUserCommand.Parameters.AddWithValue("@id", id);
            SQLiteDataReader findUserReader = findUserCommand.ExecuteReader();
            findUserCommand.Dispose();
            if (findUserReader.Read()) return findUserReader.GetString(0);
            return "";
        }
    }
}
