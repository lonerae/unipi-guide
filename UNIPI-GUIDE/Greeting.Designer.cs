namespace UNIPI_GUIDE
{
    partial class Greeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Greeting));
            this.greetingTextBox = new System.Windows.Forms.RichTextBox();
            this.featuresButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.speakerBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speakerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingTextBox
            // 
            this.greetingTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.greetingTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greetingTextBox.Location = new System.Drawing.Point(33, 153);
            this.greetingTextBox.Name = "greetingTextBox";
            this.greetingTextBox.ReadOnly = true;
            this.greetingTextBox.Size = new System.Drawing.Size(1195, 356);
            this.greetingTextBox.TabIndex = 4;
            this.greetingTextBox.Text = "";
            // 
            // featuresButton
            // 
            this.featuresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.featuresButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featuresButton.FlatAppearance.BorderSize = 0;
            this.featuresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featuresButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.featuresButton.Location = new System.Drawing.Point(740, 542);
            this.featuresButton.Name = "featuresButton";
            this.featuresButton.Size = new System.Drawing.Size(312, 107);
            this.featuresButton.TabIndex = 11;
            this.featuresButton.Text = "Παροχές";
            this.featuresButton.UseVisualStyleBackColor = false;
            this.featuresButton.Click += new System.EventHandler(this.featuresButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.locationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationButton.FlatAppearance.BorderSize = 0;
            this.locationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.locationButton.Location = new System.Drawing.Point(387, 542);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(312, 107);
            this.locationButton.TabIndex = 10;
            this.locationButton.Text = "Τοποθεσία / Πρόσβαση";
            this.locationButton.UseVisualStyleBackColor = false;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.historyBtn.Location = new System.Drawing.Point(33, 542);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(312, 107);
            this.historyBtn.TabIndex = 9;
            this.historyBtn.Text = "Ιστορία";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.titleLabel.Location = new System.Drawing.Point(355, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(510, 55);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Χαιρετισμός Πρύτανη";
            // 
            // speakerBox
            // 
            this.speakerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speakerBox.Image = ((System.Drawing.Image)(resources.GetObject("speakerBox.Image")));
            this.speakerBox.Location = new System.Drawing.Point(1178, 74);
            this.speakerBox.Name = "speakerBox";
            this.speakerBox.Size = new System.Drawing.Size(50, 50);
            this.speakerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.speakerBox.TabIndex = 13;
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
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.speakerBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.featuresButton);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.greetingTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Greeting";
            this.Text = "Χαιρετισμός | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.Greeting_Load);
            this.Controls.SetChildIndex(this.greetingTextBox, 0);
            this.Controls.SetChildIndex(this.historyBtn, 0);
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

        private System.Windows.Forms.RichTextBox greetingTextBox;
        private System.Windows.Forms.Button featuresButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox speakerBox;
        private System.Windows.Forms.Button backButton;
    }
}