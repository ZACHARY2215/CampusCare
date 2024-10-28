namespace CampusCare.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControl1 = new TabControl();
            tp_dashboard = new TabPage();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tp_appointments = new TabPage();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tp_records = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridViewPatient = new DataGridView();
            tp_doctors = new TabPage();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridView3 = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            tabControl1.SuspendLayout();
            tp_dashboard.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tp_appointments.SuspendLayout();
            tp_records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).BeginInit();
            tp_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tp_dashboard);
            tabControl1.Controls.Add(tp_appointments);
            tabControl1.Controls.Add(tp_records);
            tabControl1.Controls.Add(tp_doctors);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(50, 150);
            tabControl1.Location = new Point(0, 48);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 552);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // tp_dashboard
            // 
            tp_dashboard.Controls.Add(label5);
            tp_dashboard.Controls.Add(panel2);
            tp_dashboard.Controls.Add(panel1);
            tp_dashboard.Controls.Add(dataGridView1);
            tp_dashboard.Location = new Point(154, 4);
            tp_dashboard.Margin = new Padding(3, 4, 3, 4);
            tp_dashboard.Name = "tp_dashboard";
            tp_dashboard.Padding = new Padding(3, 4, 3, 4);
            tp_dashboard.Size = new Size(756, 544);
            tp_dashboard.TabIndex = 0;
            tp_dashboard.Text = "Dashboard";
            tp_dashboard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 128);
            label5.Name = "label5";
            label5.Size = new Size(318, 41);
            label5.TabIndex = 2;
            label5.Text = "Recent appointments";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(221, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 101);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 43);
            label2.Name = "label2";
            label2.Size = new Size(173, 41);
            label2.TabIndex = 1;
            label2.Text = "AVAILABLE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 15);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 0;
            label4.Text = "Bed availability";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 101);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 43);
            label3.Name = "label3";
            label3.Size = new Size(35, 41);
            label3.TabIndex = 1;
            label3.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Remaining patients";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 175);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 369);
            dataGridView1.TabIndex = 0;
            // 
            // tp_appointments
            // 
            tp_appointments.Controls.Add(monthCalendar1);
            tp_appointments.Controls.Add(button1);
            tp_appointments.Controls.Add(textBox3);
            tp_appointments.Controls.Add(textBox2);
            tp_appointments.Controls.Add(textBox1);
            tp_appointments.Location = new Point(154, 4);
            tp_appointments.Margin = new Padding(3, 4, 3, 4);
            tp_appointments.Name = "tp_appointments";
            tp_appointments.Padding = new Padding(3, 4, 3, 4);
            tp_appointments.Size = new Size(756, 544);
            tp_appointments.TabIndex = 1;
            tp_appointments.Text = "Add Appointment";
            tp_appointments.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(417, 124);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(75, 367);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(281, 64);
            button1.TabIndex = 3;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(75, 273);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Address";
            textBox3.Size = new Size(281, 34);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(75, 196);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contact number";
            textBox2.Size = new Size(281, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(75, 124);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(281, 34);
            textBox1.TabIndex = 0;
            // 
            // tp_records
            // 
            tp_records.Controls.Add(button5);
            tp_records.Controls.Add(button4);
            tp_records.Controls.Add(button3);
            tp_records.Controls.Add(button2);
            tp_records.Controls.Add(dataGridViewPatient);
            tp_records.Location = new Point(154, 4);
            tp_records.Margin = new Padding(3, 4, 3, 4);
            tp_records.Name = "tp_records";
            tp_records.Padding = new Padding(3, 4, 3, 4);
            tp_records.Size = new Size(756, 544);
            tp_records.TabIndex = 2;
            tp_records.Text = "Patient Records";
            tp_records.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(158, 4);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(46, 53);
            button5.TabIndex = 4;
            button5.Text = "Filter";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(105, 4);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(46, 53);
            button4.TabIndex = 3;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(53, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(46, 53);
            button3.TabIndex = 2;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(0, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(46, 53);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatient
            // 
            dataGridViewPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatient.BackgroundColor = SystemColors.Control;
            dataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatient.Location = new Point(0, 63);
            dataGridViewPatient.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewPatient.Size = new Size(734, 479);
            dataGridViewPatient.TabIndex = 0;
            // 
            // tp_doctors
            // 
            tp_doctors.Controls.Add(button6);
            tp_doctors.Controls.Add(button7);
            tp_doctors.Controls.Add(button8);
            tp_doctors.Controls.Add(button9);
            tp_doctors.Controls.Add(dataGridView3);
            tp_doctors.Location = new Point(154, 4);
            tp_doctors.Margin = new Padding(3, 4, 3, 4);
            tp_doctors.Name = "tp_doctors";
            tp_doctors.Padding = new Padding(3, 4, 3, 4);
            tp_doctors.Size = new Size(756, 544);
            tp_doctors.TabIndex = 3;
            tp_doctors.Text = "Doctors";
            tp_doctors.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(158, 4);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(46, 53);
            button6.TabIndex = 9;
            button6.Text = "Filter";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(105, 4);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(46, 53);
            button7.TabIndex = 8;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(53, 4);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(46, 53);
            button8.TabIndex = 7;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(0, 4);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(46, 53);
            button9.TabIndex = 6;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 63);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(734, 479);
            dataGridView3.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 33);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ActiveLinkColor = Color.Transparent;
            toolStripLabel1.AutoSize = false;
            toolStripLabel1.BackColor = Color.Transparent;
            toolStripLabel1.BackgroundImage = (Image)resources.GetObject("toolStripLabel1.BackgroundImage");
            toolStripLabel1.BackgroundImageLayout = ImageLayout.Zoom;
            toolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(30, 30);
            toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 30);
            toolStripButton1.Text = "File";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(45, 30);
            toolStripButton2.Text = "View";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(45, 30);
            toolStripButton3.Text = "Help";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(57, 30);
            toolStripButton4.Text = "Admin";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(60, 30);
            toolStripButton5.Text = "Logout";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(toolStrip1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Main";
            tabControl1.ResumeLayout(false);
            tp_dashboard.ResumeLayout(false);
            tp_dashboard.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tp_appointments.ResumeLayout(false);
            tp_appointments.PerformLayout();
            tp_records.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).EndInit();
            tp_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tp_dashboard;
        private TabPage tp_appointments;
        private TabPage tp_records;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridViewPatient;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private TabPage tp_doctors;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridView3;
    }
}