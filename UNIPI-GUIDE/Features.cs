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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UNIPI_GUIDE
{
    public partial class Features : BaseForm
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            featureTree.BeginUpdate();
            featureTree.Nodes.Add("Φοιτητική Μέριμνα");
            featureTree.Nodes[0].Nodes.Add("Υγειονομική Περίθαλψη");
            featureTree.Nodes[0].Nodes.Add("Σίτιση");
            featureTree.Nodes[0].Nodes.Add("Φοιτητικές Εστίες");
            featureTree.Nodes.Add("Βιβλιοθήκη");
            featureTree.Nodes.Add("Ευρωπαϊκά Προγράμματα");
            featureTree.Nodes[2].Nodes.Add("Erasmus+");
            featureTree.Nodes.Add("Ιατρείο");
            featureTree.EndUpdate();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            changeForm(new History(), false);
        }

        private void greetingBtn_Click(object sender, EventArgs e)
        {
            changeForm(new Greeting(), false);
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            changeForm(new Location(), false);
        }

        private void featureTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = "";
            if (featureTree.SelectedNode != null)
            {
                switch (featureTree.SelectedNode.Text)
                {
                    case "Φοιτητική Μέριμνα":
                        key = "foititiki_merimna";
                        break;
                    case "Υγειονομική Περίθαλψη":
                        key = "perithalpsi";
                        break;
                    case "Σίτιση":
                        key = "sitisi";
                        break;
                    case "Φοιτητικές Εστίες":
                        key = "esties";
                        break;
                    case "Βιβλιοθήκη":
                        key = "vivliothiki";
                        break;
                    case "Ευρωπαϊκά Προγράμματα":
                        key = "programmata";
                        break;
                    case "Erasmus+":
                        key = "erasmus";
                        break;
                    case "Ιατρείο":
                        key = "iatreio";
                        break;
                }
            }
            if (string.IsNullOrEmpty(key)) return;
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_TEXT, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@key",key);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) descrBox.Text = Utils.readMultilineFromDB(reader.GetString(reader.GetOrdinal("description")));
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            changeForm(new Home(), false);
        }
    }
}
