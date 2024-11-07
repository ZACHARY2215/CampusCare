namespace CampusCare.Views
{
    partial class EditDoctor
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
            textBox_email = new TextBox();
            textBox_lastname = new TextBox();
            textBox_firstname = new TextBox();
            buttonCancel = new Button();
            buttonOk = new Button();
            textBox_contact = new TextBox();
            comboBox_status = new ComboBox();
            roleComboBox = new ComboBox();
            SuspendLayout();
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(12, 38);
            textBox_email.Name = "textBox_email";
            textBox_email.PlaceholderText = "Email";
            textBox_email.Size = new Size(419, 23);
            textBox_email.TabIndex = 16;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(224, 9);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.PlaceholderText = "Last name";
            textBox_lastname.Size = new Size(207, 23);
            textBox_lastname.TabIndex = 12;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(12, 9);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.PlaceholderText = "First name";
            textBox_firstname.Size = new Size(206, 23);
            textBox_firstname.TabIndex = 11;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(304, 210);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(127, 54);
            buttonCancel.TabIndex = 20;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(171, 210);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(127, 54);
            buttonOk.TabIndex = 19;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // textBox_contact
            // 
            textBox_contact.Location = new Point(12, 96);
            textBox_contact.Name = "textBox_contact";
            textBox_contact.PlaceholderText = "Contact no.";
            textBox_contact.Size = new Size(206, 23);
            textBox_contact.TabIndex = 21;
            // 
            // comboBox_status
            // 
            comboBox_status.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "available", "unavailable" });
            comboBox_status.Location = new Point(224, 96);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(207, 23);
            comboBox_status.TabIndex = 22;
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "doctor", "nurse" });
            roleComboBox.Location = new Point(12, 67);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(419, 23);
            roleComboBox.TabIndex = 25;
            // 
            // EditDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 290);
            Controls.Add(roleComboBox);
            Controls.Add(comboBox_status);
            Controls.Add(textBox_contact);
            Controls.Add(textBox_email);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOk);
            Name = "EditDoctor";
            Text = "EditDoctor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_email;
        private ComboBox comboBox_gradeordepartment;
        private TextBox textBox_id;
        private TextBox textBox_lastname;
        private TextBox textBox_firstname;
        private Button buttonCancel;
        private Button buttonOk;
        private TextBox textBox_contact;
        private ComboBox comboBox_status;
        private ComboBox roleComboBox;
    }
}