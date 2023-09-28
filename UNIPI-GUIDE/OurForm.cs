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
    public partial class OurForm : BaseForm
    {
        public OurForm()
        {
            InitializeComponent();
        }

        private void OurForm_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_DEPARTMENTS, connection))
            {
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader()) 
                {
                    int i = 0;
                    int j = 0;
                    while (reader.Read())
                    {
                        Button button = new Button();
                        button.Text = reader.GetString(reader.GetOrdinal("name"));
                        button.Location = new Point(400*(1+i),100*(j+1));
                        button.Size = new Size(300, 50);
                        button.Font = new Font("Arial", 16);
                        button.BackColor = Color.FromArgb(128, 128, 255);
                        button.FlatStyle = FlatStyle.Flat;
                        
                        i++;
                        if (i == 2)
                        {
                            i = 0;
                            j++;
                        }

                        this.Controls.Add(button);
                    }
                }
            }
        }

        protected override void resetForm(bool loggedIn)
        {
            if (!loggedIn)
            {
                MessageBox.Show("Περιεχόμενο μόνο για εγγεγραμμένους χρήστες.", Constants.POPUP_SOURCE);
                changeForm(new Home(), false);
            }
        }

        private void questionBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Από τους φοιτητές, για τους φοιτητές! Αν ενδιαφέρεσαι να προσθέσεις πληροφορίες και για το δικό σου τμήμα, επικοινώνησε μαζί μας από την φόρμα επικοινωνίας.", Constants.POPUP_SOURCE);
        }

    }
}
