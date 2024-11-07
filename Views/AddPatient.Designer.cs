namespace CampusCare.Views
{
    partial class AddPatient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.ComboBox comboBox_studentorstaff;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ComboBox comboBox_gradeordepartment;

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.comboBox_studentorstaff = new System.Windows.Forms.ComboBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.comboBox_gradeordepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(304, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 54);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(171, 213);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(127, 54);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(12, 12);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.PlaceholderText = "First name";
            this.textBox_firstname.Size = new System.Drawing.Size(206, 23);
            this.textBox_firstname.TabIndex = 5;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(224, 12);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.PlaceholderText = "Last name";
            this.textBox_lastname.Size = new System.Drawing.Size(207, 23);
            this.textBox_lastname.TabIndex = 6;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(12, 70);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.PlaceholderText = "Gender";
            this.textBox_gender.Size = new System.Drawing.Size(206, 23);
            this.textBox_gender.TabIndex = 7;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(12, 41);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(419, 23);
            this.dateTimePicker_birthday.TabIndex = 8;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(12, 128);
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.PlaceholderText = "Contact no.";
            this.textBox_contact.Size = new System.Drawing.Size(419, 23);
            this.textBox_contact.TabIndex = 9;
            // 
            // comboBox_studentorstaff
            // 
            this.comboBox_studentorstaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_studentorstaff.FormattingEnabled = true;
            this.comboBox_studentorstaff.Location = new System.Drawing.Point(224, 70);
            this.comboBox_studentorstaff.Name = "comboBox_studentorstaff";
            this.comboBox_studentorstaff.Size = new System.Drawing.Size(207, 23);
            this.comboBox_studentorstaff.TabIndex = 10;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(12, 99);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.PlaceholderText = "ID";
            this.textBox_id.Size = new System.Drawing.Size(206, 23);
            this.textBox_id.TabIndex = 11;
            // 
            // comboBox_gradeordepartment
            // 
            this.comboBox_gradeordepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gradeordepartment.FormattingEnabled = true;
            this.comboBox_gradeordepartment.Location = new System.Drawing.Point(224, 99);
            this.comboBox_gradeordepartment.Name = "comboBox_gradeordepartment";
            this.comboBox_gradeordepartment.Size = new System.Drawing.Size(207, 23);
            this.comboBox_gradeordepartment.TabIndex = 12;
            // 
            // AddPatient
            // 
            this.ClientSize = new System.Drawing.Size(443, 279);
            this.Controls.Add(this.comboBox_gradeordepartment);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.comboBox_studentorstaff);
            this.Controls.Add(this.textBox_contact);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "AddPatient";
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
