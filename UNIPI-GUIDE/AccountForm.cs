using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UNIPI_GUIDE.Program;

namespace UNIPI_GUIDE
{
    public partial class AccountForm : Form
    {
        private string firstName;
        private string lastName;
        private string email;
        private string department;

        public AccountForm(string firstName, string lastName, string email, string department)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.department = department;
        }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = firstName + " " + lastName;
            departmentTextBox.Text = department;
            emailTextBox.Text = email;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailTextBox.Text))
            {
                if (Regex.Match(emailTextBox.Text, @"^[a-zA-Z0-9!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9]+\.[a-zA-Z]+$", RegexOptions.IgnoreCase).Success)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                    using (SQLiteCommand command = new SQLiteCommand(Constants.UPDATE_EMAIL, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@id", User.id);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Επιτυχής επικαιροποίηση!", Constants.POPUP_SOURCE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Μη επιτρεπτή διεύθυνση.", Constants.POPUP_SOURCE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
