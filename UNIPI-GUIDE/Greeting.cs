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
    public partial class Greeting : BaseForm
    {
        public Greeting()
        {
            InitializeComponent();
        }

        private void Greeting_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_TEXT, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@key", TEXT_VALUES[TEXT_KEYS.GREETING]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) greetingTextBox.Text = readMultilineFromDB(reader.GetString(0));
                }
            }
        }
    }

   
}
