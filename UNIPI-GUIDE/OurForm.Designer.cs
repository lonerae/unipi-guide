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
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionBox.Image = ((System.Drawing.Image)(resources.GetObject("questionBox.Image")));
            this.questionBox.Location = new System.Drawing.Point(1190, 64);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(62, 50);
            this.questionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionBox.TabIndex = 8;
            this.questionBox.TabStop = false;
            this.questionBox.Click += new System.EventHandler(this.questionBox_Click);
            // 
            // OurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.questionBox);
            this.Name = "OurForm";
            this.Text = "OurForm";
            this.Load += new System.EventHandler(this.OurForm_Load);
            this.Controls.SetChildIndex(this.questionBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox questionBox;
    }
}