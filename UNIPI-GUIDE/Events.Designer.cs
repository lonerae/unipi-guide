namespace UNIPI_GUIDE
{
    partial class Events
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.eventDescrBox = new System.Windows.Forms.RichTextBox();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.commentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pageBtn = new System.Windows.Forms.Button();
            this.pageDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(18, 53);
            this.calendar.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // eventDescrBox
            // 
            this.eventDescrBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eventDescrBox.Location = new System.Drawing.Point(257, 53);
            this.eventDescrBox.Name = "eventDescrBox";
            this.eventDescrBox.ReadOnly = true;
            this.eventDescrBox.Size = new System.Drawing.Size(995, 162);
            this.eventDescrBox.TabIndex = 4;
            this.eventDescrBox.Text = "";
            // 
            // commentBox
            // 
            this.commentBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentBox.Location = new System.Drawing.Point(18, 540);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(995, 70);
            this.commentBox.TabIndex = 6;
            this.commentBox.Text = "";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(1031, 578);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(221, 34);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Εκκαθάριση";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.uploadBtn.Location = new System.Drawing.Point(1031, 538);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(221, 34);
            this.uploadBtn.TabIndex = 8;
            this.uploadBtn.Text = "Ανάρτηση";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // commentsPanel
            // 
            this.commentsPanel.Location = new System.Drawing.Point(18, 227);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(1234, 236);
            this.commentsPanel.TabIndex = 9;
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevButton.Location = new System.Drawing.Point(481, 483);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(49, 34);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.nextButton.Location = new System.Drawing.Point(536, 483);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(49, 34);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pageBtn
            // 
            this.pageBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.pageBtn.Location = new System.Drawing.Point(1031, 491);
            this.pageBtn.Name = "pageBtn";
            this.pageBtn.Size = new System.Drawing.Size(102, 21);
            this.pageBtn.TabIndex = 13;
            this.pageBtn.Text = "άλμα στην...";
            this.pageBtn.UseVisualStyleBackColor = true;
            this.pageBtn.Click += new System.EventHandler(this.pageBtn_Click);
            // 
            // pageDropdown
            // 
            this.pageDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageDropdown.FormattingEnabled = true;
            this.pageDropdown.Location = new System.Drawing.Point(1139, 491);
            this.pageDropdown.MaxDropDownItems = 5;
            this.pageDropdown.Name = "pageDropdown";
            this.pageDropdown.Size = new System.Drawing.Size(113, 21);
            this.pageDropdown.TabIndex = 15;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pageDropdown);
            this.Controls.Add(this.pageBtn);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.eventDescrBox);
            this.Controls.Add(this.commentsPanel);
            this.Controls.Add(this.calendar);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Controls.SetChildIndex(this.calendar, 0);
            this.Controls.SetChildIndex(this.commentsPanel, 0);
            this.Controls.SetChildIndex(this.eventDescrBox, 0);
            this.Controls.SetChildIndex(this.commentBox, 0);
            this.Controls.SetChildIndex(this.clearBtn, 0);
            this.Controls.SetChildIndex(this.uploadBtn, 0);
            this.Controls.SetChildIndex(this.prevButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.pageBtn, 0);
            this.Controls.SetChildIndex(this.pageDropdown, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.RichTextBox eventDescrBox;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.FlowLayoutPanel commentsPanel;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button pageBtn;
        private System.Windows.Forms.ComboBox pageDropdown;
    }
}