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
            textBox_newpass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_ok = new Button();
            textBox_currpass = new TextBox();
            btn_cancel = new Button();
            label3 = new Label();
            textBox_confirmpass = new TextBox();
            SuspendLayout();
            // 
            // textBox_newpass
            // 
            textBox_newpass.Location = new Point(42, 120);
            textBox_newpass.Margin = new Padding(3, 4, 3, 4);
            textBox_newpass.Name = "textBox_newpass";
            textBox_newpass.Size = new Size(181, 27);
            textBox_newpass.TabIndex = 6;
            textBox_newpass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 96);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 8;
            label1.Text = "Enter new password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 28);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 14;
            label2.Text = "Enter current password";
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(42, 252);
            btn_ok.Margin = new Padding(3, 4, 3, 4);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(182, 45);
            btn_ok.TabIndex = 13;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // textBox_currpass
            // 
            textBox_currpass.Location = new Point(42, 52);
            textBox_currpass.Margin = new Padding(3, 4, 3, 4);
            textBox_currpass.Name = "textBox_currpass";
            textBox_currpass.Size = new Size(181, 27);
            textBox_currpass.TabIndex = 12;
            textBox_currpass.UseSystemPasswordChar = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(42, 305);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(182, 45);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 165);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 17;
            label3.Text = "Confirm new password";
            // 
            // textBox_confirmpass
            // 
            textBox_confirmpass.Location = new Point(42, 189);
            textBox_confirmpass.Margin = new Padding(3, 4, 3, 4);
            textBox_confirmpass.Name = "textBox_confirmpass";
            textBox_confirmpass.Size = new Size(181, 27);
            textBox_confirmpass.TabIndex = 16;
            textBox_confirmpass.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 381);
            Controls.Add(label3);
            Controls.Add(textBox_confirmpass);
            Controls.Add(btn_cancel);
            Controls.Add(label2);
            Controls.Add(textBox_currpass);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            Controls.Add(textBox_newpass);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_newpass;
        private Label label1;
        private Label label2;
        private Button btn_ok;
        private TextBox textBox_currpass;
        private Button btn_cancel;
        private Label label3;
        private TextBox textBox_confirmpass;
    }
}