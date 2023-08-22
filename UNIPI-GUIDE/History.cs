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
using static UNIPI_GUIDE.Constants;

namespace UNIPI_GUIDE
{
    public partial class History : BaseForm
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_TEXT, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@key", TEXT_VALUES[TEXT_KEYS.HISTORY]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    //TODO: voice for accessibility
                    if (reader.Read()) historyTextBox.Text = readMultilineFromDB(reader.GetString(0));
                }
            }
        }
    }
}
