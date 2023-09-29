namespace UNIPI_GUIDE
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.locationBtn = new System.Windows.Forms.Button();
            this.featureBtn = new System.Windows.Forms.Button();
            this.greetingBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(909, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(291, 213);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Κεντρικό Κτίριο:\nΜ. Καραολή & Α. Δημητρίου 80\n18534, Πειραιάς\n\nΤηλ. Κέντρο: \n210 " +
    "4142000\n\ne-mail:\npubl@unipi.gr";
            // 
            // locationBtn
            // 
            this.locationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.locationBtn.FlatAppearance.BorderSize = 0;
            this.locationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.locationBtn.Location = new System.Drawing.Point(909, 316);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(290, 57);
            this.locationBtn.TabIndex = 6;
            this.locationBtn.Text = "Προβολή στο Google Maps";
            this.locationBtn.UseVisualStyleBackColor = false;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // featureBtn
            // 
            this.featureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.featureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.featureBtn.FlatAppearance.BorderSize = 0;
            this.featureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featureBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.featureBtn.Location = new System.Drawing.Point(731, 542);
            this.featureBtn.Name = "featureBtn";
            this.featureBtn.Size = new System.Drawing.Size(312, 107);
            this.featureBtn.TabIndex = 11;
            this.featureBtn.Text = "Παροχές";
            this.featureBtn.UseVisualStyleBackColor = false;
            this.featureBtn.Click += new System.EventHandler(this.featureBtn_Click);
            // 
            // greetingBtn
            // 
            this.greetingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.greetingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greetingBtn.FlatAppearance.BorderSize = 0;
            this.greetingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greetingBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.greetingBtn.Location = new System.Drawing.Point(380, 542);
            this.greetingBtn.Name = "greetingBtn";
            this.greetingBtn.Size = new System.Drawing.Size(312, 107);
            this.greetingBtn.TabIndex = 10;
            this.greetingBtn.Text = "Χαιρετισμός";
            this.greetingBtn.UseVisualStyleBackColor = false;
            this.greetingBtn.Click += new System.EventHandler(this.greetingButton_Click);
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
            this.historyBtn.Click += new System.EventHandler(this.historyButton_Click);
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
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.featureBtn);
            this.Controls.Add(this.greetingBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.locationBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location";
            this.Text = "Πρόσβαση | UNIPI-GUIDE";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.locationBtn, 0);
            this.Controls.SetChildIndex(this.historyBtn, 0);
            this.Controls.SetChildIndex(this.greetingBtn, 0);
            this.Controls.SetChildIndex(this.featureBtn, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.Button featureBtn;
        private System.Windows.Forms.Button greetingBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button backButton;
    }
}