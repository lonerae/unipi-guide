using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using System.Data.Common;

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
        string connectionString = "DataSource = unipiGuide.db;Version = 3";

        List<DateTime> eventDates = new List<DateTime>();
        int currentPage = 1;
        int commentsPerPage = 3;
        int maxPages;

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
            string selectSQL = "SELECT * FROM event";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
            {
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eventDates.Add(new DateTime(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3)));
                    }
                }
            }
            calendar.BoldedDates = eventDates.ToArray();
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!eventDates.Contains(calendar.SelectionRange.Start))
            {
                eventDescrBox.Clear();
                return;
            }

            string selectSQL = "SELECT description FROM event WHERE year=@year AND month=@month AND day=@day";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
            {
                connection.Open();
                //TODO: multiple events in same day???
                command.Parameters.AddWithValue("@year", calendar.SelectionRange.Start.Year);
                command.Parameters.AddWithValue("@month", calendar.SelectionRange.Start.Month);
                command.Parameters.AddWithValue("@day", calendar.SelectionRange.Start.Day);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) eventDescrBox.Text = reader.GetString(0);
                }
            }
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
            string countSQL = "SELECT count(*) FROM comment";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(countSQL, connection))
            {
                connection.Open();
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                maxPages = (int)Math.Ceiling((double)count / commentsPerPage);
            }

            for (int i = 1; i <= maxPages; i++)
            {
                pageDropdown.Items.Add(i.ToString());
            }
        }

        private void showComments(int currentPage)
        {
            commentsPanel.Controls.Clear();
            string selectSQL = "SELECT * FROM comment ORDER BY id DESC LIMIT @limit OFFSET @offset";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@limit", commentsPerPage);
                command.Parameters.AddWithValue("@offset", commentsPerPage * (currentPage - 1));
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
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
                        downvote.Size = new Size(25, commentBox.Height / 2 - 5);
                        downvote.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, ratingBox.Location.Y + ratingBox.Height + 5);
                        downvote.Font = new Font("Arial", 16, FontStyle.Bold);
                        downvote.Text = "-";
                        downvote.Name = "d" + reader.GetInt32(0).ToString();
                        downvote.FlatStyle = FlatStyle.Flat;
                        downvote.FlatAppearance.BorderSize = 0;

                        Button upvote = new Button();
                        upvote.Size = new Size(25, commentBox.Height / 2 - 5);
                        upvote.Location = new Point(downvote.Location.X + downvote.Width, ratingBox.Location.Y + ratingBox.Height + 5);
                        upvote.Font = new Font("Arial", 16, FontStyle.Bold);
                        upvote.Text = "+";
                        upvote.Name = "u" + reader.GetInt32(0).ToString();
                        upvote.FlatStyle = FlatStyle.Flat;
                        upvote.FlatAppearance.BorderSize = 0;

                        ratingBox.ReadOnly = true;

                        panel.Controls.Add(bodyBox);
                        panel.Controls.Add(authorLabel);
                        panel.Controls.Add(ratingBox);
                        panel.Controls.Add(upvote);
                        panel.Controls.Add(downvote);

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
                }    
            }
            setVotes();
        }

        private void addVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            vote(btn, BUTTON_ACTIONS.UPVOTE);
        }

        private void subtractVote(object sender, EventArgs e)
        {
            var btn = sender as Button;
            vote(btn, BUTTON_ACTIONS.DOWNVOTE);
        }
        
        private void vote(Button btn, BUTTON_ACTIONS action)
        {
            int value = 0;
            if (action == BUTTON_ACTIONS.UPVOTE) value = 1;
            else if (action == BUTTON_ACTIONS.DOWNVOTE) value = -1;

            int userId = findUserId(getUsername());
            int commentId = Int32.Parse(btn.Name.Substring(1));
            string findAction = @"SELECT action 
                                FROM rating_action AS ra
                                INNER JOIN user_rating AS ur
                                    ON ra.id = ur.actionID
                                WHERE 
                                    ur.userId=@userId 
                                    AND ur.commentId=@commentId";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findActionCommand = new SQLiteCommand(findAction, connection))
            {
                connection.Open();
                findActionCommand.Parameters.AddWithValue("@userId", userId);
                findActionCommand.Parameters.AddWithValue("@commentId", commentId);
                using (SQLiteDataReader findActionReader = findActionCommand.ExecuteReader())
                {
                    if (findActionReader.Read())
                    {
                        if (findActionReader.GetString(0).Equals(action.ToString())) return;
                        // one value for reset, one more for action
                        else value *= 2;
                    }
                }    
            }

            int finalValue = 0;
            string findRating = "SELECT rating FROM comment WHERE id = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findRatingCommand = new SQLiteCommand(findRating, connection))
            {
                connection.Open();
                findRatingCommand.Parameters.AddWithValue("@id", commentId);
                using (SQLiteDataReader findRatingReader = findRatingCommand.ExecuteReader())
                {
                    if (findRatingReader.Read()) finalValue = findRatingReader.GetInt32(0) + value;
                    else return;
                }
            }

            string updateSQL = "UPDATE comment SET rating = @value WHERE id = @commentId";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand updateCommand = new SQLiteCommand(updateSQL, connection))
            {
                connection.Open();
                updateCommand.Parameters.AddWithValue("@value", finalValue);
                updateCommand.Parameters.AddWithValue("@commentId", commentId);
                int rows = updateCommand.ExecuteNonQuery();
            }

            showComments(currentPage);
        }

        private void setVotes()
        {
            int userId = -1;
            String findUser = "SELECT id FROM user WHERE username=@username";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findUserCommand = new SQLiteCommand(findUser, connection))
            {
                connection.Open();
                findUserCommand.Parameters.AddWithValue("@username", getUsername());
                using (SQLiteDataReader findUserReader = findUserCommand.ExecuteReader())
                {
                    if (findUserReader.Read()) userId = findUserReader.GetInt32(0);
                    else return;
                }
            }

            String findVotes = "SELECT commentId, actionId  FROM user_rating WHERE userId=@userId";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findVotesCommand = new SQLiteCommand(findVotes, connection))
            {
                connection.Open();
                findVotesCommand.Parameters.AddWithValue("@userId", userId);
                using (SQLiteDataReader findVotesReader = findVotesCommand.ExecuteReader())
                {
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
                }
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (!commentBox.Text.Equals(""))
            {
                int userId = 0;
                String selectSQL = "SELECT id FROM user WHERE username=@username";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(selectSQL, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", getUsername());
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) userId = reader.GetInt32(0);
                        else
                        {
                            MessageBox.Show("Άκυρος χρήστης", "Warning");
                            return;
                        }
                    }
                }

                String insertSQL = "INSERT INTO comment (userId, body, rating) VALUES (@author, @body, 0)";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                using (SQLiteCommand command = new SQLiteCommand(insertSQL, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@author", userId);
                    command.Parameters.AddWithValue("@body", commentBox.Text);
                    int rows = command.ExecuteNonQuery();
                    MessageBox.Show("Επιτυχής ανάρτηση!", "Info");
                    setPagination();
                    showComments(currentPage);
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
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findUserCommand = new SQLiteCommand(findUser, connection))
            {
                connection.Open();
                findUserCommand.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader findUserReader = findUserCommand.ExecuteReader())
                {
                    if (findUserReader.Read()) return findUserReader.GetString(0);
                }
                return "";
            }
        }

        private int findUserId(string username)
        {
            String findUser = "SELECT id FROM user WHERE username=@username";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand findUserCommand = new SQLiteCommand(findUser, connection))
            {
                connection.Open();
                findUserCommand.Parameters.AddWithValue("@username", getUsername());
                using (SQLiteDataReader findUserReader = findUserCommand.ExecuteReader())
                {
                    if (findUserReader.Read()) return findUserReader.GetInt32(0);
                }
                return -1;
            }
        }
    }
}
