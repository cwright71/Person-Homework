namespace Person_Homework
{
    partial class InfoForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.emailBox = new System.Windows.Forms.ComboBox();
            this.phoneBox = new System.Windows.Forms.ComboBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(9, 116);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(36, 13);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Text = "Note: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 35);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Addresses: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 62);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(90, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email Addresses: ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(9, 89);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(89, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone Numbers: ";
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(105, 32);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(412, 21);
            this.addressBox.TabIndex = 7;
            // 
            // emailBox
            // 
            this.emailBox.FormattingEnabled = true;
            this.emailBox.Location = new System.Drawing.Point(105, 59);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(412, 21);
            this.emailBox.TabIndex = 8;
            // 
            // phoneBox
            // 
            this.phoneBox.FormattingEnabled = true;
            this.phoneBox.Location = new System.Drawing.Point(105, 86);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(412, 21);
            this.phoneBox.TabIndex = 9;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(105, 113);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(412, 94);
            this.noteBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(105, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(412, 20);
            this.nameBox.TabIndex = 11;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 222);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "InfoForm";
            this.Text = "Contact Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ComboBox addressBox;
        private System.Windows.Forms.ComboBox emailBox;
        private System.Windows.Forms.ComboBox phoneBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}