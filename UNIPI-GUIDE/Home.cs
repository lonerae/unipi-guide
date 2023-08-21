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
    public partial class Home : BaseForm
    {
        private int counter = 0;
        private int maxCounter;

        private List<string> imagePaths = new List<string>();

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_CAROUSEL_IMAGES, connection))
            {
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        imagePaths.Add(reader.GetString(0));

                    }
                }
            }
            maxCounter = imagePaths.Count() - 1;
            gallery.ImageLocation = imagePaths[counter];
        }

        private void galleryTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > maxCounter) counter = 0;
            gallery.ImageLocation = imagePaths[counter];
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            changeForm(new History());
        }

        private void greetingBtn_Click(object sender, EventArgs e)
        {
            changeForm(new Greeting());
        }
    }
}
