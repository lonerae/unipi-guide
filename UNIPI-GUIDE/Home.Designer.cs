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
            this.gallery = new System.Windows.Forms.PictureBox();
            this.galleryTimer = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).BeginInit();
            this.SuspendLayout();
            // 
            // gallery
            // 
            this.gallery.Location = new System.Drawing.Point(10, 46);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(1244, 386);
            this.gallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gallery.TabIndex = 1;
            this.gallery.TabStop = false;
            // 
            // galleryTimer
            // 
            this.galleryTimer.Enabled = true;
            this.galleryTimer.Interval = 10000;
            this.galleryTimer.Tick += new System.EventHandler(this.galleryTimer_Tick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button6.Location = new System.Drawing.Point(10, 559);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(617, 107);
            this.button6.TabIndex = 4;
            this.button6.Text = "Τοποθεσία / Πρόσβαση";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button7.Location = new System.Drawing.Point(637, 559);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(617, 107);
            this.button7.TabIndex = 6;
            this.button7.Text = "Παροχές";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button8.Location = new System.Drawing.Point(637, 442);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(617, 107);
            this.button8.TabIndex = 5;
            this.button8.Text = "Χαιρετισμός Πρύτανη";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button5.Location = new System.Drawing.Point(10, 442);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(617, 107);
            this.button5.TabIndex = 7;
            this.button5.Text = "Ιστορία";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.gallery);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIPI GUIDE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gallery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gallery;
        private System.Windows.Forms.Timer galleryTimer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
    }
}

