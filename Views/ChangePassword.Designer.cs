namespace CampusCare.Views
{
    partial class ChangePassword
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
            btn_ok = new Button();
            textBox_newpass = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(47, 84);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(159, 34);
            btn_ok.TabIndex = 7;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // textBox_newpass
            // 
            textBox_newpass.Location = new Point(47, 55);
            textBox_newpass.Name = "textBox_newpass";
            textBox_newpass.Size = new Size(159, 23);
            textBox_newpass.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 8;
            label1.Text = "Enter new password";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 164);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            Controls.Add(textBox_newpass);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private TextBox textBox_newpass;
        private Label label1;
    }
}