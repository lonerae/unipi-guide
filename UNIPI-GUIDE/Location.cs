using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIPI_GUIDE
{
    public partial class Location : BaseForm
    {
        public Location()
        {
            InitializeComponent();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            using(SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_LOCATION_LINK, connection))
            {
                connection.Open();
                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) Process.Start(reader.GetString(reader.GetOrdinal("url")));
                }
            }
            
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            changeForm(new History(), false);
        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            changeForm(new Greeting(), false);
        }

        private void featureBtn_Click(object sender, EventArgs e)
        {
            changeForm(new Features(), false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            changeForm(new Home(), false);
        }
    }
}
