namespace Person_Homework
{
    partial class MyForm
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
            this.ContactsListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ContactsListView
            // 
            this.ContactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.PhoneHeader,
            this.CityHeader,
            this.EmailHeader});
            this.ContactsListView.FullRowSelect = true;
            this.ContactsListView.Location = new System.Drawing.Point(12, 46);
            this.ContactsListView.Name = "ContactsListView";
            this.ContactsListView.Size = new System.Drawing.Size(660, 495);
            this.ContactsListView.TabIndex = 2;
            this.ContactsListView.UseCompatibleStateImageBehavior = false;
            this.ContactsListView.View = System.Windows.Forms.View.Details;
            this.ContactsListView.SelectedIndexChanged += new System.EventHandler(this.ContactsListView_SelectedIndexChanged);
            this.ContactsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContactsListView_MouseDoubleClick);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 175;
            // 
            // PhoneHeader
            // 
            this.PhoneHeader.Text = "Phone";
            this.PhoneHeader.Width = 117;
            // 
            // CityHeader
            // 
            this.CityHeader.Text = "City";
            this.CityHeader.Width = 170;
            // 
            // EmailHeader
            // 
            this.EmailHeader.Text = "Email";
            this.EmailHeader.Width = 192;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(12, 12);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(660, 20);
            this.statusBox.TabIndex = 3;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 553);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.ContactsListView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ContactsListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader PhoneHeader;
        private System.Windows.Forms.ColumnHeader CityHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader;
        private System.Windows.Forms.TextBox statusBox;
    }
}