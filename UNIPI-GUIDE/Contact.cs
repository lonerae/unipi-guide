using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string subject = subjectTextBox.Text;
            string body = bodyTextBox.Text.Replace("\n", "%0d%0A"); // regular line breaks were ignored
            if (subject != "" && body != "") System.Diagnostics.Process.Start("mailto:malvertis@protonmail.com?subject=" + subject + "&body=" + body);
            else MessageBox.Show("Το θέμα ή το κείμενο είναι κενό.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            subjectTextBox.Clear();
            bodyTextBox.Clear();
        }

        private void Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bodyTextBox.Text != "")
            {
                if (MessageBox.Show("Έχετε κείμενο που δεν έχει σταλεί. Είστε σίγουροι ότι θέλετε να φύγετε?",
                                    "Υπενθύμιση",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
