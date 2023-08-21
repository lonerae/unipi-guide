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
    public partial class Home : BaseForm
    {
        private const int MAX_COUNTER = 6;
        private int counter = 2;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gallery.ImageLocation = "./assets/home/gallery1.jpg";
        }

        private void galleryTimer_Tick(object sender, EventArgs e)
        {
            gallery.ImageLocation = "./assets/home/gallery" + counter + ".jpg";
            counter++;
            if (counter > MAX_COUNTER) counter = 1;
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
