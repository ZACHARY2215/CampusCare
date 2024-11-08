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
            toolStripButton2 = new ToolStripButton();
            tp_doctors = new TabPage();
            doctorRemoveButton = new Button();
            doctorEditButton = new Button();
            doctorAddButton = new Button();
            dataGridViewDoctor = new DataGridView();
            tp_records = new TabPage();
            buttonRemovePatient = new Button();
            buttonEditPatient = new Button();
            buttonAddPatient = new Button();
            dataGridViewPatient = new DataGridView();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            comboBoxSortOptions = new ComboBox();
            buttonViewPatient = new Button();
            tp_dashboard = new TabPage();
            label5 = new Label();
            panel2 = new Panel();
            labelMonthlyRecords = new Label();
            panel1 = new Panel();
            labelTodayRecords = new Label();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1, toolStripButton2 });
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
            toolStripButton1.Font = new Font("Microsoft Sans Serif", 9F);
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(83, 30);
            toolStripButton1.Text = "CampusCare";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 30);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // tp_doctors
            // 
            tp_doctors.Controls.Add(doctorRemoveButton);
            tp_doctors.Controls.Add(doctorEditButton);
            tp_doctors.Controls.Add(doctorAddButton);
            tp_doctors.Controls.Add(dataGridViewDoctor);
            tp_doctors.Location = new Point(154, 4);
            tp_doctors.Name = "tp_doctors";
            tp_doctors.Padding = new Padding(3);
            tp_doctors.Size = new Size(642, 406);
            tp_doctors.TabIndex = 3;
            tp_doctors.Text = "Doctors";
            tp_doctors.UseVisualStyleBackColor = true;
            // 
            // doctorRemoveButton
            // 
            doctorRemoveButton.Location = new Point(175, 3);
            doctorRemoveButton.Margin = new Padding(3, 2, 3, 2);
            doctorRemoveButton.Name = "doctorRemoveButton";
            doctorRemoveButton.Size = new Size(79, 30);
            doctorRemoveButton.TabIndex = 8;
            doctorRemoveButton.Text = "Remove";
            doctorRemoveButton.UseVisualStyleBackColor = true;
            doctorRemoveButton.Click += removeButton_Click;
            // 
            // doctorEditButton
            // 
            doctorEditButton.BackgroundImageLayout = ImageLayout.Zoom;
            doctorEditButton.Location = new Point(90, 3);
            doctorEditButton.Margin = new Padding(3, 2, 3, 2);
            doctorEditButton.Name = "doctorEditButton";
            doctorEditButton.Size = new Size(79, 30);
            doctorEditButton.TabIndex = 7;
            doctorEditButton.Text = "Edit";
            doctorEditButton.UseVisualStyleBackColor = true;
            doctorEditButton.Click += doctorEditButton_Click;
            // 
            // doctorAddButton
            // 
            doctorAddButton.BackgroundImageLayout = ImageLayout.Zoom;
            doctorAddButton.Location = new Point(8, 3);
            doctorAddButton.Margin = new Padding(3, 2, 3, 2);
            doctorAddButton.Name = "doctorAddButton";
            doctorAddButton.Size = new Size(79, 30);
            doctorAddButton.TabIndex = 6;
            doctorAddButton.Text = "Add";
            doctorAddButton.UseVisualStyleBackColor = true;
            doctorAddButton.Click += doctorAddButton_Click;
            // 
            // dataGridViewDoctor
            // 
            dataGridViewDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDoctor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            tp_records.Controls.Add(buttonRemovePatient);
            tp_records.Controls.Add(buttonEditPatient);
            tp_records.Controls.Add(buttonAddPatient);
            tp_records.Controls.Add(dataGridViewPatient);
            tp_records.Controls.Add(textBoxSearch);
            tp_records.Controls.Add(buttonSearch);
            tp_records.Controls.Add(comboBoxSortOptions);
            tp_records.Location = new Point(154, 4);
            tp_records.Name = "tp_records";
            tp_records.Padding = new Padding(3);
            tp_records.Size = new Size(642, 406);
            tp_records.TabIndex = 2;
            tp_records.Text = "Patient Records";
            tp_records.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePatient
            // 
            buttonRemovePatient.Font = new Font("Microsoft Sans Serif", 9F);
            buttonRemovePatient.Location = new Point(266, 9);
            buttonRemovePatient.Name = "buttonRemovePatient";
            buttonRemovePatient.Size = new Size(73, 22);
            buttonRemovePatient.TabIndex = 3;
            buttonRemovePatient.Text = "Remove";
            buttonRemovePatient.UseVisualStyleBackColor = true;
            buttonRemovePatient.Click += buttonRemovePatient_Click;
            // 
            // buttonEditPatient
            // 
            buttonEditPatient.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditPatient.Font = new Font("Microsoft Sans Serif", 9F);
            buttonEditPatient.Location = new Point(220, 36);
            buttonEditPatient.Name = "buttonEditPatient";
            buttonEditPatient.Size = new Size(60, 21);
            buttonEditPatient.TabIndex = 2;
            buttonEditPatient.Text = "Edit";
            buttonEditPatient.UseVisualStyleBackColor = true;
            buttonEditPatient.Click += buttonEditPatient_Click;
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAddPatient.Font = new Font("Microsoft Sans Serif", 9F);
            buttonAddPatient.Location = new Point(142, 36);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(73, 21);
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
            dataGridViewPatient.Location = new Point(5, 68);
            dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewPatient.Size = new Size(631, 329);
            dataGridViewPatient.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxSearch.Location = new Point(5, 10);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search patients...";
            textBoxSearch.Size = new Size(176, 21);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(186, 9);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 22);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBoxSortOptions
            // 
            comboBoxSortOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortOptions.Font = new Font("Microsoft Sans Serif", 9F);
            comboBoxSortOptions.Items.AddRange(new object[] { "<default>", "First Name (A-Z)", "First Name (Z-A)", "Last Name (A-Z)", "Last Name (Z-A)", "School ID (Ascending)", "School ID (Descending)", "Gender", "Grade/Department" });
            comboBoxSortOptions.Location = new Point(5, 35);
            comboBoxSortOptions.Margin = new Padding(3, 2, 3, 2);
            comboBoxSortOptions.Name = "comboBoxSortOptions";
            comboBoxSortOptions.Size = new Size(132, 23);
            comboBoxSortOptions.TabIndex = 7;
            comboBoxSortOptions.SelectedIndexChanged += comboBoxSortOptions_SelectedIndexChanged;
            // 
            // buttonViewPatient
            // 
            buttonViewPatient.Location = new Point(0, 0);
            buttonViewPatient.Name = "buttonViewPatient";
            buttonViewPatient.Size = new Size(75, 23);
            buttonViewPatient.TabIndex = 0;
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
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label5.Location = new Point(10, 98);
            label5.Name = "label5";
            label5.Size = new Size(259, 29);
            label5.TabIndex = 2;
            label5.Text = "Recent appointments";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelMonthlyRecords);
            panel2.Location = new Point(193, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 76);
            panel2.TabIndex = 2;
            // 
            // labelMonthlyRecords
            // 
            labelMonthlyRecords.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonthlyRecords.Location = new Point(-1, 2);
            labelMonthlyRecords.Name = "labelMonthlyRecords";
            labelMonthlyRecords.Size = new Size(164, 74);
            labelMonthlyRecords.TabIndex = 3;
            labelMonthlyRecords.Text = "Records added this month 0";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTodayRecords);
            panel1.Location = new Point(10, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 76);
            panel1.TabIndex = 1;
            // 
            // labelTodayRecords
            // 
            labelTodayRecords.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTodayRecords.Location = new Point(3, 2);
            labelTodayRecords.Name = "labelTodayRecords";
            labelTodayRecords.Size = new Size(164, 68);
            labelTodayRecords.TabIndex = 3;
            labelTodayRecords.Text = "Records added today: 0";
            labelTodayRecords.Click += labelTodayRecords_Click;
            // 
            // dataGridViewRecentPatients
            // 
            dataGridViewRecentPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRecentPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            tabControl1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            Load += Main_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tp_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctor).EndInit();
            tp_records.ResumeLayout(false);
            tp_records.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).EndInit();
            tp_dashboard.ResumeLayout(false);
            tp_dashboard.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Button doctorRemoveButton;
        private Button doctorEditButton;
        private Button doctorAddButton;
        private DataGridView dataGridViewDoctor;
        private TabPage tp_records;
        private Button buttonRemovePatient;
        private Button buttonEditPatient;
        private Button buttonAddPatient;
        private DataGridView dataGridViewPatient;
        private TabPage tp_dashboard;
        private Label label5;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridViewRecentPatients;
        private TabControl tabControl1;
        private Button buttonViewPatient;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ComboBox comboBoxSortOptions;
        private ToolStripButton toolStripButton2;
        //private Button buttonSort;
        private Label labelTodayRecords;
        private Label labelMonthlyRecords;

    }
}