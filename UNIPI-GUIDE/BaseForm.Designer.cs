namespace UNIPI_GUIDE
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navPanel = new System.Windows.Forms.Panel();
            this.papeiButton = new System.Windows.Forms.Button();
            this.eventsButton = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.generalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Arial", 18F);
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(12, 31);
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("navigateToolStripMenuItem.Image")));
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(28, 31);
            this.navigateToolStripMenuItem.Click += new System.EventHandler(this.navigateToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(154, 31);
            this.contactToolStripMenuItem.Text = "Επικοινωνία";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(91, 31);
            this.generalToolStripMenuItem.Text = "Γενικά";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15F);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.aboutToolStripMenuItem.Text = "Σχετικά...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 15F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.exitToolStripMenuItem.Text = "Έξοδος";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.navPanel.Controls.Add(this.eventsButton);
            this.navPanel.Controls.Add(this.homeBtn);
            this.navPanel.Location = new System.Drawing.Point(0, 43);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(200, 140);
            this.navPanel.TabIndex = 3;
            this.navPanel.Visible = false;
            // 
            // papeiButton
            // 
            this.papeiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(89)))));
            this.papeiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.papeiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.papeiButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.papeiButton.Location = new System.Drawing.Point(0, 179);
            this.papeiButton.Name = "papeiButton";
            this.papeiButton.Size = new System.Drawing.Size(200, 71);
            this.papeiButton.TabIndex = 3;
            this.papeiButton.Tag = "premium";
            this.papeiButton.Text = "Το ΠΑΠΕΙ μας";
            this.papeiButton.UseVisualStyleBackColor = false;
            this.papeiButton.Visible = false;
            this.papeiButton.Click += new System.EventHandler(this.papeiButton_Click);
            // 
            // eventsButton
            // 
            this.eventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(89)))));
            this.eventsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsButton.Font = new System.Drawing.Font("Arial", 20.25F);
            this.eventsButton.Location = new System.Drawing.Point(0, 68);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(200, 71);
            this.eventsButton.TabIndex = 2;
            this.eventsButton.Text = "Εκδηλώσεις";
            this.eventsButton.UseVisualStyleBackColor = false;
            this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(89)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(200, 71);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Αρχική";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.papeiButton);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button eventsButton;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button papeiButton;
    }
}