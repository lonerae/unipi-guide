﻿using System;
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
        //TODO: move to constants class
        string connectionString = "DataSource = unipiGuide.db;Version = 3";
        string selectInfo = @"SELECT ui.firstname, ui.lastname, ui.email, d.name
                                FROM userInfo AS ui
                                INNER JOIN department AS d
                                    ON ui.departmentId = d.id
                                WHERE userId = @userId";

        bool loggedIn = true;
        string username = "malve";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                loginToolStripMenuItem.Text = "Λογαριασμός";
                loginToolStripMenuItem.Click += new EventHandler(showOwnInfo);
            }
            else
            {
                loginToolStripMenuItem.Text = "Σύνδεση";
                loginToolStripMenuItem.Click += new EventHandler(login);
            }
        }

        private void login(object sender, EventArgs e)
        {
            //TODO: implement
        }

        private void showOwnInfo(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(selectInfo, connection))
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

        // ONLY WORKS FOR THE LINK LABELS OF EVENTS FORM FOR NOW
        protected void showAccountInfo(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel) sender;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(selectInfo, connection))
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
            this.loggedIn = loggedIn;
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

        /**
        * Helper functions for common use
        */
        protected string findUsername(int id)
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

        protected int findUserId(string username)
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
