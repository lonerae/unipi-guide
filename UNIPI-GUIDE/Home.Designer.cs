namespace UNIPI_GUIDE
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gallery = new System.Windows.Forms.PictureBox();
            this.galleryTimer = new System.Windows.Forms.Timer(this.components);
            this.locationBtn = new System.Windows.Forms.Button();
            this.featureBtn = new System.Windows.Forms.Button();
            this.greetingBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.photoTimer = new System.Windows.Forms.Timer(this.components);
            this.galleryTwo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // gallery
            // 
            this.gallery.Location = new System.Drawing.Point(756, 244);
            this.gallery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(400, 250);
            this.gallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gallery.TabIndex = 1;
            this.gallery.TabStop = false;
            // 
            // galleryTimer
            // 
            this.galleryTimer.Enabled = true;
            this.galleryTimer.Interval = 75;
            this.galleryTimer.Tick += new System.EventHandler(this.galleryTimer_Tick);
            // 
            // locationBtn
            // 
            this.locationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.locationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBtn.FlatAppearance.BorderSize = 0;
            this.locationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.locationBtn.Location = new System.Drawing.Point(15, 860);
            this.locationBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(926, 165);
            this.locationBtn.TabIndex = 4;
            this.locationBtn.Text = "Τοποθεσία / Πρόσβαση";
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
            this.featureBtn.Location = new System.Drawing.Point(956, 860);
            this.featureBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.featureBtn.Name = "featureBtn";
            this.featureBtn.Size = new System.Drawing.Size(926, 165);
            this.featureBtn.TabIndex = 6;
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
            this.greetingBtn.Location = new System.Drawing.Point(956, 680);
            this.greetingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greetingBtn.Name = "greetingBtn";
            this.greetingBtn.Size = new System.Drawing.Size(926, 165);
            this.greetingBtn.TabIndex = 5;
            this.greetingBtn.Text = "Χαιρετισμός Πρύτανη";
            this.greetingBtn.UseVisualStyleBackColor = false;
            this.greetingBtn.Click += new System.EventHandler(this.greetingBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.historyBtn.Location = new System.Drawing.Point(15, 680);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(926, 165);
            this.historyBtn.TabIndex = 7;
            this.historyBtn.Text = "Ιστορία";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Location = new System.Drawing.Point(308, 144);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(459, 424);
            this.leftPanel.TabIndex = 8;
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(1163, 144);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(684, 424);
            this.rightPanel.TabIndex = 9;
            // 
            // photoTimer
            // 
            this.photoTimer.Enabled = true;
            this.photoTimer.Interval = 5000;
            this.photoTimer.Tick += new System.EventHandler(this.photoTimer_Tick);
            // 
            // galleryTwo
            // 
            this.galleryTwo.Location = new System.Drawing.Point(348, 244);
            this.galleryTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galleryTwo.Name = "galleryTwo";
            this.galleryTwo.Size = new System.Drawing.Size(400, 250);
            this.galleryTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.galleryTwo.TabIndex = 10;
            this.galleryTwo.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.locationBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.featureBtn);
            this.Controls.Add(this.greetingBtn);
            this.Controls.Add(this.galleryTwo);
            this.Controls.Add(this.gallery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Home";
            this.Text = "Αρχική | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.gallery, 0);
            this.Controls.SetChildIndex(this.galleryTwo, 0);
            this.Controls.SetChildIndex(this.greetingBtn, 0);
            this.Controls.SetChildIndex(this.featureBtn, 0);
            this.Controls.SetChildIndex(this.historyBtn, 0);
            this.Controls.SetChildIndex(this.locationBtn, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.rightPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gallery;
        private System.Windows.Forms.Timer galleryTimer;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.Button featureBtn;
        private System.Windows.Forms.Button greetingBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Timer photoTimer;
        private System.Windows.Forms.PictureBox galleryTwo;
    }
}

