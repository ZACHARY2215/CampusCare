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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            tp_doctors = new TabPage();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridViewDoctor = new DataGridView();
            tp_records = new TabPage();
            buttonFilterPatient = new Button();
            buttonRemovePatient = new Button();
            buttonEditPatient = new Button();
            buttonAddPatient = new Button();
            dataGridViewPatient = new DataGridView();
            tp_dashboard = new TabPage();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            dataGridViewRecentPatients = new DataGridView();
            tabControl1 = new TabControl();
            toolStrip1.SuspendLayout();
            tp_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).BeginInit();
            tp_records.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).BeginInit();
            tp_dashboard.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentPatients).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 33);
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
            toolStripButton1.Size = new Size(44, 30);
            toolStripButton1.Text = "About";
            // 
            // tp_doctors
            // 
            tp_doctors.Controls.Add(button6);
            tp_doctors.Controls.Add(button7);
            tp_doctors.Controls.Add(button8);
            tp_doctors.Controls.Add(button9);
            tp_doctors.Controls.Add(dataGridViewDoctor);
            tp_doctors.Location = new Point(154, 4);
            tp_doctors.Name = "tp_doctors";
            tp_doctors.Padding = new Padding(3);
            tp_doctors.Size = new Size(642, 406);
            tp_doctors.TabIndex = 3;
            tp_doctors.Text = "Doctors";
            tp_doctors.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(138, 3);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 9;
            button6.Text = "Filter";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(92, 3);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 8;
            button7.Text = "Remove";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(46, 3);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 7;
            button8.Text = "Edit";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(0, 3);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 6;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDoctor.BackgroundColor = SystemColors.Control;
            dataGridViewDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctor.Location = new Point(5, 49);
            dataGridViewDoctor.Name = "dataGridViewDoctor";
            dataGridViewDoctor.RowHeadersWidth = 51;
            dataGridViewDoctor.Size = new Size(631, 349);
            dataGridViewDoctor.TabIndex = 5;
            // 
            // tp_records
            // 
            tp_records.Controls.Add(buttonFilterPatient);
            tp_records.Controls.Add(buttonRemovePatient);
            tp_records.Controls.Add(buttonEditPatient);
            tp_records.Controls.Add(buttonAddPatient);
            tp_records.Controls.Add(dataGridViewPatient);
            tp_records.Location = new Point(154, 4);
            tp_records.Name = "tp_records";
            tp_records.Padding = new Padding(3);
            tp_records.Size = new Size(642, 406);
            tp_records.TabIndex = 2;
            tp_records.Text = "Patient Records";
            tp_records.UseVisualStyleBackColor = true;
            // 
            // buttonFilterPatient
            // 
            buttonFilterPatient.Location = new Point(298, 4);
            buttonFilterPatient.Name = "buttonFilterPatient";
            buttonFilterPatient.Size = new Size(90, 40);
            buttonFilterPatient.TabIndex = 4;
            buttonFilterPatient.Text = "Filter";
            buttonFilterPatient.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePatient
            // 
            buttonRemovePatient.Location = new Point(202, 4);
            buttonRemovePatient.Name = "buttonRemovePatient";
            buttonRemovePatient.Size = new Size(90, 40);
            buttonRemovePatient.TabIndex = 3;
            buttonRemovePatient.Text = "Remove";
            buttonRemovePatient.UseVisualStyleBackColor = true;
            buttonRemovePatient.Click += buttonRemovePatient_Click;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditPatient.Location = new Point(106, 4);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(90, 40);
            buttonEditPatient.TabIndex = 2;
            buttonEditPatient.Text = "Edit";
            buttonEditPatient.UseVisualStyleBackColor = true;
            buttonEditPatient.Click += buttonEditPatient_Click;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddPatient.Location = new Point(10, 4);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(90, 40);
            buttonAddPatient.TabIndex = 1;
            buttonAddPatient.Text = "Add";
            buttonAddPatient.UseVisualStyleBackColor = true;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // dataGridViewPatient
            // 
            dataGridViewPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatient.BackgroundColor = SystemColors.Control;
            dataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatient.Location = new Point(5, 49);
            dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewPatient.Size = new Size(631, 349);
            dataGridViewPatient.TabIndex = 0;
            // 
            // tp_dashboard
            // 
            tp_dashboard.Controls.Add(label5);
            tp_dashboard.Controls.Add(panel2);
            tp_dashboard.Controls.Add(panel1);
            tp_dashboard.Controls.Add(dataGridViewRecentPatients);
            tp_dashboard.Location = new Point(154, 4);
            tp_dashboard.Name = "tp_dashboard";
            tp_dashboard.Padding = new Padding(3);
            tp_dashboard.Size = new Size(642, 406);
            tp_dashboard.TabIndex = 0;
            tp_dashboard.Text = "Dashboard";
            tp_dashboard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 96);
            label5.Name = "label5";
            label5.Size = new Size(257, 32);
            label5.TabIndex = 2;
            label5.Text = "Recent appointments";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(193, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 76);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 32);
            label2.Name = "label2";
            label2.Size = new Size(53, 32);
            label2.TabIndex = 1;
            label2.Text = "2/2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 0;
            label4.Text = "Bed availability";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 76);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(136, 32);
            label3.Name = "label3";
            label3.Size = new Size(28, 32);
            label3.TabIndex = 1;
            label3.Text = "5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Remaining patients";
            // 
            // dataGridViewRecentPatients
            // 
            dataGridViewRecentPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRecentPatients.BackgroundColor = SystemColors.Control;
            dataGridViewRecentPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecentPatients.Location = new Point(10, 131);
            dataGridViewRecentPatients.Name = "dataGridViewRecentPatients";
            dataGridViewRecentPatients.RowHeadersWidth = 51;
            dataGridViewRecentPatients.Size = new Size(626, 269);
            dataGridViewRecentPatients.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tp_dashboard);
            tabControl1.Controls.Add(tp_records);
            tabControl1.Controls.Add(tp_doctors);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(50, 150);
            tabControl1.Location = new Point(0, 36);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 414);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            tabControl1.DrawItem += tabControl1_DrawItem;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "Main";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tp_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            tp_records.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).EndInit();
            tp_dashboard.ResumeLayout(false);
            tp_dashboard.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentPatients).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private TabPage tp_doctors;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private DataGridView dataGridViewDoctor;
        private TabPage tp_records;
        
        private Button buttonFilterPatient;
        private Button buttonRemovePatient;
        private Button buttonEditPatient;
        private Button buttonAddPatient;
        private DataGridView dataGridViewPatient;
        private TabPage tp_dashboard;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private DataGridView dataGridViewRecentPatients;
        private TabControl tabControl1;
    }
}