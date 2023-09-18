using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UNIPI_GUIDE.Program;

namespace UNIPI_GUIDE
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();           
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using(SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using(SQLiteCommand command = new SQLiteCommand(Constants.RETURN_ID_FROM_USERNAME_AND_PASSWORD,connection)) 
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", usernameTextBox.Text);
                command.Parameters.AddWithValue("@password", passwordTextBox.Text);

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User.loggedIn = true;
                        User.id = reader.GetInt32(0);
                        if (MessageBox.Show("Καλώς ήρθες " + usernameTextBox.Text + "!", Constants.POPUP_SOURCE) == DialogResult.OK) this.Close();
                    }
                    else MessageBox.Show(Constants.INVALID_CREDENTIALS_ERROR, Constants.POPUP_SOURCE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
