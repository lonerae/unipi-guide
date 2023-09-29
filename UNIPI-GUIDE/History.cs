using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UNIPI_GUIDE.Constants;

namespace UNIPI_GUIDE
{
    public partial class History : BaseForm
    {
        SpeechSynthesizer engine = new SpeechSynthesizer();
        private static bool speaker = false;

        public History()
        {
            InitializeComponent();
            engine.SelectVoice("Microsoft Stefanos");
        }

        private void History_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(Constants.CONNECTION_STRING))
            using (SQLiteCommand command = new SQLiteCommand(Constants.RETURN_TEXT, connection)) {
                connection.Open();
                command.Parameters.AddWithValue("@key", TEXT_VALUES[TEXT_KEYS.HISTORY]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) historyTextBox.Text = Utils.readMultilineFromDB(reader.GetString(0));
                }
            }
        }

        private void speakerBox_Click(object sender, EventArgs e)
        {
            if (!speaker)
            {
                engine.SpeakAsync(historyTextBox.Text);
                speakerBox.ImageLocation = "./assets/icons/speaker_off.png";
                speaker = true;
            }
            else
            {                
                engine.SpeakAsyncCancelAll();
                speakerBox.ImageLocation = "./assets/icons/speaker.png";
                speaker = false;
            }
        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            changeForm(new Greeting(), false);
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            changeForm(new Location(), false);
        }

        private void featuresButton_Click(object sender, EventArgs e)
        {
            changeForm(new Features(), false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            changeForm(new Home(), false);
        }
    }
}
