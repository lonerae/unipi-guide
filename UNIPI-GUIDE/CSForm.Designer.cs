namespace UNIPI_GUIDE
{
    partial class CSForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSForm));
            this.csTextBox = new System.Windows.Forms.RichTextBox();
            this.professorGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunetLink = new System.Windows.Forms.LinkLabel();
            this.ieeeLink = new System.Windows.Forms.LinkLabel();
            this.dptLink = new System.Windows.Forms.LinkLabel();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.professorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // csTextBox
            // 
            this.csTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.csTextBox.Location = new System.Drawing.Point(50, 136);
            this.csTextBox.Name = "csTextBox";
            this.csTextBox.ReadOnly = true;
            this.csTextBox.Size = new System.Drawing.Size(400, 421);
            this.csTextBox.TabIndex = 4;
            this.csTextBox.Text = "";
            // 
            // professorGrid
            // 
            this.professorGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.professorGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.professorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.professorGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.professorGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.professorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.professorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.professorGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.professorGrid.Location = new System.Drawing.Point(493, 181);
            this.professorGrid.Name = "professorGrid";
            this.professorGrid.RowHeadersVisible = false;
            this.professorGrid.Size = new System.Drawing.Size(440, 326);
            this.professorGrid.TabIndex = 5;
            // 
            // name
            // 
            this.name.HeaderText = "Όνομα Καθηγητή";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(89)))));
            this.exportButton.FlatAppearance.BorderSize = 0;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportButton.Location = new System.Drawing.Point(492, 524);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(441, 33);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Εξαγωγή σε αρχείο txt";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Τμήμα Πληροφορικής";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(488, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Μέλη ΔΕΠ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(990, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Χρήσιμοι Σύνδεσμοι";
            // 
            // gunetLink
            // 
            this.gunetLink.AutoSize = true;
            this.gunetLink.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gunetLink.Location = new System.Drawing.Point(990, 181);
            this.gunetLink.Name = "gunetLink";
            this.gunetLink.Size = new System.Drawing.Size(158, 22);
            this.gunetLink.TabIndex = 10;
            this.gunetLink.TabStop = true;
            this.gunetLink.Text = "Ηλεκτρονική Τάξη";
            this.gunetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunetLink_LinkClicked);
            // 
            // ieeeLink
            // 
            this.ieeeLink.AutoSize = true;
            this.ieeeLink.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ieeeLink.Location = new System.Drawing.Point(990, 277);
            this.ieeeLink.Name = "ieeeLink";
            this.ieeeLink.Size = new System.Drawing.Size(55, 22);
            this.ieeeLink.TabIndex = 15;
            this.ieeeLink.TabStop = true;
            this.ieeeLink.Text = "IEEE";
            this.ieeeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ieeeLink_LinkClicked);
            // 
            // dptLink
            // 
            this.dptLink.AutoSize = true;
            this.dptLink.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dptLink.Location = new System.Drawing.Point(990, 231);
            this.dptLink.Name = "dptLink";
            this.dptLink.Size = new System.Drawing.Size(152, 22);
            this.dptLink.TabIndex = 16;
            this.dptLink.TabStop = true;
            this.dptLink.Text = "Σελίδα Τμήματος";
            this.dptLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dptLink_LinkClicked);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(217)))), ((int)(((byte)(89)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backButton.Location = new System.Drawing.Point(1079, 617);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 40);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Επιστροφή";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dptLink);
            this.Controls.Add(this.ieeeLink);
            this.Controls.Add(this.gunetLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.professorGrid);
            this.Controls.Add(this.csTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSForm";
            this.Text = "Τμήμα Πληροφορικής | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.OurForm_Load);
            this.Controls.SetChildIndex(this.csTextBox, 0);
            this.Controls.SetChildIndex(this.professorGrid, 0);
            this.Controls.SetChildIndex(this.exportButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.gunetLink, 0);
            this.Controls.SetChildIndex(this.ieeeLink, 0);
            this.Controls.SetChildIndex(this.dptLink, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.professorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox csTextBox;
        private System.Windows.Forms.DataGridView professorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel gunetLink;
        private System.Windows.Forms.LinkLabel ieeeLink;
        private System.Windows.Forms.LinkLabel dptLink;
        private System.Windows.Forms.Button backButton;
    }
}