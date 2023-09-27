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
            this.csTextBox = new System.Windows.Forms.RichTextBox();
            this.professorGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.professorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // csTextBox
            // 
            this.csTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.csTextBox.Location = new System.Drawing.Point(726, 66);
            this.csTextBox.Name = "csTextBox";
            this.csTextBox.ReadOnly = true;
            this.csTextBox.Size = new System.Drawing.Size(511, 592);
            this.csTextBox.TabIndex = 4;
            this.csTextBox.Text = "";
            // 
            // professorGrid
            // 
            this.professorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.email});
            this.professorGrid.Location = new System.Drawing.Point(398, 66);
            this.professorGrid.Name = "professorGrid";
            this.professorGrid.Size = new System.Drawing.Size(322, 150);
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
            // OurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.professorGrid);
            this.Controls.Add(this.csTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OurForm";
            this.Text = "Το ΠΑΠΕΙ μας | UNIPI-GUIDE";
            this.Load += new System.EventHandler(this.OurForm_Load);
            this.Controls.SetChildIndex(this.csTextBox, 0);
            this.Controls.SetChildIndex(this.professorGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.professorGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox csTextBox;
        private System.Windows.Forms.DataGridView professorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}