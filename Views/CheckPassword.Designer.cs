namespace CampusCare.Views
{
    partial class CheckPassword
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
            label1 = new Label();
            btn_ok = new Button();
            textBox_currpass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 11;
            label1.Text = "Enter current password";
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(53, 89);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(159, 34);
            btn_ok.TabIndex = 10;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click_1;
            // 
            // textBox_currpass
            // 
            textBox_currpass.Location = new Point(53, 60);
            textBox_currpass.Name = "textBox_currpass";
            textBox_currpass.Size = new Size(159, 23);
            textBox_currpass.TabIndex = 9;
            // 
            // CheckPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 164);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            Controls.Add(textBox_currpass);
            Name = "CheckPassword";
            Text = "PasswordCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_ok;
        private TextBox textBox_currpass;
    }
}