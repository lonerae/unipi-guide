using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace UNIPI_GUIDE
{
    public partial class Events : BaseForm
    {
        List<DateTime> eventDates = new List<DateTime>();
        int currentPage = 1;
        int commentsPerPage = 5;

        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // adding based on SELECT query
            eventDates.Add(new DateTime(2023, 7, 30));
            calendar.BoldedDates = eventDates.ToArray();
            for (int i = currentPage; i < currentPage + commentsPerPage; i++)
            {
                RichTextBox temp = new RichTextBox();
                temp.Size = new Size(commentsPanel.Width, commentBox.Height);
                temp.Text = i.ToString();
                commentsPanel.Controls.Add(temp);
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
            currentPage++;
            commentsPanel.Controls.Clear();
            for (int i = currentPage; i < currentPage + commentsPerPage; i++)
            {
                RichTextBox temp = new RichTextBox();
                temp.Size = new Size(commentsPanel.Width, commentBox.Height);
                temp.Text = i.ToString();
                commentsPanel.Controls.Add(temp);
            }
        }
    }
}
