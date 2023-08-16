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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.commentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pageBox = new System.Windows.Forms.RichTextBox();
            this.pageBtn = new System.Windows.Forms.Button();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1031, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1031, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
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
            // pageBox
            // 
            this.pageBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.pageBox.Location = new System.Drawing.Point(735, 483);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(65, 34);
            this.pageBox.TabIndex = 12;
            this.pageBox.Text = "";
            // 
            // pageBtn
            // 
            this.pageBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.pageBtn.Location = new System.Drawing.Point(627, 483);
            this.pageBtn.Name = "pageBtn";
            this.pageBtn.Size = new System.Drawing.Size(102, 34);
            this.pageBtn.TabIndex = 13;
            this.pageBtn.Text = "άλμα στην...";
            this.pageBtn.UseVisualStyleBackColor = true;
            this.pageBtn.Click += new System.EventHandler(this.pageBtn_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pageBtn);
            this.Controls.Add(this.pageBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
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
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.prevButton, 0);
            this.Controls.SetChildIndex(this.nextButton, 0);
            this.Controls.SetChildIndex(this.pageBox, 0);
            this.Controls.SetChildIndex(this.pageBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.RichTextBox eventDescrBox;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel commentsPanel;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RichTextBox pageBox;
        private System.Windows.Forms.Button pageBtn;
    }
}