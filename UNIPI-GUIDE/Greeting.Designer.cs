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
            this.greetingTextBox = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetingTextBox
            // 
            this.greetingTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.greetingTextBox.Location = new System.Drawing.Point(33, 153);
            this.greetingTextBox.Name = "greetingTextBox";
            this.greetingTextBox.ReadOnly = true;
            this.greetingTextBox.Size = new System.Drawing.Size(1195, 356);
            this.greetingTextBox.TabIndex = 4;
            this.greetingTextBox.Text = "";
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
            this.button7.TabIndex = 11;
            this.button7.Text = "Παροχές";
            this.button7.UseVisualStyleBackColor = false;
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
            this.button6.TabIndex = 10;
            this.button6.Text = "Τοποθεσία / Πρόσβαση";
            this.button6.UseVisualStyleBackColor = false;
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
            this.historyBtn.Size = new System.Drawing.Size(374, 107);
            this.historyBtn.TabIndex = 9;
            this.historyBtn.Text = "Ιστορία";
            this.historyBtn.UseVisualStyleBackColor = false;
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
            // Greeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.greetingTextBox);
            this.Name = "Greeting";
            this.Text = "Greeting";
            this.Load += new System.EventHandler(this.Greeting_Load);
            this.Controls.SetChildIndex(this.greetingTextBox, 0);
            this.Controls.SetChildIndex(this.historyBtn, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox greetingTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Label titleLabel;
    }
}