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
    public partial class BaseForm : Form
    {
        bool loggedIn = true;

        public BaseForm()
        {
            InitializeComponent();
        }

        public bool isLogged()
        {
            return loggedIn;
        }

        public void setLogged(bool loggedIn) 
        {
            this.loggedIn = loggedIn;
        }

        private void navigateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navPanel.Visible = !navPanel.Visible;
            if (navPanel.Visible) navPanel.BringToFront();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            Events events = new Events();
            events.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Αλβέρτης Μηνάς, Σκυλογιάννης Θωμάς\n\nΕργασία ΤΑΕ 2022-23", "Σχετικά");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
