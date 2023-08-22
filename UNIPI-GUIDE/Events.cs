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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text;

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
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
        }

        private void addEvents()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_ALL_EVENTS_SQL, connection))
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

            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_EVENT_DESCRIPTION_BASED_ON_DATE_SQL, connection))
            {
                bool first = true;
                connection.Open();
                command.Parameters.AddWithValue("@year", calendar.SelectionRange.Start.Year);
                command.Parameters.AddWithValue("@month", calendar.SelectionRange.Start.Month);
                command.Parameters.AddWithValue("@day", calendar.SelectionRange.Start.Day);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string description = setDateEvents(reader);
                        string delimiter = "\n-------------------------------------------------------------------------------------------------------------------------\n";
                        if (first)
                        {
                            eventDescrBox.Text = description.ToString();
                            first = false;
                        }
                        else eventDescrBox.Text += delimiter + description.ToString();

                    }
                }
            }
        }

        private string setDateEvents(SQLiteDataReader reader)
        {
            StringBuilder description = new StringBuilder();
            if (reader.GetValue(1).GetType() != typeof(DBNull))
            {

                description.Append(Convert.ToInt32(reader.GetValue(1)).ToString("D2"));
                description.Append(".");
                if (reader.GetValue(2).GetType() != typeof(DBNull)) description.Append(Convert.ToInt32(reader.GetValue(2)).ToString("D2"));
                else description.Append("00");
                description.Append(" : ");
            }
            description.Append(reader.GetString(0));
            return description.ToString();
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
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.COUNT_ALL_COMMENTS_SQL, connection))
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
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_PAGE_OF_COMMENTS_SQL, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@limit", commentsPerPage);
                command.Parameters.AddWithValue("@offset", commentsPerPage * (currentPage - 1));
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    drawCommentPanel(reader);
                }    
            }
            setVotes();
        }

        private void drawCommentPanel(SQLiteDataReader reader)
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
                authorLabel.Name = "l" + reader.GetInt32(1);

                RichTextBox ratingBox = new RichTextBox();
                ratingBox.Size = new Size(50, commentBox.Height / 2);
                ratingBox.Location = new Point(bodyBox.Location.X + bodyBox.Width + 40, bodyBox.Location.Y);
                ratingBox.Text = reader.GetInt32(3).ToString();
                ratingBox.Font = new Font("Arial", 16, FontStyle.Bold);
                ratingBox.ReadOnly = true;

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
                
                if (!isLogged())
                {
                    upvote.Click += new EventHandler(error);
                    downvote.Click += new EventHandler(error);
                    authorLabel.Click += new EventHandler(error);
                }
                else
                {
                    upvote.Click += new EventHandler(addVote);
                    downvote.Click += new EventHandler(subtractVote);
                    authorLabel.Click += new EventHandler(showAccountInfo);
                }

                panel.Controls.Add(bodyBox);
                panel.Controls.Add(authorLabel);
                panel.Controls.Add(ratingBox);
                panel.Controls.Add(upvote);
                panel.Controls.Add(downvote);

                commentsPanel.Controls.Add(panel);
            }
        }

        private void error(object sender, EventArgs e)
        {
            showLogInError();
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
            // SET ACTION AND VOTE-VALUE BASED ON BUTTON
            int value = 0;
            int actionId = 0;
            if (action == BUTTON_ACTIONS.UPVOTE)
            {
                actionId = 1;
                value = 1;
            }
            else if (action == BUTTON_ACTIONS.DOWNVOTE)
            {
                actionId = 2;
                value = -1;
            }

            // FIND WHETHER THE USER HAS ALREADY INTERACTED WITH SELECTED COMMENT AND THE SPECIFIC ACTION
            int userId = findUserId(getUsername());
            int commentId = Int32.Parse(btn.Name.Substring(1));
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand findActionCommand = new SQLiteCommand(Constants.RETURN_ACTION_OF_USER_ON_COMMENT_SQL, connection))
            {
                connection.Open();
                findActionCommand.Parameters.AddWithValue("@userId", userId);
                findActionCommand.Parameters.AddWithValue("@commentId", commentId);
                using (SQLiteDataReader findActionReader = findActionCommand.ExecuteReader())
                {
                    if (findActionReader.Read())
                    {
                        if (findActionReader.GetString(0).Equals(action.ToString()))
                        {
                            actionId = -1;
                            value *= -1; // negative value for reset
                        }
                        else value *= 2; // one value for reset, one more for action
                    }
                }    
            }

            // GET THE COMMENT'S CURRENT RATING (SEEMED SAFER THAN TRUSTING THE FRONTEND)
            int finalValue = 0;
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand findRatingCommand = new SQLiteCommand(Constants.RETURN_RATING_OF_COMMENT_SQL, connection))
            {
                connection.Open();
                findRatingCommand.Parameters.AddWithValue("@id", commentId);
                using (SQLiteDataReader findRatingReader = findRatingCommand.ExecuteReader())
                {
                    if (findRatingReader.Read()) finalValue = findRatingReader.GetInt32(0) + value;
                    else return;
                }
            }

            // UPDATE COMMENT'S RATING
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand updateCommand = new SQLiteCommand(Constants.UPDATE_COMMENT_RATING_SQL, connection))
            {
                connection.Open();
                updateCommand.Parameters.AddWithValue("@value", finalValue);
                updateCommand.Parameters.AddWithValue("@commentId", commentId);
                updateCommand.ExecuteNonQuery();
            }

            // UPDATE THE INTERACTION BY EITHER DELETING (ON RESET) OR CHANGING ACTION
            if (actionId == -1) 
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                using (SQLiteCommand deleteUserRatingCommand = new SQLiteCommand(Constants.DELETE_USER_COMMENT_ASSOCIATION_SQL, connection))
                {
                    connection.Open();
                    deleteUserRatingCommand.Parameters.AddWithValue("@userId", userId);
                    deleteUserRatingCommand.Parameters.AddWithValue("@commentId", commentId);
                    deleteUserRatingCommand.ExecuteNonQuery();
                }
            }
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                using (SQLiteCommand updateUserRatingCommand = new SQLiteCommand(Constants.UPSERT_USER_COMMENT_ASSOCIATION_SQL, connection))
                {
                    connection.Open();
                    updateUserRatingCommand.Parameters.AddWithValue("@userId", userId);
                    updateUserRatingCommand.Parameters.AddWithValue("@commentId", commentId);
                    updateUserRatingCommand.Parameters.AddWithValue("@actionId", actionId);
                    updateUserRatingCommand.ExecuteNonQuery();
                }

            }

            // SHOW IT ALL FROM THE START
            showComments(currentPage);
        }

        /**
         *  Highlights the appropriate action, on occasion of previous interaction by user. 
        */
        private void setVotes()
        {
            int userId = findUserId(getUsername());
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand findVotesCommand = new SQLiteCommand(Constants.RETURN_ASSOCIATED_COMMENTS_OF_USER_SQL, connection))
            {
                connection.Open();
                findVotesCommand.Parameters.AddWithValue("@userId", userId);
                using (SQLiteDataReader findVotesReader = findVotesCommand.ExecuteReader())
                {
                    paintActionBackgrounds(findVotesReader);
                }
            }
        }

        private void paintActionBackgrounds(SQLiteDataReader reader)
        {
            while (reader.Read())
            {
                Panel parent = (Panel)commentsPanel.Controls["p" + reader.GetInt32(0).ToString()];
                if (parent != null)
                {
                    string res;
                    Button temp;
                    switch (reader.GetInt32(1))
                    {
                        case 1:
                            res = "u" + reader.GetInt32(0).ToString();
                            temp = (Button)parent.Controls.Find(res, true).FirstOrDefault();
                            temp.BackColor = Color.Green;
                            break;
                        case 2:
                            res = "d" + reader.GetInt32(0).ToString();
                            temp = (Button)parent.Controls.Find(res, true).FirstOrDefault();
                            temp.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }       
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (isLogged())
            {
                if (!commentBox.Text.Equals(""))
                {
                    int userId = findUserId(getUsername());
                    using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                    using (SQLiteCommand command = new SQLiteCommand(Constants.INSERT_NEW_COMMENT_SQL, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@author", userId);
                        command.Parameters.AddWithValue("@body", commentBox.Text);
                        int rows = command.ExecuteNonQuery();
                        if (rows != -1)
                        {
                            MessageBox.Show("Επιτυχής ανάρτηση!", "Info");
                            setPagination();
                            showComments(currentPage);
                        }
                        else MessageBox.Show("Κάτι πήγε λάθος...", "Error");
                    }
                }
            }
            else showLogInError();
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
            catch (Exception) {} // in case of invalid input
        }

        protected override void resetForm(bool loggedIn)
        {
            showComments(currentPage);
        }
    }
}
