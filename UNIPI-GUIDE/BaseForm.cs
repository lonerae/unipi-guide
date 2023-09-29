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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            initializeToolstrip();
        }

        private void initializeToolstrip()
        {
            // event handlers should be added only once. learnt the hard way.
            loginToolStripMenuItem.Click += new EventHandler(toggleHandler);
            loginToolStripMenuItem.MouseHover += new EventHandler(showDropdown);
            updateToolstrip();
        }

        private void updateToolstrip()
        {
            if (User.loggedIn)
            {
                loginToolStripMenuItem.Text = "Λογαριασμός";
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
                loginToolStripMenuItem.DropDownItems.Clear();
            }
        }

        private void toggleHandler(object sender, EventArgs e)
        {
            if (User.loggedIn) showOwnInfo();
            else login();
        }

        private void login()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            updateToolstrip();
            this.resetForm(User.loggedIn);
            if (navPanel.Visible)
            {
                papeiButton.Visible = true;
                papeiButton.BringToFront();
            }
        }

        private void showDropdown(object sender, EventArgs e)
        {
            if (User.loggedIn) loginToolStripMenuItem.DropDown.Show();
        }

        private void logout(object sender, EventArgs e)
        {
            User.loggedIn = false;
            User.id = -1;
            User.username = "";
            updateToolstrip();
            this.resetForm(User.loggedIn);
            if (navPanel.Visible) papeiButton.Visible = false;
        }

        private void showOwnInfo()
        {
            if (User.loggedIn)
            {
                bool found = false;
                string firstName = "";
                string lastName = "";
                string department = "";
                string email = "";

                using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
                using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_ACCOUNT_INFO_SQL, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@userId", User.id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            found = true;
                            firstName = reader.GetString(0);
                            lastName = reader.GetString(1);
                            department = reader.GetString(2);
                            email = reader.GetString(3);
                        }
                    }
                }
                if (found)
                {
                    changeForm(new AccountForm(firstName, lastName, department, email), true);
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
                        MessageBox.Show(accountInfo, "Πληροφορίες", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                }
            }
        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.loggedIn)
            {
                papeiButton.Visible = !papeiButton.Visible;
                papeiButton.BringToFront();
            }
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
            if (User.loggedIn) changeForm(new Contact(), true);
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

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
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
                bool safetyMeasure = User.loggedIn;
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
                    if (form.Controls["papeiButton"] != null) form.Controls["papeiButton"].Visible = false;
                }
            }
            else form.ShowDialog();
        }

        /**
         * Displayed on all actions denied to logged out users.
         */
        protected void showLogInError()
        {
            MessageBox.Show("Πρώτα πρέπει να συνδεθείτε ή να φτιάξετε λογαριασμό.", "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }     

        /**
         * Returns username based on account's id.
         */
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

        private void papeiButton_Click(object sender, EventArgs e)
        {
            changeForm(new OurForm(), false);
        }
    }
}
