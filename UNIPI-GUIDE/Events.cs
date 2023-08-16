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

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
        string connectionString = "DataSource = unipiGuide.db;Version = 3";
        SQLiteConnection connection;

        List<DateTime> eventDates = new List<DateTime>();
        int currentPage = 1;
        int commentsPerPage = 3;

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
                RichTextBox temp = new RichTextBox();
                temp.Size = new Size(commentsPanel.Width, commentBox.Height);
                temp.Text = reader.GetString(2);
                commentsPanel.Controls.Add(temp);
            }
            command.Dispose();
            connection.Close();
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
