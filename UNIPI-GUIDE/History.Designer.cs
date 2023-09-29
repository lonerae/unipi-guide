namespace UNIPI_GUIDE
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.greetingButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.featuresButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.speakerBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speakerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTextBox
            // 
            this.historyTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.historyTextBox.Location = new System.Drawing.Point(33, 153);
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ReadOnly = true;
            this.historyTextBox.Size = new System.Drawing.Size(1195, 356);
            this.historyTextBox.TabIndex = 4;
            this.historyTextBox.Text = "";
            // 
            // greetingButton
            // 
            this.greetingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.greetingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greetingButton.FlatAppearance.BorderSize = 0;
            this.greetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greetingButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.greetingButton.Location = new System.Drawing.Point(33, 542);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(312, 107);
            this.greetingButton.TabIndex = 6;
            this.greetingButton.Text = "Χαιρετισμός Πρύτανη";
            this.greetingButton.UseVisualStyleBackColor = false;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.locationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationButton.FlatAppearance.BorderSize = 0;
            this.locationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.locationButton.Location = new System.Drawing.Point(384, 542);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(312, 107);
            this.locationButton.TabIndex = 7;
            this.locationButton.Text = "Τοποθεσία / Πρόσβαση";
            this.locationButton.UseVisualStyleBackColor = false;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // featuresButton
            // 
            this.featuresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.featuresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuresButton.FlatAppearance.BorderSize = 0;
            this.featuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featuresButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.featuresButton.Location = new System.Drawing.Point(732, 542);
            this.featuresButton.Name = "featuresButton";
            this.featuresButton.Size = new System.Drawing.Size(312, 107);
            this.featuresButton.TabIndex = 8;
            this.featuresButton.Text = "Παροχές";
            this.featuresButton.UseVisualStyleBackColor = false;
            this.featuresButton.Click += new System.EventHandler(this.featuresButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(355, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(524, 55);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Ιστορία του Ιδρύματος";
            // 
            // speakerBox
            // 
            this.speakerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speakerBox.Image = ((System.Drawing.Image)(resources.GetObject("speakerBox.Image")));
            this.speakerBox.Location = new System.Drawing.Point(1178, 74);
            this.speakerBox.Name = "speakerBox";
            this.speakerBox.Size = new System.Drawing.Size(50, 50);
            this.speakerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speakerBox.TabIndex = 10;
            this.speakerBox.TabStop = false;
            this.speakerBox.Click += new System.EventHandler(this.speakerBox_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backButton.Location = new System.Drawing.Point(1078, 609);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 40);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Επιστροφή";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.speakerBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.featuresButton);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.greetingButton);
            this.Controls.Add(this.historyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "Ιστορία | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.History_Load);
            this.Controls.SetChildIndex(this.historyTextBox, 0);
            this.Controls.SetChildIndex(this.greetingButton, 0);
            this.Controls.SetChildIndex(this.locationButton, 0);
            this.Controls.SetChildIndex(this.featuresButton, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.speakerBox, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.speakerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox historyTextBox;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button featuresButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox speakerBox;
        private System.Windows.Forms.Button backButton;
    }
}