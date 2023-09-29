namespace UNIPI_GUIDE
{
    partial class OurForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OurForm));
            this.questionBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionBox.Image = ((System.Drawing.Image)(resources.GetObject("questionBox.Image")));
            this.questionBox.Location = new System.Drawing.Point(1167, 64);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(62, 50);
            this.questionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionBox.TabIndex = 8;
            this.questionBox.TabStop = false;
            this.questionBox.Click += new System.EventHandler(this.questionBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(50, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Διάλεξε ένα Τμήμα για να δεις περισσότερες λεπτομέρειες!";
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(783, 133);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(446, 474);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 10;
            this.iconPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backButton.Location = new System.Drawing.Point(1079, 624);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 40);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Επιστροφή";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OurForm";
            this.Text = "Το ΠΑΠΕΙ μας | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.OurForm_Load);
            this.Controls.SetChildIndex(this.questionBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.iconPictureBox, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox questionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button backButton;
    }
}