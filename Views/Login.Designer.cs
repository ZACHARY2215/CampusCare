namespace CampusCare
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(122, 148);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(206, 23);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(122, 187);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(206, 23);
            txt_password.TabIndex = 1;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(38, 45);
            label1.Name = "label1";
            label1.Size = new Size(70, 70);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 56);
            label2.Name = "label2";
            label2.Size = new Size(319, 55);
            label2.TabIndex = 3;
            label2.Text = "CampusCare";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(122, 229);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(206, 34);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.IndianRed;
            errorLabel.Location = new Point(138, 121);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(180, 15);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "Incorrect Username or Password!";
            errorLabel.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 305);
            Controls.Add(errorLabel);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private Label errorLabel;
    }
}