namespace HealthCareSync.Views
{
    partial class ManageAppts
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
            monthCalendar = new MonthCalendar();
            patientNameTextBox = new TextBox();
            panel1 = new Panel();
            patientNameLabel = new Label();
            doctorsNameLabel = new Label();
            doctorsNameTextBox = new TextBox();
            panel2 = new Panel();
            appointmentTimeLabel = new Label();
            appointmentTimeTextBox = new TextBox();
            panel3 = new Panel();
            reasonLabel = new Label();
            reasonTextBox = new TextBox();
            panel4 = new Panel();
            scheduleBTN = new Button();
            EditBTN = new Button();
            appointmentsListBox = new ListBox();
            searchPatientApptsTextBox = new TextBox();
            panel5 = new Panel();
            searchBTN = new Button();
            searchPatientApptsLabel = new Label();
            appointmentLabel = new Label();
            avalableTimesLabel = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            clearSearchBTN = new Button();
            patentNameErrorLabel = new Label();
            reasonErrorLabel = new Label();
            patientNameErrorLabel = new Label();
            generalErrorlLabel = new Label();
            cancelApptBTN = new Button();
            searchPatientBTN = new Button();
            searchPatientTextBox = new TextBox();
            panel8 = new Panel();
            availableDocsComboBox = new ComboBox();
            label1 = new Label();
            searchPatientErrorLabel = new Label();
            label2 = new Label();
            availableTimesComboBox = new ComboBox();
            doctorsNameErrorLabel = new Label();
            appointmentTimeErrorLabel = new Label();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(71, 20);
            monthCalendar.Margin = new Padding(0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ScrollChange = 1;
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 0;
            monthCalendar.TrailingForeColor = SystemColors.ActiveCaptionText;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // patientNameTextBox
            // 
            patientNameTextBox.BackColor = Color.White;
            patientNameTextBox.BorderStyle = BorderStyle.None;
            patientNameTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameTextBox.ForeColor = SystemColors.HotTrack;
            patientNameTextBox.Location = new Point(587, 62);
            patientNameTextBox.Multiline = true;
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(246, 28);
            patientNameTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(429, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 1);
            panel1.TabIndex = 7;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.BackColor = SystemColors.Control;
            patientNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            patientNameLabel.Location = new Point(446, 65);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(129, 25);
            patientNameLabel.TabIndex = 8;
            patientNameLabel.Text = "Patient Name:";
            // 
            // doctorsNameLabel
            // 
            doctorsNameLabel.AutoSize = true;
            doctorsNameLabel.BackColor = SystemColors.Control;
            doctorsNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorsNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            doctorsNameLabel.Location = new Point(446, 169);
            doctorsNameLabel.Name = "doctorsNameLabel";
            doctorsNameLabel.Size = new Size(139, 25);
            doctorsNameLabel.TabIndex = 11;
            doctorsNameLabel.Text = "Doctor's Name:";
            // 
            // doctorsNameTextBox
            // 
            doctorsNameTextBox.BackColor = Color.White;
            doctorsNameTextBox.BorderStyle = BorderStyle.None;
            doctorsNameTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsNameTextBox.ForeColor = SystemColors.HotTrack;
            doctorsNameTextBox.Location = new Point(591, 163);
            doctorsNameTextBox.Multiline = true;
            doctorsNameTextBox.Name = "doctorsNameTextBox";
            doctorsNameTextBox.Size = new Size(246, 31);
            doctorsNameTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(429, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 1);
            panel2.TabIndex = 10;
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.BackColor = SystemColors.Control;
            appointmentTimeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentTimeLabel.ForeColor = SystemColors.ActiveCaptionText;
            appointmentTimeLabel.Location = new Point(446, 266);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new Size(107, 25);
            appointmentTimeLabel.TabIndex = 14;
            appointmentTimeLabel.Text = "Appt. Time:";
            // 
            // appointmentTimeTextBox
            // 
            appointmentTimeTextBox.BackColor = Color.White;
            appointmentTimeTextBox.BorderStyle = BorderStyle.None;
            appointmentTimeTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentTimeTextBox.ForeColor = SystemColors.HotTrack;
            appointmentTimeTextBox.Location = new Point(559, 260);
            appointmentTimeTextBox.Multiline = true;
            appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            appointmentTimeTextBox.Size = new Size(274, 33);
            appointmentTimeTextBox.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.ForeColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(436, 295);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 1);
            panel3.TabIndex = 13;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.BackColor = SystemColors.Control;
            reasonLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reasonLabel.ForeColor = SystemColors.ActiveCaptionText;
            reasonLabel.Location = new Point(446, 371);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(76, 25);
            reasonLabel.TabIndex = 17;
            reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.BackColor = Color.White;
            reasonTextBox.BorderStyle = BorderStyle.None;
            reasonTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonTextBox.ForeColor = SystemColors.HotTrack;
            reasonTextBox.Location = new Point(538, 370);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(295, 32);
            reasonTextBox.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.ForeColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(436, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 1);
            panel4.TabIndex = 16;
            // 
            // scheduleBTN
            // 
            scheduleBTN.BackColor = Color.IndianRed;
            scheduleBTN.FlatAppearance.BorderSize = 0;
            scheduleBTN.FlatStyle = FlatStyle.Flat;
            scheduleBTN.Font = new Font("Showcard Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scheduleBTN.ForeColor = Color.White;
            scheduleBTN.Location = new Point(436, 550);
            scheduleBTN.Name = "scheduleBTN";
            scheduleBTN.Size = new Size(101, 44);
            scheduleBTN.TabIndex = 18;
            scheduleBTN.Text = "Schedule";
            scheduleBTN.UseVisualStyleBackColor = false;
            scheduleBTN.Click += scheduleBTN_Click;
            // 
            // EditBTN
            // 
            EditBTN.BackColor = Color.IndianRed;
            EditBTN.FlatAppearance.BorderSize = 0;
            EditBTN.FlatStyle = FlatStyle.Flat;
            EditBTN.Font = new Font("Showcard Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBTN.ForeColor = Color.White;
            EditBTN.Location = new Point(587, 550);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(97, 44);
            EditBTN.TabIndex = 19;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = false;
            EditBTN.Click += EditBTN_Click;
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.BorderStyle = BorderStyle.FixedSingle;
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 25;
            appointmentsListBox.Location = new Point(908, 48);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(385, 402);
            appointmentsListBox.TabIndex = 20;
            appointmentsListBox.SelectedIndexChanged += appointmentsListBox_SelectedIndexChanged;
            // 
            // searchPatientApptsTextBox
            // 
            searchPatientApptsTextBox.BackColor = Color.White;
            searchPatientApptsTextBox.BorderStyle = BorderStyle.None;
            searchPatientApptsTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientApptsTextBox.ForeColor = SystemColors.HotTrack;
            searchPatientApptsTextBox.Location = new Point(921, 550);
            searchPatientApptsTextBox.Multiline = true;
            searchPatientApptsTextBox.Name = "searchPatientApptsTextBox";
            searchPatientApptsTextBox.Size = new Size(170, 37);
            searchPatientApptsTextBox.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.ForeColor = SystemColors.ButtonShadow;
            panel5.Location = new Point(908, 593);
            panel5.Name = "panel5";
            panel5.Size = new Size(378, 1);
            panel5.TabIndex = 22;
            // 
            // searchBTN
            // 
            searchBTN.BackColor = Color.IndianRed;
            searchBTN.FlatAppearance.BorderSize = 0;
            searchBTN.FlatStyle = FlatStyle.Flat;
            searchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBTN.ForeColor = Color.White;
            searchBTN.Location = new Point(1097, 543);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(95, 44);
            searchBTN.TabIndex = 23;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = false;
            searchBTN.Click += searchBTN_Click;
            // 
            // searchPatientApptsLabel
            // 
            searchPatientApptsLabel.AutoSize = true;
            searchPatientApptsLabel.Location = new Point(940, 476);
            searchPatientApptsLabel.Name = "searchPatientApptsLabel";
            searchPatientApptsLabel.Size = new Size(0, 25);
            searchPatientApptsLabel.TabIndex = 24;
            // 
            // appointmentLabel
            // 
            appointmentLabel.AutoSize = true;
            appointmentLabel.BackColor = SystemColors.Control;
            appointmentLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentLabel.ForeColor = SystemColors.ActiveCaptionText;
            appointmentLabel.Location = new Point(908, 20);
            appointmentLabel.Name = "appointmentLabel";
            appointmentLabel.Size = new Size(136, 25);
            appointmentLabel.TabIndex = 25;
            appointmentLabel.Text = "Appointments:";
            // 
            // avalableTimesLabel
            // 
            avalableTimesLabel.AutoSize = true;
            avalableTimesLabel.BackColor = SystemColors.Control;
            avalableTimesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avalableTimesLabel.ForeColor = SystemColors.ActiveCaptionText;
            avalableTimesLabel.Location = new Point(71, 287);
            avalableTimesLabel.Name = "avalableTimesLabel";
            avalableTimesLabel.Size = new Size(134, 25);
            avalableTimesLabel.TabIndex = 26;
            avalableTimesLabel.Text = "Search Patient:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(412, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 589);
            panel6.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(887, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 594);
            panel7.TabIndex = 28;
            // 
            // clearSearchBTN
            // 
            clearSearchBTN.BackColor = Color.IndianRed;
            clearSearchBTN.FlatAppearance.BorderSize = 0;
            clearSearchBTN.FlatStyle = FlatStyle.Flat;
            clearSearchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearSearchBTN.ForeColor = Color.White;
            clearSearchBTN.Location = new Point(1198, 541);
            clearSearchBTN.Name = "clearSearchBTN";
            clearSearchBTN.Size = new Size(95, 44);
            clearSearchBTN.TabIndex = 29;
            clearSearchBTN.Text = "Clear";
            clearSearchBTN.UseVisualStyleBackColor = false;
            clearSearchBTN.Click += clearBTN_Click;
            // 
            // patentNameErrorLabel
            // 
            patentNameErrorLabel.AutoSize = true;
            patentNameErrorLabel.Location = new Point(446, 103);
            patentNameErrorLabel.Name = "patentNameErrorLabel";
            patentNameErrorLabel.Size = new Size(0, 25);
            patentNameErrorLabel.TabIndex = 30;
            // 
            // reasonErrorLabel
            // 
            reasonErrorLabel.AutoSize = true;
            reasonErrorLabel.Location = new Point(446, 412);
            reasonErrorLabel.Name = "reasonErrorLabel";
            reasonErrorLabel.Size = new Size(0, 25);
            reasonErrorLabel.TabIndex = 31;
            // 
            // patientNameErrorLabel
            // 
            patientNameErrorLabel.AutoSize = true;
            patientNameErrorLabel.Location = new Point(446, 103);
            patientNameErrorLabel.Name = "patientNameErrorLabel";
            patientNameErrorLabel.Size = new Size(0, 25);
            patientNameErrorLabel.TabIndex = 32;
            // 
            // generalErrorlLabel
            // 
            generalErrorlLabel.AutoSize = true;
            generalErrorlLabel.Location = new Point(446, 476);
            generalErrorlLabel.Name = "generalErrorlLabel";
            generalErrorlLabel.Size = new Size(0, 25);
            generalErrorlLabel.TabIndex = 33;
            // 
            // cancelApptBTN
            // 
            cancelApptBTN.BackColor = Color.IndianRed;
            cancelApptBTN.FlatAppearance.BorderSize = 0;
            cancelApptBTN.FlatStyle = FlatStyle.Flat;
            cancelApptBTN.Font = new Font("Showcard Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelApptBTN.ForeColor = Color.White;
            cancelApptBTN.Location = new Point(736, 550);
            cancelApptBTN.Name = "cancelApptBTN";
            cancelApptBTN.Size = new Size(97, 44);
            cancelApptBTN.TabIndex = 34;
            cancelApptBTN.Text = "Cancel";
            cancelApptBTN.UseVisualStyleBackColor = false;
            // 
            // searchPatientBTN
            // 
            searchPatientBTN.BackColor = Color.IndianRed;
            searchPatientBTN.FlatAppearance.BorderSize = 0;
            searchPatientBTN.FlatStyle = FlatStyle.Flat;
            searchPatientBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientBTN.ForeColor = Color.White;
            searchPatientBTN.Location = new Point(288, 315);
            searchPatientBTN.Name = "searchPatientBTN";
            searchPatientBTN.Size = new Size(95, 28);
            searchPatientBTN.TabIndex = 37;
            searchPatientBTN.Text = "Search";
            searchPatientBTN.UseVisualStyleBackColor = false;
            searchPatientBTN.Click += searchPatientBTN_Click;
            // 
            // searchPatientTextBox
            // 
            searchPatientTextBox.BackColor = Color.White;
            searchPatientTextBox.BorderStyle = BorderStyle.None;
            searchPatientTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientTextBox.ForeColor = SystemColors.HotTrack;
            searchPatientTextBox.Location = new Point(71, 315);
            searchPatientTextBox.Multiline = true;
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.Size = new Size(211, 28);
            searchPatientTextBox.TabIndex = 35;
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Enabled = false;
            panel8.ForeColor = SystemColors.ButtonShadow;
            panel8.Location = new Point(71, 349);
            panel8.Name = "panel8";
            panel8.Size = new Size(312, 1);
            panel8.TabIndex = 36;
            // 
            // availableDocsComboBox
            // 
            availableDocsComboBox.FormattingEnabled = true;
            availableDocsComboBox.Location = new Point(71, 426);
            availableDocsComboBox.Name = "availableDocsComboBox";
            availableDocsComboBox.Size = new Size(312, 33);
            availableDocsComboBox.TabIndex = 38;
            availableDocsComboBox.SelectedIndexChanged += availableDocsComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(71, 398);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 39;
            label1.Text = "Availabe Doctor(s):";
            // 
            // searchPatientErrorLabel
            // 
            searchPatientErrorLabel.AutoSize = true;
            searchPatientErrorLabel.Location = new Point(71, 353);
            searchPatientErrorLabel.Name = "searchPatientErrorLabel";
            searchPatientErrorLabel.Size = new Size(0, 25);
            searchPatientErrorLabel.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(71, 492);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 42;
            label2.Text = "Availabe Time(s):";
            // 
            // availableTimesComboBox
            // 
            availableTimesComboBox.FormattingEnabled = true;
            availableTimesComboBox.Location = new Point(71, 520);
            availableTimesComboBox.Name = "availableTimesComboBox";
            availableTimesComboBox.Size = new Size(312, 33);
            availableTimesComboBox.TabIndex = 41;
            availableTimesComboBox.SelectedIndexChanged += availableTimesComboBox_SelectedIndexChanged;
            // 
            // doctorsNameErrorLabel
            // 
            doctorsNameErrorLabel.AutoSize = true;
            doctorsNameErrorLabel.Location = new Point(446, 201);
            doctorsNameErrorLabel.Name = "doctorsNameErrorLabel";
            doctorsNameErrorLabel.Size = new Size(0, 25);
            doctorsNameErrorLabel.TabIndex = 44;
            // 
            // appointmentTimeErrorLabel
            // 
            appointmentTimeErrorLabel.AutoSize = true;
            appointmentTimeErrorLabel.Location = new Point(446, 299);
            appointmentTimeErrorLabel.Name = "appointmentTimeErrorLabel";
            appointmentTimeErrorLabel.Size = new Size(0, 25);
            appointmentTimeErrorLabel.TabIndex = 45;
            // 
            // ManageAppts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(appointmentTimeErrorLabel);
            Controls.Add(doctorsNameErrorLabel);
            Controls.Add(label2);
            Controls.Add(availableTimesComboBox);
            Controls.Add(searchPatientErrorLabel);
            Controls.Add(label1);
            Controls.Add(availableDocsComboBox);
            Controls.Add(searchPatientBTN);
            Controls.Add(searchPatientTextBox);
            Controls.Add(panel8);
            Controls.Add(cancelApptBTN);
            Controls.Add(generalErrorlLabel);
            Controls.Add(patientNameErrorLabel);
            Controls.Add(reasonErrorLabel);
            Controls.Add(patentNameErrorLabel);
            Controls.Add(clearSearchBTN);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(avalableTimesLabel);
            Controls.Add(appointmentLabel);
            Controls.Add(searchPatientApptsLabel);
            Controls.Add(searchBTN);
            Controls.Add(searchPatientApptsTextBox);
            Controls.Add(panel5);
            Controls.Add(appointmentsListBox);
            Controls.Add(EditBTN);
            Controls.Add(scheduleBTN);
            Controls.Add(reasonLabel);
            Controls.Add(reasonTextBox);
            Controls.Add(panel4);
            Controls.Add(appointmentTimeLabel);
            Controls.Add(appointmentTimeTextBox);
            Controls.Add(panel3);
            Controls.Add(doctorsNameLabel);
            Controls.Add(doctorsNameTextBox);
            Controls.Add(panel2);
            Controls.Add(patientNameLabel);
            Controls.Add(patientNameTextBox);
            Controls.Add(panel1);
            Controls.Add(monthCalendar);
            Name = "ManageAppts";
            Size = new Size(1308, 615);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar monthCalendar;
        private TextBox patientNameTextBox;
        private Panel panel1;
        private Label patientNameLabel;
        private Label doctorsNameLabel;
        private TextBox doctorsNameTextBox;
        private Panel panel2;
        private Label appointmentTimeLabel;
        private TextBox appointmentTimeTextBox;
        private Panel panel3;
        private Label reasonLabel;
        private TextBox reasonTextBox;
        private Panel panel4;
        private Button scheduleBTN;
        private Button EditBTN;
        private ListBox appointmentsListBox;
        private TextBox searchPatientApptsTextBox;
        private Panel panel5;
        private Button searchBTN;
        private Label searchPatientApptsLabel;
        private Label appointmentLabel;
        private Label avalableTimesLabel;
        private Panel panel6;
        private Panel panel7;
        private Button clearSearchBTN;
        private Label patentNameErrorLabel;
        private Label reasonErrorLabel;
        private Label patientNameErrorLabel;
        private Label generalErrorlLabel;
        private Button cancelApptBTN;
        private Button searchPatientBTN;
        private TextBox searchPatientTextBox;
        private Panel panel8;
        private ComboBox availableDocsComboBox;
        private Label label1;
        private Label searchPatientErrorLabel;
        private Label label2;
        private ComboBox availableTimesComboBox;
        private Label doctorsNameErrorLabel;
        private Label appointmentTimeErrorLabel;
    }
}