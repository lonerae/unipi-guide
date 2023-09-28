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
            galleryTwo.ImageLocation = imagePaths[counter+1];
        }

        private void galleryTimer_Tick(object sender, EventArgs e)
        {
            if(gallery.Location.X < rightPanel.Location.X)
            {
                gallery.Location = new Point(gallery.Location.X + 12, gallery.Location.Y);
            }
            else
            {
                counter++;
                gallery.Image = Image.FromFile(imagePaths[counter%maxCounter + 1]);
                gallery.Location = new Point(93, gallery.Location.Y);
                gallery.SendToBack();
                galleryTimer.Enabled = false;
            }
            if (galleryTwo.Location.X < rightPanel.Location.X)
            {
                galleryTwo.Location = new Point(galleryTwo.Location.X + 12, galleryTwo.Location.Y);
            }
            else
            {
                counter++;
                galleryTwo.Image = Image.FromFile(imagePaths[counter%maxCounter + 1]);
                galleryTwo.Location = new Point(93, galleryTwo.Location.Y);
                galleryTwo.SendToBack();
                galleryTimer.Enabled = false;
            }

        }
        private void photoTimer_Tick(object sender, EventArgs e)
        {
            galleryTimer.Enabled = true;
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

        private void featureBtn_Click(object sender, EventArgs e)
        {
            changeForm(new Features(), false);
        }
    }
}
