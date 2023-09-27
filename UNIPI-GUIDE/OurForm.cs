using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UNIPI_GUIDE
{
    public partial class OurForm : BaseForm
    {
        // TODO: on logout redirect to home
        public OurForm()
        {
            InitializeComponent();
        }

        private void OurForm_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_TEXT, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@key", "cs");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) csTextBox.Text = Utils.readMultilineFromDB(reader.GetString(reader.GetOrdinal("description")));
                }
            }
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_PROFESSOR, connection))
            {
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        professorGrid.Rows.Add(new object[] { reader.GetString(reader.GetOrdinal("name")), reader.GetString(reader.GetOrdinal("email")) });
                    }
                }
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter content = File.CreateText("cs_info.txt"))
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Καθηγητής").Append(" | ").Append("E-mail").Append("\n");
                foreach (DataGridViewRow row in professorGrid.Rows)
                {
                    builder.Append(row.Cells[0].Value).Append(" : ").Append(row.Cells[1].Value).Append("\n");
                }
                content.Write(builder.ToString());
                MessageBox.Show("Επιτυχής εξαγωγή!", Constants.POPUP_SOURCE);
            }
        }
    }
}
