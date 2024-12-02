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
            appointmentLabel = new Label();
            avalableTimesLabel = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            clearSearchBTN = new Button();
            cancelApptBTN = new Button();
            searchPatientBTN = new Button();
            searchPatientTextBox = new TextBox();
            panel8 = new Panel();
            availableDocsComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            availableTimesComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(96, 32);
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
            patientNameTextBox.Location = new Point(457, 57);
            patientNameTextBox.Margin = new Padding(2);
            patientNameTextBox.Multiline = true;
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.PlaceholderText = "Auto Populated Field";
            patientNameTextBox.ReadOnly = true;
            patientNameTextBox.Size = new Size(172, 17);
            patientNameTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(346, 79);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 1);
            panel1.TabIndex = 7;
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.BackColor = SystemColors.Control;
            patientNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            patientNameLabel.Location = new Point(358, 59);
            patientNameLabel.Margin = new Padding(2, 0, 2, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(82, 15);
            patientNameLabel.TabIndex = 8;
            patientNameLabel.Text = "Patient Name:";
            // 
            // doctorsNameLabel
            // 
            doctorsNameLabel.AutoSize = true;
            doctorsNameLabel.BackColor = SystemColors.Control;
            doctorsNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorsNameLabel.ForeColor = SystemColors.ActiveCaptionText;
            doctorsNameLabel.Location = new Point(358, 121);
            doctorsNameLabel.Margin = new Padding(2, 0, 2, 0);
            doctorsNameLabel.Name = "doctorsNameLabel";
            doctorsNameLabel.Size = new Size(90, 15);
            doctorsNameLabel.TabIndex = 11;
            doctorsNameLabel.Text = "Doctor's Name:";
            // 
            // doctorsNameTextBox
            // 
            doctorsNameTextBox.BackColor = Color.White;
            doctorsNameTextBox.BorderStyle = BorderStyle.None;
            doctorsNameTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsNameTextBox.ForeColor = SystemColors.HotTrack;
            doctorsNameTextBox.Location = new Point(460, 118);
            doctorsNameTextBox.Margin = new Padding(2);
            doctorsNameTextBox.Multiline = true;
            doctorsNameTextBox.Name = "doctorsNameTextBox";
            doctorsNameTextBox.PlaceholderText = "Auto Populated Field";
            doctorsNameTextBox.ReadOnly = true;
            doctorsNameTextBox.Size = new Size(172, 19);
            doctorsNameTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(346, 138);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 1);
            panel2.TabIndex = 10;
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.BackColor = SystemColors.Control;
            appointmentTimeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentTimeLabel.ForeColor = SystemColors.ActiveCaptionText;
            appointmentTimeLabel.Location = new Point(358, 180);
            appointmentTimeLabel.Margin = new Padding(2, 0, 2, 0);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new Size(69, 15);
            appointmentTimeLabel.TabIndex = 14;
            appointmentTimeLabel.Text = "Appt. Time:";
            // 
            // appointmentTimeTextBox
            // 
            appointmentTimeTextBox.BackColor = Color.White;
            appointmentTimeTextBox.BorderStyle = BorderStyle.None;
            appointmentTimeTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentTimeTextBox.ForeColor = SystemColors.HotTrack;
            appointmentTimeTextBox.Location = new Point(437, 176);
            appointmentTimeTextBox.Margin = new Padding(2);
            appointmentTimeTextBox.Multiline = true;
            appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            appointmentTimeTextBox.PlaceholderText = "Auto Populated Field";
            appointmentTimeTextBox.ReadOnly = true;
            appointmentTimeTextBox.Size = new Size(192, 20);
            appointmentTimeTextBox.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.ForeColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(351, 197);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 1);
            panel3.TabIndex = 13;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.BackColor = SystemColors.Control;
            reasonLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reasonLabel.ForeColor = SystemColors.ActiveCaptionText;
            reasonLabel.Location = new Point(358, 243);
            reasonLabel.Margin = new Padding(2, 0, 2, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(48, 15);
            reasonLabel.TabIndex = 17;
            reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.BackColor = Color.White;
            reasonTextBox.BorderStyle = BorderStyle.None;
            reasonTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonTextBox.ForeColor = SystemColors.HotTrack;
            reasonTextBox.Location = new Point(423, 242);
            reasonTextBox.Margin = new Padding(2);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(206, 19);
            reasonTextBox.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.ForeColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(351, 265);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 1);
            panel4.TabIndex = 16;
            // 
            // scheduleBTN
            // 
            scheduleBTN.BackColor = Color.IndianRed;
            scheduleBTN.FlatAppearance.BorderSize = 0;
            scheduleBTN.FlatStyle = FlatStyle.Flat;
            scheduleBTN.Font = new Font("Showcard Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scheduleBTN.ForeColor = Color.White;
            scheduleBTN.Location = new Point(351, 334);
            scheduleBTN.Margin = new Padding(2);
            scheduleBTN.Name = "scheduleBTN";
            scheduleBTN.Size = new Size(71, 26);
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
            EditBTN.Location = new Point(457, 334);
            EditBTN.Margin = new Padding(2);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(68, 26);
            EditBTN.TabIndex = 19;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = false;
            EditBTN.Click += EditBTN_Click;
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.BorderStyle = BorderStyle.FixedSingle;
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 15;
            appointmentsListBox.Location = new Point(670, 49);
            appointmentsListBox.Margin = new Padding(2);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(244, 242);
            appointmentsListBox.TabIndex = 20;
            appointmentsListBox.SelectedIndexChanged += appointmentsListBox_SelectedIndexChanged;
            // 
            // searchPatientApptsTextBox
            // 
            searchPatientApptsTextBox.BackColor = Color.White;
            searchPatientApptsTextBox.BorderStyle = BorderStyle.None;
            searchPatientApptsTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchPatientApptsTextBox.ForeColor = SystemColors.HotTrack;
            searchPatientApptsTextBox.Location = new Point(657, 333);
            searchPatientApptsTextBox.Margin = new Padding(2);
            searchPatientApptsTextBox.Multiline = true;
            searchPatientApptsTextBox.Name = "searchPatientApptsTextBox";
            searchPatientApptsTextBox.Size = new Size(111, 22);
            searchPatientApptsTextBox.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.ForeColor = SystemColors.ButtonShadow;
            panel5.Location = new Point(682, 376);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(265, 1);
            panel5.TabIndex = 22;
            // 
            // searchBTN
            // 
            searchBTN.BackColor = Color.IndianRed;
            searchBTN.FlatAppearance.BorderSize = 0;
            searchBTN.FlatStyle = FlatStyle.Flat;
            searchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBTN.ForeColor = Color.White;
            searchBTN.Location = new Point(775, 333);
            searchBTN.Margin = new Padding(2);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(66, 26);
            searchBTN.TabIndex = 23;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = false;
            searchBTN.Click += searchBTN_Click;
            // 
            // appointmentLabel
            // 
            appointmentLabel.AutoSize = true;
            appointmentLabel.BackColor = SystemColors.Control;
            appointmentLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentLabel.ForeColor = SystemColors.ActiveCaptionText;
            appointmentLabel.Location = new Point(670, 32);
            appointmentLabel.Margin = new Padding(2, 0, 2, 0);
            appointmentLabel.Name = "appointmentLabel";
            appointmentLabel.Size = new Size(86, 15);
            appointmentLabel.TabIndex = 25;
            appointmentLabel.Text = "Appointments:";
            // 
            // avalableTimesLabel
            // 
            avalableTimesLabel.AutoSize = true;
            avalableTimesLabel.BackColor = SystemColors.Control;
            avalableTimesLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avalableTimesLabel.ForeColor = SystemColors.ActiveCaptionText;
            avalableTimesLabel.Location = new Point(96, 205);
            avalableTimesLabel.Margin = new Padding(2, 0, 2, 0);
            avalableTimesLabel.Name = "avalableTimesLabel";
            avalableTimesLabel.Size = new Size(106, 15);
            avalableTimesLabel.TabIndex = 26;
            avalableTimesLabel.Text = "Search For Patient:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(334, 27);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 353);
            panel6.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(652, 27);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 356);
            panel7.TabIndex = 28;
            // 
            // clearSearchBTN
            // 
            clearSearchBTN.BackColor = Color.IndianRed;
            clearSearchBTN.FlatAppearance.BorderSize = 0;
            clearSearchBTN.FlatStyle = FlatStyle.Flat;
            clearSearchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearSearchBTN.ForeColor = Color.White;
            clearSearchBTN.Location = new Point(846, 333);
            clearSearchBTN.Margin = new Padding(2);
            clearSearchBTN.Name = "clearSearchBTN";
            clearSearchBTN.Size = new Size(66, 26);
            clearSearchBTN.TabIndex = 29;
            clearSearchBTN.Text = "Clear";
            clearSearchBTN.UseVisualStyleBackColor = false;
            clearSearchBTN.Click += clearBTN_Click;
            // 
            // cancelApptBTN
            // 
            cancelApptBTN.BackColor = Color.IndianRed;
            cancelApptBTN.FlatAppearance.BorderSize = 0;
            cancelApptBTN.FlatStyle = FlatStyle.Flat;
            cancelApptBTN.Font = new Font("Showcard Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelApptBTN.ForeColor = Color.White;
            cancelApptBTN.Location = new Point(561, 334);
            cancelApptBTN.Margin = new Padding(2);
            cancelApptBTN.Name = "cancelApptBTN";
            cancelApptBTN.Size = new Size(68, 26);
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
            searchPatientBTN.Location = new Point(248, 219);
            searchPatientBTN.Margin = new Padding(2);
            searchPatientBTN.Name = "searchPatientBTN";
            searchPatientBTN.Size = new Size(66, 24);
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
            searchPatientTextBox.Location = new Point(96, 222);
            searchPatientTextBox.Margin = new Padding(2);
            searchPatientTextBox.Multiline = true;
            searchPatientTextBox.Name = "searchPatientTextBox";
            searchPatientTextBox.Size = new Size(148, 17);
            searchPatientTextBox.TabIndex = 35;
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Enabled = false;
            panel8.ForeColor = SystemColors.ButtonShadow;
            panel8.Location = new Point(96, 242);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(218, 1);
            panel8.TabIndex = 36;
            // 
            // availableDocsComboBox
            // 
            availableDocsComboBox.FormattingEnabled = true;
            availableDocsComboBox.Location = new Point(96, 282);
            availableDocsComboBox.Margin = new Padding(2);
            availableDocsComboBox.Name = "availableDocsComboBox";
            availableDocsComboBox.Size = new Size(220, 23);
            availableDocsComboBox.TabIndex = 38;
            availableDocsComboBox.SelectedIndexChanged += availableDocsComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(96, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 39;
            label1.Text = "Select An Availabe Doctor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(96, 320);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 42;
            label2.Text = "Select An Availabe Time:";
            // 
            // availableTimesComboBox
            // 
            availableTimesComboBox.FormattingEnabled = true;
            availableTimesComboBox.Location = new Point(96, 337);
            availableTimesComboBox.Margin = new Padding(2);
            availableTimesComboBox.Name = "availableTimesComboBox";
            availableTimesComboBox.Size = new Size(220, 23);
            availableTimesComboBox.TabIndex = 41;
            availableTimesComboBox.SelectedIndexChanged += availableTimesComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(101, 27);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 19);
            label3.TabIndex = 43;
            label3.Text = "To Schecudel Anppointment First:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(101, 185);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 44;
            label4.Text = "Then:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(101, 244);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 45;
            label5.Text = "Then:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(101, 303);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 46;
            label6.Text = "Then:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(669, 303);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(233, 19);
            label7.TabIndex = 47;
            label7.Text = "Search For a Patient Appts By Name:";
            // 
            // ManageAppts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(availableTimesComboBox);
            Controls.Add(label1);
            Controls.Add(availableDocsComboBox);
            Controls.Add(searchPatientBTN);
            Controls.Add(searchPatientTextBox);
            Controls.Add(panel8);
            Controls.Add(cancelApptBTN);
            Controls.Add(clearSearchBTN);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(avalableTimesLabel);
            Controls.Add(appointmentLabel);
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
            Margin = new Padding(2);
            Name = "ManageAppts";
            Size = new Size(916, 369);
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
        private Label appointmentLabel;
        private Label avalableTimesLabel;
        private Panel panel6;
        private Panel panel7;
        private Button clearSearchBTN;
        private Button cancelApptBTN;
        private Button searchPatientBTN;
        private TextBox searchPatientTextBox;
        private Panel panel8;
        private ComboBox availableDocsComboBox;
        private Label label1;
        private Label label2;
        private ComboBox availableTimesComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}