namespace UNIPI_GUIDE
{
    partial class Features
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
            this.descrBox = new System.Windows.Forms.RichTextBox();
            this.locationBtn = new System.Windows.Forms.Button();
            this.greetingBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.featureTree = new System.Windows.Forms.TreeView();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descrBox
            // 
            this.descrBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descrBox.Location = new System.Drawing.Point(444, 67);
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(784, 445);
            this.descrBox.TabIndex = 4;
            this.descrBox.Text = "";
            // 
            // locationBtn
            // 
            this.locationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.locationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBtn.FlatAppearance.BorderSize = 0;
            this.locationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.locationBtn.Location = new System.Drawing.Point(730, 542);
            this.locationBtn.Name = "locationBtn";
            this.locationBtn.Size = new System.Drawing.Size(312, 107);
            this.locationBtn.TabIndex = 14;
            this.locationBtn.Text = "Τοποθεσία/Πρόσβαση";
            this.locationBtn.UseVisualStyleBackColor = false;
            this.locationBtn.Click += new System.EventHandler(this.locationBtn_Click);
            // 
            // greetingBtn
            // 
            this.greetingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.greetingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greetingBtn.FlatAppearance.BorderSize = 0;
            this.greetingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greetingBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.greetingBtn.Location = new System.Drawing.Point(382, 542);
            this.greetingBtn.Name = "greetingBtn";
            this.greetingBtn.Size = new System.Drawing.Size(312, 107);
            this.greetingBtn.TabIndex = 13;
            this.greetingBtn.Text = "Χαιρετισμός";
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
            this.historyBtn.Location = new System.Drawing.Point(33, 542);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(312, 107);
            this.historyBtn.TabIndex = 12;
            this.historyBtn.Text = "Ιστορία";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // featureTree
            // 
            this.featureTree.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.featureTree.Location = new System.Drawing.Point(33, 67);
            this.featureTree.Name = "featureTree";
            this.featureTree.Size = new System.Drawing.Size(374, 445);
            this.featureTree.TabIndex = 15;
            this.featureTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.featureTree_AfterSelect);
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
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Επιστροφή";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.featureTree);
            this.Controls.Add(this.locationBtn);
            this.Controls.Add(this.greetingBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.descrBox);
            this.Name = "Features";
            this.Text = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.Controls.SetChildIndex(this.descrBox, 0);
            this.Controls.SetChildIndex(this.historyBtn, 0);
            this.Controls.SetChildIndex(this.greetingBtn, 0);
            this.Controls.SetChildIndex(this.locationBtn, 0);
            this.Controls.SetChildIndex(this.featureTree, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox descrBox;
        private System.Windows.Forms.Button locationBtn;
        private System.Windows.Forms.Button greetingBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.TreeView featureTree;
        private System.Windows.Forms.Button backButton;
    }
}