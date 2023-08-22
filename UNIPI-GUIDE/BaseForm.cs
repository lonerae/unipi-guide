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

namespace UNIPI_GUIDE
{
    public partial class BaseForm : Form
    {
        static bool loggedIn;
        string username = "malve";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            updateToolstrip();
        }

        private void updateToolstrip()
        {
            if (isLogged())
            {
                loginToolStripMenuItem.Text = "Λογαριασμός";
                loginToolStripMenuItem.Click += new EventHandler(showOwnInfo);
                loginToolStripMenuItem.MouseHover += new EventHandler(showDropdown);
                if (loginToolStripMenuItem.DropDownItems.Count == 0)
                {
                    ToolStripItem logoutToolStripMenuItem = loginToolStripMenuItem.DropDownItems.Add("Αποσύνδεση");
                    logoutToolStripMenuItem.Click += new EventHandler(logout);
                    logoutToolStripMenuItem.Font = new Font("Arial", 10);
                }
            }
            else
            {
                loginToolStripMenuItem.Text = "Σύνδεση";
                loginToolStripMenuItem.Click += new EventHandler(login);
                loginToolStripMenuItem.DropDownItems.Clear();
            }
        }

        private void login(object sender, EventArgs e)
        {
            //TODO: implement
            loggedIn = true;
            username = "malve";
            updateToolstrip();
            BaseForm f = (BaseForm) ActiveForm;
            f.resetForm(isLogged());
        }

        private void showDropdown(object sender, EventArgs e)
        {
            loginToolStripMenuItem.DropDown.Show();
        }

        private void logout(object sender, EventArgs e)
        {
            //TODO: implement
            loggedIn = false;
            username = "";
            updateToolstrip();
            this.resetForm(isLogged());
        }

        private void showOwnInfo(object sender, EventArgs e)
        {
            if (isLogged())
            {
                using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_ACCOUNT_INFO_SQL, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@userId", findUserId(username));
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string accountInfo = "Όνομα: " + reader.GetString(0) + "\n\n" +
                                             "Επώνυμο: " + reader.GetString(1) + "\n\n" +
                                             "E-mail: " + reader.GetString(2) + "\n\n" +
                                             "Τμήμα: " + reader.GetString(3);
                            MessageBox.Show(accountInfo, "Πληροφορίες");
                        }
                    }
                }
            }
           
        }

        // ONLY WORKS FOR THE LINK LABELS OF EVENTS FORM FOR NOW
        protected void showAccountInfo(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel) sender;
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_ACCOUNT_INFO_SQL, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@userId", linkLabel.Name.Substring(1));
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string accountInfo = "Όνομα: " + reader.GetString(0) + "\n\n" +
                                         "Επώνυμο: " + reader.GetString(1) + "\n\n" +
                                         "E-mail: " + reader.GetString(2) + "\n\n" +
                                         "Τμήμα: " + reader.GetString(3);
                        MessageBox.Show(accountInfo, "Πληροφορίες");
                    }    
                }
            }
        }

        public bool isLogged()
        {
            return loggedIn;
        }

        public void setLogged(bool loggedIn) 
        {
            BaseForm.loggedIn = loggedIn;
        }

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string username) 
        {
            this.username = username;        
        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navPanel.Visible = !navPanel.Visible;
            if (navPanel.Visible) navPanel.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            changeForm(Application.OpenForms[0], false);
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            changeForm(new Events(), false);
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogged()) changeForm(new Contact(), true);
            else showLogInError();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Αλβέρτης Μηνάς, Σκυλογιάννης Θωμάς\n\nΕργασία ΤΑΕ 2022-23", "Σχετικά");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // HELPER FUNCTIONS

        /**
       * Implemented on Forms that have components that react differently to logged in users
       */
        protected virtual void resetForm(bool loggedIn)
        {
        }

        /**
         * Dispose every form except for the homepage, which is stored and resurfaced.
         * If popup is true, the form is displayed modally.
         */
        protected void changeForm(Form form, bool isPopup)
        {
            if (!isPopup)
            {
                bool safetyMeasure = this.isLogged();
                bool wasOnHome = ActiveForm == Application.OpenForms[0];
                form.Show();
                bool isOnHome = ActiveForm == Application.OpenForms[0];
                if (wasOnHome)
                {
                    if (!isOnHome) this.Hide();
                }
                else
                {
                    this.Dispose();
                    if (isOnHome) ((BaseForm) Application.OpenForms[0]).updateToolstrip(); // toolstrip was resurfaced, not reinitialized
                    form.Controls["navPanel"].Visible = false;
                }
            }
            else form.ShowDialog();
        }

        protected void showLogInError()
        {
            MessageBox.Show("Πρώτα πρέπει να συνδεθείτε ή να φτιάξετε λογαριασμό.", "Error");
        }

        protected string findUsername(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand findUserCommand = new SQLiteCommand(Constants.RETURN_USERNAME_FROM_ID_SQL, connection))
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

        protected int findUserId(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand findUserCommand = new SQLiteCommand(Constants.RETURN_ID_FROM_USERNAME_SQL, connection))
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
