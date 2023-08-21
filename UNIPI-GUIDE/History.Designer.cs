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
            this.historyTextBox = new System.Windows.Forms.RichTextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
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
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button8.Location = new System.Drawing.Point(33, 542);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(374, 107);
            this.button8.TabIndex = 6;
            this.button8.Text = "Χαιρετισμός Πρύτανη";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 20.25F);
            this.button6.Location = new System.Drawing.Point(444, 542);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(374, 107);
            this.button6.TabIndex = 7;
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
            this.button7.Location = new System.Drawing.Point(854, 542);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(374, 107);
            this.button7.TabIndex = 8;
            this.button7.Text = "Παροχές";
            this.button7.UseVisualStyleBackColor = false;
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
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.historyTextBox);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.Controls.SetChildIndex(this.historyTextBox, 0);
            this.Controls.SetChildIndex(this.button8, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox historyTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label titleLabel;
    }
}