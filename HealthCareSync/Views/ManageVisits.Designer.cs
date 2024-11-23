namespace HealthCareSync.Views
{
    partial class ManageVisits
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
            visitsListBox = new ListBox();
            visitDateTimePicker = new DateTimePicker();
            saveButton = new Button();
            bpmTextBox = new TextBox();
            clearButton = new Button();
            weightTextBox = new TextBox();
            temperatureTextBox = new TextBox();
            symptomsTextBox = new TextBox();
            label2 = new Label();
            diastolicTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            heightTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel15 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel11 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            label14 = new Label();
            systolicTextBox = new TextBox();
            successLabel = new Label();
            panel9 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            resetSearchButton = new Button();
            searchButton = new Button();
            searchByNameCheckBox = new CheckBox();
            label15 = new Label();
            label16 = new Label();
            searchFirstNameTextBox = new TextBox();
            searchLastNameTextBox = new TextBox();
            panel7 = new Panel();
            label17 = new Label();
            panel8 = new Panel();
            nurseNameTextBox = new TextBox();
            order_test_button = new Button();
            finalDiagnosesTextBox = new TextBox();
            initialDiagnosesTextBox = new TextBox();
            final_diagnoses = new Label();
            initial_diagnoses_label = new Label();
            panel20 = new Panel();
            panel19 = new Panel();
            panel12 = new Panel();
            label18 = new Label();
            initial_diagnoses_enter_btn = new Button();
            final_diagnosis_enter_btn = new Button();
            orderTestDatePicker = new DateTimePicker();
            orderTestTimePicker = new DateTimePicker();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            testsOrderedListBox = new ListBox();
            testsOrderedDatePicker = new DateTimePicker();
            testsOrderedTimePicker = new DateTimePicker();
            allergyTestCheckBox = new CheckBox();
            bloodTestCheckBox = new CheckBox();
            cbcTestCheckBox = new CheckBox();
            glucoseTestCheckBox = new CheckBox();
            hormonePanelCheckBox = new CheckBox();
            lipidPanelCheckBox = new CheckBox();
            liverFunctionTestCheckBox = new CheckBox();
            urineTestCheckBox = new CheckBox();
            thyroidTestCheckBox = new CheckBox();
            vitaminDTestCheckBox = new CheckBox();
            deleteButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(578, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "Visits";
            // 
            // visitsListBox
            // 
            visitsListBox.Font = new Font("Segoe UI", 9F);
            visitsListBox.FormattingEnabled = true;
            visitsListBox.ItemHeight = 15;
            visitsListBox.Location = new Point(464, 99);
            visitsListBox.Name = "visitsListBox";
            visitsListBox.Size = new Size(270, 244);
            visitsListBox.TabIndex = 2;
            visitsListBox.SelectedIndexChanged += visitsListBox_SelectedIndexChanged;
            // 
            // visitDateTimePicker
            // 
            visitDateTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";
            visitDateTimePicker.Enabled = false;
            visitDateTimePicker.Font = new Font("Segoe UI", 12F);
            visitDateTimePicker.Format = DateTimePickerFormat.Custom;
            visitDateTimePicker.Location = new Point(1008, 67);
            visitDateTimePicker.Name = "visitDateTimePicker";
            visitDateTimePicker.Size = new Size(205, 29);
            visitDateTimePicker.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.IndianRed;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Showcard Gothic", 12F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(1173, 325);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(97, 32);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // bpmTextBox
            // 
            bpmTextBox.BorderStyle = BorderStyle.None;
            bpmTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            bpmTextBox.ForeColor = SystemColors.HotTrack;
            bpmTextBox.Location = new Point(933, 209);
            bpmTextBox.Name = "bpmTextBox";
            bpmTextBox.Size = new Size(57, 24);
            bpmTextBox.TabIndex = 8;
            bpmTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.IndianRed;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Showcard Gothic", 12F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(968, 325);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(97, 32);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // weightTextBox
            // 
            weightTextBox.BorderStyle = BorderStyle.None;
            weightTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            weightTextBox.ForeColor = SystemColors.HotTrack;
            weightTextBox.Location = new Point(1088, 129);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(60, 24);
            weightTextBox.TabIndex = 10;
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.BorderStyle = BorderStyle.None;
            temperatureTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            temperatureTextBox.ForeColor = SystemColors.HotTrack;
            temperatureTextBox.Location = new Point(933, 128);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(60, 24);
            temperatureTextBox.TabIndex = 11;
            temperatureTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            symptomsTextBox.ForeColor = SystemColors.HotTrack;
            symptomsTextBox.Location = new Point(1078, 213);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(362, 85);
            symptomsTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(795, 108);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 13;
            label2.Text = "Systolic";
            // 
            // diastolicTextBox
            // 
            diastolicTextBox.BorderStyle = BorderStyle.None;
            diastolicTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            diastolicTextBox.ForeColor = SystemColors.HotTrack;
            diastolicTextBox.Location = new Point(805, 213);
            diastolicTextBox.Name = "diastolicTextBox";
            diastolicTextBox.Size = new Size(50, 24);
            diastolicTextBox.TabIndex = 15;
            diastolicTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(797, 193);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 16;
            label3.Text = "Diastolic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(916, 108);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 17;
            label4.Text = "Temperature";
            // 
            // heightTextBox
            // 
            heightTextBox.BorderStyle = BorderStyle.None;
            heightTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            heightTextBox.ForeColor = SystemColors.HotTrack;
            heightTextBox.Location = new Point(1244, 128);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(60, 24);
            heightTextBox.TabIndex = 18;
            heightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(945, 193);
            label6.Name = "label6";
            label6.Size = new Size(40, 19);
            label6.TabIndex = 20;
            label6.Text = "BPM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1244, 108);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 21;
            label7.Text = "Height";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1213, 193);
            label8.Name = "label8";
            label8.Size = new Size(80, 19);
            label8.TabIndex = 23;
            label8.Text = "Symptoms";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1088, 108);
            label9.Name = "label9";
            label9.Size = new Size(57, 19);
            label9.TabIndex = 24;
            label9.Text = "Weight";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(1310, 130);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 25;
            label10.Text = "in";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(1154, 129);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 26;
            label11.Text = "lb";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.IndianRed;
            label12.Location = new Point(1022, 20);
            label12.Name = "label12";
            label12.Size = new Size(164, 25);
            label12.TabIndex = 27;
            label12.Text = "Routine Checkup";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1079, 46);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 28;
            label13.Text = "Date";
            // 
            // panel15
            // 
            panel15.BackColor = Color.IndianRed;
            panel15.Location = new Point(801, 156);
            panel15.Name = "panel15";
            panel15.Size = new Size(50, 1);
            panel15.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(933, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 1);
            panel1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(panel11);
            panel2.Location = new Point(1088, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(60, 1);
            panel2.TabIndex = 59;
            // 
            // panel11
            // 
            panel11.BackColor = Color.IndianRed;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(60, 1);
            panel11.TabIndex = 59;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(1244, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 1);
            panel3.TabIndex = 60;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(933, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(60, 1);
            panel4.TabIndex = 61;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(801, 156);
            panel10.Name = "panel10";
            panel10.Size = new Size(50, 1);
            panel10.TabIndex = 57;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(999, 130);
            label14.Name = "label14";
            label14.Size = new Size(24, 21);
            label14.TabIndex = 66;
            label14.Text = "°F";
            // 
            // systolicTextBox
            // 
            systolicTextBox.BorderStyle = BorderStyle.None;
            systolicTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            systolicTextBox.ForeColor = SystemColors.HotTrack;
            systolicTextBox.Location = new Point(803, 128);
            systolicTextBox.Name = "systolicTextBox";
            systolicTextBox.Size = new Size(52, 24);
            systolicTextBox.TabIndex = 67;
            systolicTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            successLabel.ForeColor = Color.FromArgb(0, 192, 0);
            successLabel.Location = new Point(795, 294);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(0, 13);
            successLabel.TabIndex = 68;
            // 
            // panel9
            // 
            panel9.BackColor = Color.IndianRed;
            panel9.Location = new Point(1088, 156);
            panel9.Name = "panel9";
            panel9.Size = new Size(60, 1);
            panel9.TabIndex = 59;
            // 
            // panel13
            // 
            panel13.BackColor = Color.IndianRed;
            panel13.Location = new Point(801, 156);
            panel13.Name = "panel13";
            panel13.Size = new Size(50, 1);
            panel13.TabIndex = 57;
            // 
            // panel14
            // 
            panel14.BackColor = Color.IndianRed;
            panel14.Location = new Point(801, 156);
            panel14.Name = "panel14";
            panel14.Size = new Size(50, 1);
            panel14.TabIndex = 57;
            // 
            // panel16
            // 
            panel16.BackColor = Color.IndianRed;
            panel16.Location = new Point(805, 239);
            panel16.Name = "panel16";
            panel16.Size = new Size(50, 1);
            panel16.TabIndex = 58;
            // 
            // panel17
            // 
            panel17.BackColor = Color.IndianRed;
            panel17.Location = new Point(805, 239);
            panel17.Name = "panel17";
            panel17.Size = new Size(50, 1);
            panel17.TabIndex = 59;
            // 
            // panel18
            // 
            panel18.BackColor = Color.IndianRed;
            panel18.Location = new Point(768, 20);
            panel18.Name = "panel18";
            panel18.Size = new Size(1, 329);
            panel18.TabIndex = 69;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(146, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 1);
            panel5.TabIndex = 77;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(146, 131);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 1);
            panel6.TabIndex = 78;
            // 
            // resetSearchButton
            // 
            resetSearchButton.BackColor = Color.IndianRed;
            resetSearchButton.Enabled = false;
            resetSearchButton.FlatStyle = FlatStyle.Flat;
            resetSearchButton.Font = new Font("Showcard Gothic", 9F);
            resetSearchButton.ForeColor = Color.White;
            resetSearchButton.Location = new Point(290, 233);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new Size(100, 33);
            resetSearchButton.TabIndex = 76;
            resetSearchButton.Text = "Reset";
            resetSearchButton.UseVisualStyleBackColor = false;
            resetSearchButton.Click += resetSearchButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.IndianRed;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Showcard Gothic", 9F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(146, 233);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 33);
            searchButton.TabIndex = 75;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchByNameCheckBox
            // 
            searchByNameCheckBox.AutoSize = true;
            searchByNameCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            searchByNameCheckBox.Location = new Point(146, 40);
            searchByNameCheckBox.Name = "searchByNameCheckBox";
            searchByNameCheckBox.Size = new Size(113, 19);
            searchByNameCheckBox.TabIndex = 74;
            searchByNameCheckBox.Text = "Search by Name";
            searchByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.Location = new Point(146, 179);
            label15.Name = "label15";
            label15.Size = new Size(63, 15);
            label15.TabIndex = 73;
            label15.Text = "Last Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.Location = new Point(146, 99);
            label16.Name = "label16";
            label16.Size = new Size(64, 15);
            label16.TabIndex = 72;
            label16.Text = "First Name";
            // 
            // searchFirstNameTextBox
            // 
            searchFirstNameTextBox.BorderStyle = BorderStyle.None;
            searchFirstNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchFirstNameTextBox.ForeColor = SystemColors.HotTrack;
            searchFirstNameTextBox.Location = new Point(218, 99);
            searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            searchFirstNameTextBox.Size = new Size(172, 17);
            searchFirstNameTextBox.TabIndex = 71;
            // 
            // searchLastNameTextBox
            // 
            searchLastNameTextBox.BorderStyle = BorderStyle.None;
            searchLastNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchLastNameTextBox.ForeColor = SystemColors.HotTrack;
            searchLastNameTextBox.Location = new Point(215, 179);
            searchLastNameTextBox.Name = "searchLastNameTextBox";
            searchLastNameTextBox.Size = new Size(175, 17);
            searchLastNameTextBox.TabIndex = 70;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(423, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 329);
            panel7.TabIndex = 70;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(840, 24);
            label17.Name = "label17";
            label17.Size = new Size(103, 19);
            label17.TabIndex = 79;
            label17.Text = "Performed By";
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(805, 70);
            panel8.Name = "panel8";
            panel8.Size = new Size(167, 1);
            panel8.TabIndex = 80;
            // 
            // nurseNameTextBox
            // 
            nurseNameTextBox.BorderStyle = BorderStyle.None;
            nurseNameTextBox.Enabled = false;
            nurseNameTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            nurseNameTextBox.ForeColor = SystemColors.HotTrack;
            nurseNameTextBox.Location = new Point(805, 46);
            nurseNameTextBox.Name = "nurseNameTextBox";
            nurseNameTextBox.ReadOnly = true;
            nurseNameTextBox.Size = new Size(167, 21);
            nurseNameTextBox.TabIndex = 81;
            nurseNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // order_test_button
            // 
            order_test_button.BackColor = Color.IndianRed;
            order_test_button.Enabled = false;
            order_test_button.FlatStyle = FlatStyle.Flat;
            order_test_button.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            order_test_button.ForeColor = Color.White;
            order_test_button.Location = new Point(907, 428);
            order_test_button.Name = "order_test_button";
            order_test_button.Size = new Size(83, 36);
            order_test_button.TabIndex = 95;
            order_test_button.Text = "Order";
            order_test_button.UseVisualStyleBackColor = false;
            order_test_button.Click += order_test_button_Click;
            // 
            // finalDiagnosesTextBox
            // 
            finalDiagnosesTextBox.Enabled = false;
            finalDiagnosesTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            finalDiagnosesTextBox.ForeColor = SystemColors.HotTrack;
            finalDiagnosesTextBox.Location = new Point(170, 625);
            finalDiagnosesTextBox.Multiline = true;
            finalDiagnosesTextBox.Name = "finalDiagnosesTextBox";
            finalDiagnosesTextBox.Size = new Size(220, 108);
            finalDiagnosesTextBox.TabIndex = 94;
            // 
            // initialDiagnosesTextBox
            // 
            initialDiagnosesTextBox.Enabled = false;
            initialDiagnosesTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            initialDiagnosesTextBox.ForeColor = SystemColors.HotTrack;
            initialDiagnosesTextBox.Location = new Point(170, 435);
            initialDiagnosesTextBox.Multiline = true;
            initialDiagnosesTextBox.Name = "initialDiagnosesTextBox";
            initialDiagnosesTextBox.Size = new Size(220, 108);
            initialDiagnosesTextBox.TabIndex = 93;
            // 
            // final_diagnoses
            // 
            final_diagnoses.AutoSize = true;
            final_diagnoses.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            final_diagnoses.ForeColor = Color.IndianRed;
            final_diagnoses.Location = new Point(204, 597);
            final_diagnoses.Name = "final_diagnoses";
            final_diagnoses.Size = new Size(150, 25);
            final_diagnoses.TabIndex = 92;
            final_diagnoses.Text = "Final Diagnoses";
            // 
            // initial_diagnoses_label
            // 
            initial_diagnoses_label.AutoSize = true;
            initial_diagnoses_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            initial_diagnoses_label.ForeColor = Color.IndianRed;
            initial_diagnoses_label.Location = new Point(204, 404);
            initial_diagnoses_label.Name = "initial_diagnoses_label";
            initial_diagnoses_label.Size = new Size(158, 25);
            initial_diagnoses_label.TabIndex = 91;
            initial_diagnoses_label.Text = "Initial Diagnoses";
            // 
            // panel20
            // 
            panel20.BackColor = Color.IndianRed;
            panel20.Location = new Point(1183, 423);
            panel20.Name = "panel20";
            panel20.Size = new Size(1, 350);
            panel20.TabIndex = 90;
            // 
            // panel19
            // 
            panel19.BackColor = Color.IndianRed;
            panel19.Location = new Point(422, 423);
            panel19.Name = "panel19";
            panel19.Size = new Size(1, 350);
            panel19.TabIndex = 88;
            // 
            // panel12
            // 
            panel12.BackColor = Color.IndianRed;
            panel12.Location = new Point(145, 382);
            panel12.Name = "panel12";
            panel12.Size = new Size(1335, 1);
            panel12.TabIndex = 89;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label18.ForeColor = Color.IndianRed;
            label18.Location = new Point(724, 397);
            label18.Name = "label18";
            label18.Size = new Size(111, 25);
            label18.TabIndex = 106;
            label18.Text = "Order Tests";
            // 
            // initial_diagnoses_enter_btn
            // 
            initial_diagnoses_enter_btn.BackColor = Color.IndianRed;
            initial_diagnoses_enter_btn.FlatStyle = FlatStyle.Flat;
            initial_diagnoses_enter_btn.Font = new Font("Showcard Gothic", 12F);
            initial_diagnoses_enter_btn.ForeColor = Color.White;
            initial_diagnoses_enter_btn.Location = new Point(236, 549);
            initial_diagnoses_enter_btn.Name = "initial_diagnoses_enter_btn";
            initial_diagnoses_enter_btn.Size = new Size(75, 33);
            initial_diagnoses_enter_btn.TabIndex = 108;
            initial_diagnoses_enter_btn.Text = "Enter";
            initial_diagnoses_enter_btn.UseVisualStyleBackColor = false;
            initial_diagnoses_enter_btn.Click += initial_diagnoses_enter_btn_Click;
            // 
            // final_diagnosis_enter_btn
            // 
            final_diagnosis_enter_btn.BackColor = Color.IndianRed;
            final_diagnosis_enter_btn.FlatStyle = FlatStyle.Flat;
            final_diagnosis_enter_btn.Font = new Font("Showcard Gothic", 12F);
            final_diagnosis_enter_btn.ForeColor = Color.White;
            final_diagnosis_enter_btn.Location = new Point(236, 739);
            final_diagnosis_enter_btn.Name = "final_diagnosis_enter_btn";
            final_diagnosis_enter_btn.Size = new Size(75, 33);
            final_diagnosis_enter_btn.TabIndex = 109;
            final_diagnosis_enter_btn.Text = "Enter";
            final_diagnosis_enter_btn.UseVisualStyleBackColor = false;
            final_diagnosis_enter_btn.Click += final_diagnosis_enter_btn_Click;
            // 
            // orderTestDatePicker
            // 
            orderTestDatePicker.CustomFormat = "";
            orderTestDatePicker.Font = new Font("Segoe UI", 12F);
            orderTestDatePicker.Location = new Point(502, 435);
            orderTestDatePicker.Name = "orderTestDatePicker";
            orderTestDatePicker.Size = new Size(267, 29);
            orderTestDatePicker.TabIndex = 110;
            // 
            // orderTestTimePicker
            // 
            orderTestTimePicker.CustomFormat = "hh:mm tt";
            orderTestTimePicker.Font = new Font("Segoe UI", 12F);
            orderTestTimePicker.Format = DateTimePickerFormat.Custom;
            orderTestTimePicker.Location = new Point(784, 435);
            orderTestTimePicker.Name = "orderTestTimePicker";
            orderTestTimePicker.ShowUpDown = true;
            orderTestTimePicker.Size = new Size(89, 29);
            orderTestTimePicker.TabIndex = 111;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(443, 435);
            label19.Name = "label19";
            label19.Size = new Size(53, 25);
            label19.TabIndex = 112;
            label19.Text = "Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label20.ForeColor = Color.IndianRed;
            label20.Location = new Point(467, 77);
            label20.Name = "label20";
            label20.Size = new Size(267, 19);
            label20.TabIndex = 113;
            label20.Text = "{Patient Name} {DOB} | {Doctor Name}";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(569, 56);
            label21.Name = "label21";
            label21.Size = new Size(60, 20);
            label21.TabIndex = 114;
            label21.Text = "Format";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label22.ForeColor = Color.IndianRed;
            label22.Location = new Point(1286, 397);
            label22.Name = "label22";
            label22.Size = new Size(133, 25);
            label22.TabIndex = 128;
            label22.Text = "Tests Ordered";
            // 
            // testsOrderedListBox
            // 
            testsOrderedListBox.Font = new Font("Segoe UI", 11F);
            testsOrderedListBox.FormattingEnabled = true;
            testsOrderedListBox.ItemHeight = 20;
            testsOrderedListBox.Location = new Point(1213, 435);
            testsOrderedListBox.Name = "testsOrderedListBox";
            testsOrderedListBox.Size = new Size(267, 204);
            testsOrderedListBox.TabIndex = 129;
            testsOrderedListBox.SelectedIndexChanged += testsOrderedListBox_SelectedIndexChanged;
            // 
            // testsOrderedDatePicker
            // 
            testsOrderedDatePicker.CustomFormat = "";
            testsOrderedDatePicker.Enabled = false;
            testsOrderedDatePicker.Font = new Font("Segoe UI", 12F);
            testsOrderedDatePicker.Location = new Point(1213, 653);
            testsOrderedDatePicker.Name = "testsOrderedDatePicker";
            testsOrderedDatePicker.Size = new Size(267, 29);
            testsOrderedDatePicker.TabIndex = 130;
            // 
            // testsOrderedTimePicker
            // 
            testsOrderedTimePicker.CustomFormat = "hh:mm tt";
            testsOrderedTimePicker.Enabled = false;
            testsOrderedTimePicker.Font = new Font("Segoe UI", 12F);
            testsOrderedTimePicker.Format = DateTimePickerFormat.Custom;
            testsOrderedTimePicker.Location = new Point(1307, 688);
            testsOrderedTimePicker.Name = "testsOrderedTimePicker";
            testsOrderedTimePicker.ShowUpDown = true;
            testsOrderedTimePicker.Size = new Size(89, 29);
            testsOrderedTimePicker.TabIndex = 131;
            // 
            // allergyTestCheckBox
            // 
            allergyTestCheckBox.AutoSize = true;
            allergyTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            allergyTestCheckBox.Location = new Point(444, 481);
            allergyTestCheckBox.Name = "allergyTestCheckBox";
            allergyTestCheckBox.Size = new Size(549, 24);
            allergyTestCheckBox.TabIndex = 132;
            allergyTestCheckBox.Text = "Allergy Test [AT008] - Identifies potential allergens causing allergic reactions.";
            allergyTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // bloodTestCheckBox
            // 
            bloodTestCheckBox.AutoSize = true;
            bloodTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            bloodTestCheckBox.Location = new Point(444, 511);
            bloodTestCheckBox.Name = "bloodTestCheckBox";
            bloodTestCheckBox.Size = new Size(723, 24);
            bloodTestCheckBox.TabIndex = 133;
            bloodTestCheckBox.Text = "Blood Test [BT001] - General term for tests analyzing blood components like hemoglobin and platelets.";
            bloodTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // cbcTestCheckBox
            // 
            cbcTestCheckBox.AutoSize = true;
            cbcTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cbcTestCheckBox.Location = new Point(444, 541);
            cbcTestCheckBox.Name = "cbcTestCheckBox";
            cbcTestCheckBox.Size = new Size(637, 24);
            cbcTestCheckBox.TabIndex = 134;
            cbcTestCheckBox.Text = "CBC Test [CB007] - A complete blood count measuring red/white blood cells and platelets.";
            cbcTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // glucoseTestCheckBox
            // 
            glucoseTestCheckBox.AutoSize = true;
            glucoseTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            glucoseTestCheckBox.Location = new Point(444, 569);
            glucoseTestCheckBox.Name = "glucoseTestCheckBox";
            glucoseTestCheckBox.Size = new Size(530, 24);
            glucoseTestCheckBox.TabIndex = 135;
            glucoseTestCheckBox.Text = "Glucose Test [GT003] - Measures blood sugar levels to assess diabetes risk.";
            glucoseTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // hormonePanelCheckBox
            // 
            hormonePanelCheckBox.AutoSize = true;
            hormonePanelCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            hormonePanelCheckBox.Location = new Point(444, 599);
            hormonePanelCheckBox.Name = "hormonePanelCheckBox";
            hormonePanelCheckBox.Size = new Size(665, 24);
            hormonePanelCheckBox.TabIndex = 136;
            hormonePanelCheckBox.Text = "Hormone Panel [HP009] - Evaluates hormone levels for issues like thyroid function or fertility.";
            hormonePanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // lipidPanelCheckBox
            // 
            lipidPanelCheckBox.AutoSize = true;
            lipidPanelCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lipidPanelCheckBox.Location = new Point(444, 629);
            lipidPanelCheckBox.Name = "lipidPanelCheckBox";
            lipidPanelCheckBox.Size = new Size(587, 24);
            lipidPanelCheckBox.TabIndex = 137;
            lipidPanelCheckBox.Text = "Lipid Panel [LP004] - Measures cholesterol and triglycerides to assess heart health.";
            lipidPanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // liverFunctionTestCheckBox
            // 
            liverFunctionTestCheckBox.AutoSize = true;
            liverFunctionTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            liverFunctionTestCheckBox.Location = new Point(444, 659);
            liverFunctionTestCheckBox.Name = "liverFunctionTestCheckBox";
            liverFunctionTestCheckBox.Size = new Size(620, 24);
            liverFunctionTestCheckBox.TabIndex = 138;
            liverFunctionTestCheckBox.Text = "Liver Function Test [LF010] - Checks enzymes and proteins for liver health and function.";
            liverFunctionTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // urineTestCheckBox
            // 
            urineTestCheckBox.AutoSize = true;
            urineTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            urineTestCheckBox.Location = new Point(444, 689);
            urineTestCheckBox.Name = "urineTestCheckBox";
            urineTestCheckBox.Size = new Size(635, 24);
            urineTestCheckBox.TabIndex = 139;
            urineTestCheckBox.Text = "Urine Test [UT002] - Examines urine for infections, kidney issues, or metabolic conditions.";
            urineTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // thyroidTestCheckBox
            // 
            thyroidTestCheckBox.AutoSize = true;
            thyroidTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            thyroidTestCheckBox.Location = new Point(444, 750);
            thyroidTestCheckBox.Name = "thyroidTestCheckBox";
            thyroidTestCheckBox.Size = new Size(700, 24);
            thyroidTestCheckBox.TabIndex = 140;
            thyroidTestCheckBox.Text = "Thyroid Test [TT005] - Assesses thyroid gland performance by measuring TSH and other hormones.";
            thyroidTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // vitaminDTestCheckBox
            // 
            vitaminDTestCheckBox.AutoSize = true;
            vitaminDTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            vitaminDTestCheckBox.Location = new Point(444, 720);
            vitaminDTestCheckBox.Name = "vitaminDTestCheckBox";
            vitaminDTestCheckBox.Size = new Size(659, 24);
            vitaminDTestCheckBox.TabIndex = 141;
            vitaminDTestCheckBox.Text = "Vitamin D Test [VD006] - Measures vitamin D levels to evaluate bone health and deficiencies.";
            vitaminDTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Enabled = false;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(1300, 736);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(101, 36);
            deleteButton.TabIndex = 142;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // ManageVisits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1508, 796);
            Controls.Add(deleteButton);
            Controls.Add(vitaminDTestCheckBox);
            Controls.Add(thyroidTestCheckBox);
            Controls.Add(urineTestCheckBox);
            Controls.Add(liverFunctionTestCheckBox);
            Controls.Add(lipidPanelCheckBox);
            Controls.Add(hormonePanelCheckBox);
            Controls.Add(glucoseTestCheckBox);
            Controls.Add(cbcTestCheckBox);
            Controls.Add(bloodTestCheckBox);
            Controls.Add(allergyTestCheckBox);
            Controls.Add(testsOrderedTimePicker);
            Controls.Add(testsOrderedDatePicker);
            Controls.Add(testsOrderedListBox);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(orderTestTimePicker);
            Controls.Add(orderTestDatePicker);
            Controls.Add(final_diagnosis_enter_btn);
            Controls.Add(initial_diagnoses_enter_btn);
            Controls.Add(label18);
            Controls.Add(order_test_button);
            Controls.Add(finalDiagnosesTextBox);
            Controls.Add(initialDiagnosesTextBox);
            Controls.Add(final_diagnoses);
            Controls.Add(initial_diagnoses_label);
            Controls.Add(panel20);
            Controls.Add(panel19);
            Controls.Add(panel12);
            Controls.Add(nurseNameTextBox);
            Controls.Add(panel8);
            Controls.Add(label17);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(resetSearchButton);
            Controls.Add(searchButton);
            Controls.Add(searchByNameCheckBox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(searchFirstNameTextBox);
            Controls.Add(searchLastNameTextBox);
            Controls.Add(panel18);
            Controls.Add(panel16);
            Controls.Add(panel17);
            Controls.Add(successLabel);
            Controls.Add(systolicTextBox);
            Controls.Add(label14);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel10);
            Controls.Add(panel15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(heightTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(diastolicTextBox);
            Controls.Add(label2);
            Controls.Add(symptomsTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(temperatureTextBox);
            Controls.Add(clearButton);
            Controls.Add(bpmTextBox);
            Controls.Add(saveButton);
            Controls.Add(visitDateTimePicker);
            Controls.Add(label1);
            Controls.Add(visitsListBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ManageVisits";
            Text = "ManageVisits";
            Load += ManageVisits_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox visitsListBox;
        private DateTimePicker visitDateTimePicker;
        private Button saveButton;
        private TextBox bpmTextBox;
        private Button clearButton;
        private TextBox temperatureTextBox;
        private TextBox symptomsTextBox;
        private Label label2;
        private TextBox diastolicTextBox;
        private Label label3;
        private Label label4;
        private TextBox heightTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panel15;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel10;
        private Label label14;
        private TextBox systolicTextBox;
        private Label successLabel;
        private Panel panel11;
        private TextBox weightTextBox;
        private Panel panel9;
        private Panel panel13;
        private Panel panel14;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel5;
        private Panel panel6;
        private Button resetSearchButton;
        private Button searchButton;
        private CheckBox searchByNameCheckBox;
        private Label label15;
        private Label label16;
        private TextBox searchFirstNameTextBox;
        private TextBox searchLastNameTextBox;
        private Panel panel7;
        private Label label17;
        private Panel panel8;
        private TextBox nurseNameTextBox;
        private Button order_test_button;
        private TextBox finalDiagnosesTextBox;
        private TextBox initialDiagnosesTextBox;
        private Label final_diagnoses;
        private Label initial_diagnoses_label;
        private Panel panel20;
        private Panel panel19;
        private Panel panel12;
        private CheckBox hormone_panel_checkBox;
        private CheckBox lipid_panel_checkBox;
        private CheckBox liver_function_test_checkBox;
        private CheckBox thyroid_test_checkBox;
        private CheckBox urine_test_checkBox;
        private CheckBox vitamin_d_test_checkBox;
        private Label label18;
        private Button initial_diagnoses_enter_btn;
        private Button final_diagnosis_enter_btn;
        private DateTimePicker orderTestDatePicker;
        private DateTimePicker orderTestTimePicker;
        private Label label19;
        private Label label20;
        private Label label21;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label22;
        private ListBox testsOrderedListBox;
        private DateTimePicker testsOrderedDatePicker;
        private DateTimePicker testsOrderedTimePicker;
        private CheckBox allergyTestCheckBox;
        private CheckBox bloodTestCheckBox;
        private CheckBox cbcTestCheckBox;
        private CheckBox glucoseTestCheckBox;
        private CheckBox hormonePanelCheckBox;
        private CheckBox lipidPanelCheckBox;
        private CheckBox liverFunctionTestCheckBox;
        private CheckBox urineTestCheckBox;
        private CheckBox thyroidTestCheckBox;
        private CheckBox vitaminDTestCheckBox;
        private Button deleteButton;
    }
}