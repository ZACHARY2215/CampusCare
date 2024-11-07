namespace CampusCare.Views
{
    partial class AddDoctor
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
            comboBox_status = new ComboBox();
            textBox_contact = new TextBox();
            textBox_email = new TextBox();
            textBox_lastname = new TextBox();
            textBox_firstname = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            roleComboBox = new ComboBox();
            SuspendLayout();
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "available", "unavailable" });
            comboBox_status.Location = new Point(223, 108);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(207, 23);
            comboBox_status.TabIndex = 30;
            // 
            // textBox_contact
            // 
            textBox_contact.Location = new Point(11, 108);
            textBox_contact.Name = "textBox_contact";
            textBox_contact.PlaceholderText = "Contact no.";
            textBox_contact.Size = new Size(206, 23);
            textBox_contact.TabIndex = 29;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(11, 50);
            textBox_email.Name = "textBox_email";
            textBox_email.PlaceholderText = "Email";
            textBox_email.Size = new Size(419, 23);
            textBox_email.TabIndex = 25;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(223, 21);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.PlaceholderText = "Last name";
            textBox_lastname.Size = new Size(207, 23);
            textBox_lastname.TabIndex = 24;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(11, 21);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.PlaceholderText = "First name";
            textBox_firstname.Size = new Size(206, 23);
            textBox_firstname.TabIndex = 23;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(303, 222);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 54);
            buttonCancel.TabIndex = 28;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(170, 222);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(127, 54);
            buttonOk.TabIndex = 27;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "doctor", "nurse" });
            roleComboBox.Location = new Point(12, 79);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(419, 23);
            roleComboBox.TabIndex = 31;
            // 
            // AddDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 297);
            Controls.Add(roleComboBox);
            Controls.Add(comboBox_status);
            Controls.Add(textBox_contact);
            Controls.Add(textBox_email);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "AddDoctor";
            Text = "AddDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_status;
        private TextBox textBox_contact;
        private TextBox textBox_email;
        private TextBox textBox_lastname;
        private TextBox textBox_firstname;
        private Button buttonCancel;
        private Button buttonOk;
        private ComboBox roleComboBox;
    }
}