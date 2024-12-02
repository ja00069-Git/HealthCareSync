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
            tabControl = new TabControl();
            routineChecktabPage = new TabPage();
            testAndDiagnosticstabPage = new TabPage();
            panel2.SuspendLayout();
            tabControl.SuspendLayout();
            routineChecktabPage.SuspendLayout();
            testAndDiagnosticstabPage.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(522, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 38);
            label1.TabIndex = 3;
            label1.Text = "Visits";
            // 
            // visitsListBox
            // 
            visitsListBox.Font = new Font("Segoe UI", 9F);
            visitsListBox.FormattingEnabled = true;
            visitsListBox.ItemHeight = 25;
            visitsListBox.Location = new Point(359, 152);
            visitsListBox.Margin = new Padding(4, 5, 4, 5);
            visitsListBox.Name = "visitsListBox";
            visitsListBox.Size = new Size(384, 379);
            visitsListBox.TabIndex = 2;
            visitsListBox.SelectedIndexChanged += visitsListBox_SelectedIndexChanged;
            // 
            // visitDateTimePicker
            // 
            visitDateTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";
            visitDateTimePicker.Enabled = false;
            visitDateTimePicker.Font = new Font("Segoe UI", 12F);
            visitDateTimePicker.Format = DateTimePickerFormat.Custom;
            visitDateTimePicker.Location = new Point(997, 99);
            visitDateTimePicker.Margin = new Padding(4, 5, 4, 5);
            visitDateTimePicker.Name = "visitDateTimePicker";
            visitDateTimePicker.Size = new Size(275, 39);
            visitDateTimePicker.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.IndianRed;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Showcard Gothic", 12F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(1098, 511);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(139, 36);
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
            bpmTextBox.Location = new Point(913, 335);
            bpmTextBox.Margin = new Padding(4, 5, 4, 5);
            bpmTextBox.Name = "bpmTextBox";
            bpmTextBox.Size = new Size(81, 36);
            bpmTextBox.TabIndex = 8;
            bpmTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.IndianRed;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Showcard Gothic", 12F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(817, 511);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(139, 36);
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
            weightTextBox.Location = new Point(1074, 202);
            weightTextBox.Margin = new Padding(4, 5, 4, 5);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(86, 36);
            weightTextBox.TabIndex = 10;
            weightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.BorderStyle = BorderStyle.None;
            temperatureTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            temperatureTextBox.ForeColor = SystemColors.HotTrack;
            temperatureTextBox.Location = new Point(913, 200);
            temperatureTextBox.Margin = new Padding(4, 5, 4, 5);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(86, 36);
            temperatureTextBox.TabIndex = 11;
            temperatureTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            symptomsTextBox.ForeColor = SystemColors.HotTrack;
            symptomsTextBox.Location = new Point(1041, 370);
            symptomsTextBox.Margin = new Padding(4, 5, 4, 5);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(270, 113);
            symptomsTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(761, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 13;
            label2.Text = "Systolic";
            // 
            // diastolicTextBox
            // 
            diastolicTextBox.BorderStyle = BorderStyle.None;
            diastolicTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            diastolicTextBox.ForeColor = SystemColors.HotTrack;
            diastolicTextBox.Location = new Point(775, 342);
            diastolicTextBox.Margin = new Padding(4, 5, 4, 5);
            diastolicTextBox.Name = "diastolicTextBox";
            diastolicTextBox.Size = new Size(71, 36);
            diastolicTextBox.TabIndex = 15;
            diastolicTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(764, 309);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 16;
            label3.Text = "Diastolic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(889, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 17;
            label4.Text = "Temperature";
            // 
            // heightTextBox
            // 
            heightTextBox.BorderStyle = BorderStyle.None;
            heightTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            heightTextBox.ForeColor = SystemColors.HotTrack;
            heightTextBox.Location = new Point(1225, 200);
            heightTextBox.Margin = new Padding(4, 5, 4, 5);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(86, 36);
            heightTextBox.TabIndex = 18;
            heightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(930, 309);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 20;
            label6.Text = "BPM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(1225, 167);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 21;
            label7.Text = "Height";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1074, 309);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 28);
            label8.TabIndex = 23;
            label8.Text = "Symptoms";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1074, 167);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 24;
            label9.Text = "Weight";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(1871, 217);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(34, 32);
            label10.TabIndex = 25;
            label10.Text = "in";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(1169, 202);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(34, 32);
            label11.TabIndex = 26;
            label11.Text = "lb";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.IndianRed;
            label12.Location = new Point(1017, 20);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(239, 38);
            label12.TabIndex = 27;
            label12.Text = "Routine Checkup";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1098, 64);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 30);
            label13.TabIndex = 28;
            label13.Text = "Date";
            // 
            // panel15
            // 
            panel15.BackColor = Color.IndianRed;
            panel15.Location = new Point(769, 247);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(71, 2);
            panel15.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(913, 247);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 2);
            panel1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(panel11);
            panel2.Location = new Point(1074, 247);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(86, 2);
            panel2.TabIndex = 59;
            // 
            // panel11
            // 
            panel11.BackColor = Color.IndianRed;
            panel11.Location = new Point(0, 0);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(86, 2);
            panel11.TabIndex = 59;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(1225, 247);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(86, 2);
            panel3.TabIndex = 60;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(913, 385);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(86, 2);
            panel4.TabIndex = 61;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(769, 247);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(71, 2);
            panel10.TabIndex = 57;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(1007, 204);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(35, 32);
            label14.TabIndex = 66;
            label14.Text = "°F";
            // 
            // systolicTextBox
            // 
            systolicTextBox.BorderStyle = BorderStyle.None;
            systolicTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            systolicTextBox.ForeColor = SystemColors.HotTrack;
            systolicTextBox.Location = new Point(772, 200);
            systolicTextBox.Margin = new Padding(4, 5, 4, 5);
            systolicTextBox.Name = "systolicTextBox";
            systolicTextBox.Size = new Size(74, 36);
            systolicTextBox.TabIndex = 67;
            systolicTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            successLabel.ForeColor = Color.FromArgb(0, 192, 0);
            successLabel.Location = new Point(761, 477);
            successLabel.Margin = new Padding(4, 0, 4, 0);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(0, 21);
            successLabel.TabIndex = 68;
            // 
            // panel9
            // 
            panel9.BackColor = Color.IndianRed;
            panel9.Location = new Point(1074, 247);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(86, 2);
            panel9.TabIndex = 59;
            // 
            // panel13
            // 
            panel13.BackColor = Color.IndianRed;
            panel13.Location = new Point(769, 247);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(71, 2);
            panel13.TabIndex = 57;
            // 
            // panel14
            // 
            panel14.BackColor = Color.IndianRed;
            panel14.Location = new Point(769, 247);
            panel14.Margin = new Padding(4, 5, 4, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(71, 2);
            panel14.TabIndex = 57;
            // 
            // panel16
            // 
            panel16.BackColor = Color.IndianRed;
            panel16.Location = new Point(775, 385);
            panel16.Margin = new Padding(4, 5, 4, 5);
            panel16.Name = "panel16";
            panel16.Size = new Size(71, 2);
            panel16.TabIndex = 58;
            // 
            // panel17
            // 
            panel17.BackColor = Color.IndianRed;
            panel17.Location = new Point(775, 385);
            panel17.Margin = new Padding(4, 5, 4, 5);
            panel17.Name = "panel17";
            panel17.Size = new Size(71, 2);
            panel17.TabIndex = 59;
            // 
            // panel18
            // 
            panel18.BackColor = Color.IndianRed;
            panel18.Location = new Point(751, 12);
            panel18.Margin = new Padding(4, 5, 4, 5);
            panel18.Name = "panel18";
            panel18.Size = new Size(1, 535);
            panel18.TabIndex = 69;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(26, 349);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 2);
            panel5.TabIndex = 77;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(26, 215);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(286, 2);
            panel6.TabIndex = 78;
            // 
            // resetSearchButton
            // 
            resetSearchButton.BackColor = Color.IndianRed;
            resetSearchButton.Enabled = false;
            resetSearchButton.FlatStyle = FlatStyle.Flat;
            resetSearchButton.Font = new Font("Showcard Gothic", 9F);
            resetSearchButton.ForeColor = Color.White;
            resetSearchButton.Location = new Point(211, 404);
            resetSearchButton.Margin = new Padding(4, 5, 4, 5);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new Size(100, 36);
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
            searchButton.Location = new Point(26, 404);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(114, 36);
            searchButton.TabIndex = 75;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchByNameCheckBox
            // 
            searchByNameCheckBox.AutoSize = true;
            searchByNameCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            searchByNameCheckBox.Location = new Point(26, 64);
            searchByNameCheckBox.Margin = new Padding(4, 5, 4, 5);
            searchByNameCheckBox.Name = "searchByNameCheckBox";
            searchByNameCheckBox.Size = new Size(171, 29);
            searchByNameCheckBox.TabIndex = 74;
            searchByNameCheckBox.Text = "Search by Name";
            searchByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.Location = new Point(26, 295);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(99, 25);
            label15.TabIndex = 73;
            label15.Text = "Last Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.Location = new Point(26, 162);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 72;
            label16.Text = "First Name";
            // 
            // searchFirstNameTextBox
            // 
            searchFirstNameTextBox.BorderStyle = BorderStyle.None;
            searchFirstNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchFirstNameTextBox.ForeColor = SystemColors.HotTrack;
            searchFirstNameTextBox.Location = new Point(136, 162);
            searchFirstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            searchFirstNameTextBox.Size = new Size(175, 26);
            searchFirstNameTextBox.TabIndex = 71;
            // 
            // searchLastNameTextBox
            // 
            searchLastNameTextBox.BorderStyle = BorderStyle.None;
            searchLastNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchLastNameTextBox.ForeColor = SystemColors.HotTrack;
            searchLastNameTextBox.Location = new Point(133, 295);
            searchLastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            searchLastNameTextBox.Name = "searchLastNameTextBox";
            searchLastNameTextBox.Size = new Size(178, 26);
            searchLastNameTextBox.TabIndex = 70;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(349, 12);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 531);
            panel7.TabIndex = 70;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(790, 60);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(141, 28);
            label17.TabIndex = 79;
            label17.Text = "Performed By";
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(764, 136);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(192, 2);
            panel8.TabIndex = 80;
            // 
            // nurseNameTextBox
            // 
            nurseNameTextBox.BorderStyle = BorderStyle.None;
            nurseNameTextBox.Enabled = false;
            nurseNameTextBox.Font = new Font("Microsoft YaHei UI", 12F);
            nurseNameTextBox.ForeColor = SystemColors.HotTrack;
            nurseNameTextBox.Location = new Point(764, 96);
            nurseNameTextBox.Margin = new Padding(4, 5, 4, 5);
            nurseNameTextBox.Name = "nurseNameTextBox";
            nurseNameTextBox.ReadOnly = true;
            nurseNameTextBox.Size = new Size(192, 31);
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
            order_test_button.Location = new Point(672, 518);
            order_test_button.Margin = new Padding(4, 5, 4, 5);
            order_test_button.Name = "order_test_button";
            order_test_button.Size = new Size(119, 39);
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
            finalDiagnosesTextBox.Location = new Point(20, 331);
            finalDiagnosesTextBox.Margin = new Padding(4, 5, 4, 5);
            finalDiagnosesTextBox.Multiline = true;
            finalDiagnosesTextBox.Name = "finalDiagnosesTextBox";
            finalDiagnosesTextBox.Size = new Size(313, 177);
            finalDiagnosesTextBox.TabIndex = 94;
            // 
            // initialDiagnosesTextBox
            // 
            initialDiagnosesTextBox.Enabled = false;
            initialDiagnosesTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            initialDiagnosesTextBox.ForeColor = SystemColors.HotTrack;
            initialDiagnosesTextBox.Location = new Point(20, 56);
            initialDiagnosesTextBox.Margin = new Padding(4, 5, 4, 5);
            initialDiagnosesTextBox.Multiline = true;
            initialDiagnosesTextBox.Name = "initialDiagnosesTextBox";
            initialDiagnosesTextBox.Size = new Size(313, 177);
            initialDiagnosesTextBox.TabIndex = 93;
            // 
            // final_diagnoses
            // 
            final_diagnoses.AutoSize = true;
            final_diagnoses.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            final_diagnoses.ForeColor = Color.IndianRed;
            final_diagnoses.Location = new Point(85, 296);
            final_diagnoses.Margin = new Padding(4, 0, 4, 0);
            final_diagnoses.Name = "final_diagnoses";
            final_diagnoses.Size = new Size(173, 30);
            final_diagnoses.TabIndex = 92;
            final_diagnoses.Text = "Final Diagnoses";
            // 
            // initial_diagnoses_label
            // 
            initial_diagnoses_label.AutoSize = true;
            initial_diagnoses_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initial_diagnoses_label.ForeColor = Color.IndianRed;
            initial_diagnoses_label.Location = new Point(68, 21);
            initial_diagnoses_label.Margin = new Padding(4, 0, 4, 0);
            initial_diagnoses_label.Name = "initial_diagnoses_label";
            initial_diagnoses_label.Size = new Size(184, 30);
            initial_diagnoses_label.TabIndex = 91;
            initial_diagnoses_label.Text = "Initial Diagnoses";
            // 
            // panel20
            // 
            panel20.BackColor = Color.IndianRed;
            panel20.Location = new Point(1210, 49);
            panel20.Margin = new Padding(4, 5, 4, 5);
            panel20.Name = "panel20";
            panel20.Size = new Size(1, 583);
            panel20.TabIndex = 90;
            // 
            // panel19
            // 
            panel19.BackColor = Color.IndianRed;
            panel19.Location = new Point(352, 56);
            panel19.Margin = new Padding(4, 5, 4, 5);
            panel19.Name = "panel19";
            panel19.Size = new Size(1, 583);
            panel19.TabIndex = 88;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label18.ForeColor = Color.IndianRed;
            label18.Location = new Point(672, 21);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(163, 38);
            label18.TabIndex = 106;
            label18.Text = "Order Tests";
            // 
            // initial_diagnoses_enter_btn
            // 
            initial_diagnoses_enter_btn.BackColor = Color.IndianRed;
            initial_diagnoses_enter_btn.FlatStyle = FlatStyle.Flat;
            initial_diagnoses_enter_btn.Font = new Font("Showcard Gothic", 12F);
            initial_diagnoses_enter_btn.ForeColor = Color.White;
            initial_diagnoses_enter_btn.Location = new Point(114, 243);
            initial_diagnoses_enter_btn.Margin = new Padding(4, 5, 4, 5);
            initial_diagnoses_enter_btn.Name = "initial_diagnoses_enter_btn";
            initial_diagnoses_enter_btn.Size = new Size(107, 39);
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
            final_diagnosis_enter_btn.Location = new Point(114, 518);
            final_diagnosis_enter_btn.Margin = new Padding(4, 5, 4, 5);
            final_diagnosis_enter_btn.Name = "final_diagnosis_enter_btn";
            final_diagnosis_enter_btn.Size = new Size(107, 39);
            final_diagnosis_enter_btn.TabIndex = 109;
            final_diagnosis_enter_btn.Text = "Enter";
            final_diagnosis_enter_btn.UseVisualStyleBackColor = false;
            final_diagnosis_enter_btn.Click += final_diagnosis_enter_btn_Click;
            // 
            // orderTestDatePicker
            // 
            orderTestDatePicker.CustomFormat = "";
            orderTestDatePicker.Font = new Font("Segoe UI", 12F);
            orderTestDatePicker.Location = new Point(466, 76);
            orderTestDatePicker.Margin = new Padding(4, 5, 4, 5);
            orderTestDatePicker.Name = "orderTestDatePicker";
            orderTestDatePicker.Size = new Size(380, 39);
            orderTestDatePicker.TabIndex = 110;
            // 
            // orderTestTimePicker
            // 
            orderTestTimePicker.CustomFormat = "hh:mm tt";
            orderTestTimePicker.Font = new Font("Segoe UI", 12F);
            orderTestTimePicker.Format = DateTimePickerFormat.Custom;
            orderTestTimePicker.Location = new Point(869, 76);
            orderTestTimePicker.Margin = new Padding(4, 5, 4, 5);
            orderTestTimePicker.Name = "orderTestTimePicker";
            orderTestTimePicker.ShowUpDown = true;
            orderTestTimePicker.Size = new Size(125, 39);
            orderTestTimePicker.TabIndex = 111;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(382, 76);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(79, 38);
            label19.TabIndex = 112;
            label19.Text = "Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label20.ForeColor = Color.IndianRed;
            label20.Location = new Point(363, 115);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(379, 28);
            label20.TabIndex = 113;
            label20.Text = "{Patient Name} {DOB} | {Doctor Name}";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(509, 80);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(87, 30);
            label21.TabIndex = 114;
            label21.Text = "Format";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.White;
            label22.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label22.ForeColor = Color.IndianRed;
            label22.Location = new Point(1332, 56);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(195, 38);
            label22.TabIndex = 128;
            label22.Text = "Tests Ordered";
            // 
            // testsOrderedListBox
            // 
            testsOrderedListBox.Font = new Font("Segoe UI", 11F);
            testsOrderedListBox.FormattingEnabled = true;
            testsOrderedListBox.ItemHeight = 30;
            testsOrderedListBox.Location = new Point(1228, 119);
            testsOrderedListBox.Margin = new Padding(4, 5, 4, 5);
            testsOrderedListBox.Name = "testsOrderedListBox";
            testsOrderedListBox.Size = new Size(380, 334);
            testsOrderedListBox.TabIndex = 129;
            testsOrderedListBox.SelectedIndexChanged += testsOrderedListBox_SelectedIndexChanged;
            // 
            // testsOrderedDatePicker
            // 
            testsOrderedDatePicker.CustomFormat = "";
            testsOrderedDatePicker.Enabled = false;
            testsOrderedDatePicker.Font = new Font("Segoe UI", 12F);
            testsOrderedDatePicker.Location = new Point(1228, 482);
            testsOrderedDatePicker.Margin = new Padding(4, 5, 4, 5);
            testsOrderedDatePicker.Name = "testsOrderedDatePicker";
            testsOrderedDatePicker.Size = new Size(380, 39);
            testsOrderedDatePicker.TabIndex = 130;
            // 
            // testsOrderedTimePicker
            // 
            testsOrderedTimePicker.CustomFormat = "hh:mm tt";
            testsOrderedTimePicker.Enabled = false;
            testsOrderedTimePicker.Font = new Font("Segoe UI", 12F);
            testsOrderedTimePicker.Format = DateTimePickerFormat.Custom;
            testsOrderedTimePicker.Location = new Point(1867, 1147);
            testsOrderedTimePicker.Margin = new Padding(4, 5, 4, 5);
            testsOrderedTimePicker.Name = "testsOrderedTimePicker";
            testsOrderedTimePicker.ShowUpDown = true;
            testsOrderedTimePicker.Size = new Size(125, 39);
            testsOrderedTimePicker.TabIndex = 131;
            // 
            // allergyTestCheckBox
            // 
            allergyTestCheckBox.AutoSize = true;
            allergyTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allergyTestCheckBox.Location = new Point(372, 149);
            allergyTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            allergyTestCheckBox.Name = "allergyTestCheckBox";
            allergyTestCheckBox.Size = new Size(623, 25);
            allergyTestCheckBox.TabIndex = 132;
            allergyTestCheckBox.Text = "Allergy Test [AT008] - Identifies potential allergens causing allergic reactions.";
            allergyTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // bloodTestCheckBox
            // 
            bloodTestCheckBox.AutoSize = true;
            bloodTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bloodTestCheckBox.Location = new Point(372, 184);
            bloodTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            bloodTestCheckBox.Name = "bloodTestCheckBox";
            bloodTestCheckBox.Size = new Size(819, 25);
            bloodTestCheckBox.TabIndex = 133;
            bloodTestCheckBox.Text = "Blood Test [BT001] - General term for tests analyzing blood components like hemoglobin and platelets.";
            bloodTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // cbcTestCheckBox
            // 
            cbcTestCheckBox.AutoSize = true;
            cbcTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbcTestCheckBox.Location = new Point(372, 219);
            cbcTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            cbcTestCheckBox.Name = "cbcTestCheckBox";
            cbcTestCheckBox.Size = new Size(719, 25);
            cbcTestCheckBox.TabIndex = 134;
            cbcTestCheckBox.Text = "CBC Test [CB007] - A complete blood count measuring red/white blood cells and platelets.";
            cbcTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // glucoseTestCheckBox
            // 
            glucoseTestCheckBox.AutoSize = true;
            glucoseTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            glucoseTestCheckBox.Location = new Point(372, 254);
            glucoseTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            glucoseTestCheckBox.Name = "glucoseTestCheckBox";
            glucoseTestCheckBox.Size = new Size(597, 25);
            glucoseTestCheckBox.TabIndex = 135;
            glucoseTestCheckBox.Text = "Glucose Test [GT003] - Measures blood sugar levels to assess diabetes risk.";
            glucoseTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // hormonePanelCheckBox
            // 
            hormonePanelCheckBox.AutoSize = true;
            hormonePanelCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hormonePanelCheckBox.Location = new Point(372, 289);
            hormonePanelCheckBox.Margin = new Padding(4, 5, 4, 5);
            hormonePanelCheckBox.Name = "hormonePanelCheckBox";
            hormonePanelCheckBox.Size = new Size(749, 25);
            hormonePanelCheckBox.TabIndex = 136;
            hormonePanelCheckBox.Text = "Hormone Panel [HP009] - Evaluates hormone levels for issues like thyroid function or fertility.";
            hormonePanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // lipidPanelCheckBox
            // 
            lipidPanelCheckBox.AutoSize = true;
            lipidPanelCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lipidPanelCheckBox.Location = new Point(372, 324);
            lipidPanelCheckBox.Margin = new Padding(4, 5, 4, 5);
            lipidPanelCheckBox.Name = "lipidPanelCheckBox";
            lipidPanelCheckBox.Size = new Size(660, 25);
            lipidPanelCheckBox.TabIndex = 137;
            lipidPanelCheckBox.Text = "Lipid Panel [LP004] - Measures cholesterol and triglycerides to assess heart health.";
            lipidPanelCheckBox.UseVisualStyleBackColor = true;
            // 
            // liverFunctionTestCheckBox
            // 
            liverFunctionTestCheckBox.AutoSize = true;
            liverFunctionTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            liverFunctionTestCheckBox.Location = new Point(372, 359);
            liverFunctionTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            liverFunctionTestCheckBox.Name = "liverFunctionTestCheckBox";
            liverFunctionTestCheckBox.Size = new Size(698, 25);
            liverFunctionTestCheckBox.TabIndex = 138;
            liverFunctionTestCheckBox.Text = "Liver Function Test [LF010] - Checks enzymes and proteins for liver health and function.";
            liverFunctionTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // urineTestCheckBox
            // 
            urineTestCheckBox.AutoSize = true;
            urineTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            urineTestCheckBox.Location = new Point(372, 394);
            urineTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            urineTestCheckBox.Name = "urineTestCheckBox";
            urineTestCheckBox.Size = new Size(716, 25);
            urineTestCheckBox.TabIndex = 139;
            urineTestCheckBox.Text = "Urine Test [UT002] - Examines urine for infections, kidney issues, or metabolic conditions.";
            urineTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // thyroidTestCheckBox
            // 
            thyroidTestCheckBox.AutoSize = true;
            thyroidTestCheckBox.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            thyroidTestCheckBox.Location = new Point(634, 1250);
            thyroidTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            thyroidTestCheckBox.Name = "thyroidTestCheckBox";
            thyroidTestCheckBox.Size = new Size(1018, 34);
            thyroidTestCheckBox.TabIndex = 140;
            thyroidTestCheckBox.Text = "Thyroid Test [TT005] - Assesses thyroid gland performance by measuring TSH and other hormones.";
            thyroidTestCheckBox.UseVisualStyleBackColor = true;
            // 
            // vitaminDTestCheckBox
            // 
            vitaminDTestCheckBox.AutoSize = true;
            vitaminDTestCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vitaminDTestCheckBox.Location = new Point(372, 429);
            vitaminDTestCheckBox.Margin = new Padding(4, 5, 4, 5);
            vitaminDTestCheckBox.Name = "vitaminDTestCheckBox";
            vitaminDTestCheckBox.Size = new Size(744, 25);
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
            deleteButton.Location = new Point(1857, 1227);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(144, 60);
            deleteButton.TabIndex = 142;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(routineChecktabPage);
            tabControl.Controls.Add(testAndDiagnosticstabPage);
            tabControl.Location = new Point(72, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1333, 638);
            tabControl.TabIndex = 143;
            // 
            // routineChecktabPage
            // 
            routineChecktabPage.Controls.Add(panel5);
            routineChecktabPage.Controls.Add(visitsListBox);
            routineChecktabPage.Controls.Add(label1);
            routineChecktabPage.Controls.Add(panel18);
            routineChecktabPage.Controls.Add(searchLastNameTextBox);
            routineChecktabPage.Controls.Add(searchFirstNameTextBox);
            routineChecktabPage.Controls.Add(label16);
            routineChecktabPage.Controls.Add(label15);
            routineChecktabPage.Controls.Add(searchByNameCheckBox);
            routineChecktabPage.Controls.Add(searchButton);
            routineChecktabPage.Controls.Add(resetSearchButton);
            routineChecktabPage.Controls.Add(panel6);
            routineChecktabPage.Controls.Add(panel7);
            routineChecktabPage.Controls.Add(label20);
            routineChecktabPage.Controls.Add(label21);
            routineChecktabPage.Controls.Add(panel16);
            routineChecktabPage.Controls.Add(visitDateTimePicker);
            routineChecktabPage.Controls.Add(saveButton);
            routineChecktabPage.Controls.Add(bpmTextBox);
            routineChecktabPage.Controls.Add(clearButton);
            routineChecktabPage.Controls.Add(temperatureTextBox);
            routineChecktabPage.Controls.Add(weightTextBox);
            routineChecktabPage.Controls.Add(symptomsTextBox);
            routineChecktabPage.Controls.Add(label2);
            routineChecktabPage.Controls.Add(diastolicTextBox);
            routineChecktabPage.Controls.Add(label3);
            routineChecktabPage.Controls.Add(label4);
            routineChecktabPage.Controls.Add(heightTextBox);
            routineChecktabPage.Controls.Add(label6);
            routineChecktabPage.Controls.Add(label7);
            routineChecktabPage.Controls.Add(nurseNameTextBox);
            routineChecktabPage.Controls.Add(label8);
            routineChecktabPage.Controls.Add(panel8);
            routineChecktabPage.Controls.Add(label9);
            routineChecktabPage.Controls.Add(label17);
            routineChecktabPage.Controls.Add(label11);
            routineChecktabPage.Controls.Add(label12);
            routineChecktabPage.Controls.Add(panel17);
            routineChecktabPage.Controls.Add(label13);
            routineChecktabPage.Controls.Add(successLabel);
            routineChecktabPage.Controls.Add(panel15);
            routineChecktabPage.Controls.Add(systolicTextBox);
            routineChecktabPage.Controls.Add(panel10);
            routineChecktabPage.Controls.Add(label14);
            routineChecktabPage.Controls.Add(panel13);
            routineChecktabPage.Controls.Add(panel4);
            routineChecktabPage.Controls.Add(panel14);
            routineChecktabPage.Controls.Add(panel3);
            routineChecktabPage.Controls.Add(panel1);
            routineChecktabPage.Controls.Add(panel9);
            routineChecktabPage.Controls.Add(panel2);
            routineChecktabPage.Location = new Point(4, 34);
            routineChecktabPage.Name = "routineChecktabPage";
            routineChecktabPage.Padding = new Padding(3);
            routineChecktabPage.Size = new Size(1325, 577);
            routineChecktabPage.TabIndex = 0;
            routineChecktabPage.Text = "Routine Check Tab Page";
            routineChecktabPage.UseVisualStyleBackColor = true;
            // 
            // testAndDiagnosticstabPage
            // 
            testAndDiagnosticstabPage.AutoScroll = true;
            testAndDiagnosticstabPage.Controls.Add(initialDiagnosesTextBox);
            testAndDiagnosticstabPage.Controls.Add(initial_diagnoses_label);
            testAndDiagnosticstabPage.Controls.Add(vitaminDTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(final_diagnoses);
            testAndDiagnosticstabPage.Controls.Add(testsOrderedDatePicker);
            testAndDiagnosticstabPage.Controls.Add(finalDiagnosesTextBox);
            testAndDiagnosticstabPage.Controls.Add(testsOrderedListBox);
            testAndDiagnosticstabPage.Controls.Add(urineTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(label22);
            testAndDiagnosticstabPage.Controls.Add(initial_diagnoses_enter_btn);
            testAndDiagnosticstabPage.Controls.Add(liverFunctionTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(final_diagnosis_enter_btn);
            testAndDiagnosticstabPage.Controls.Add(lipidPanelCheckBox);
            testAndDiagnosticstabPage.Controls.Add(label18);
            testAndDiagnosticstabPage.Controls.Add(hormonePanelCheckBox);
            testAndDiagnosticstabPage.Controls.Add(panel19);
            testAndDiagnosticstabPage.Controls.Add(glucoseTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(panel20);
            testAndDiagnosticstabPage.Controls.Add(cbcTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(order_test_button);
            testAndDiagnosticstabPage.Controls.Add(bloodTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(orderTestDatePicker);
            testAndDiagnosticstabPage.Controls.Add(allergyTestCheckBox);
            testAndDiagnosticstabPage.Controls.Add(orderTestTimePicker);
            testAndDiagnosticstabPage.Controls.Add(label19);
            testAndDiagnosticstabPage.Location = new Point(4, 34);
            testAndDiagnosticstabPage.Name = "testAndDiagnosticstabPage";
            testAndDiagnosticstabPage.Padding = new Padding(3);
            testAndDiagnosticstabPage.Size = new Size(1325, 600);
            testAndDiagnosticstabPage.TabIndex = 1;
            testAndDiagnosticstabPage.Text = "Tests And Diagnostics tab Page";
            testAndDiagnosticstabPage.UseVisualStyleBackColor = true;
            // 
            // ManageVisits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1409, 634);
            Controls.Add(tabControl);
            Controls.Add(deleteButton);
            Controls.Add(thyroidTestCheckBox);
            Controls.Add(testsOrderedTimePicker);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageVisits";
            Text = "ManageVisits";
            Load += ManageVisits_Load;
            panel2.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            routineChecktabPage.ResumeLayout(false);
            routineChecktabPage.PerformLayout();
            testAndDiagnosticstabPage.ResumeLayout(false);
            testAndDiagnosticstabPage.PerformLayout();
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
        private TabControl tabControl;
        private TabPage routineChecktabPage;
        private TabPage testAndDiagnosticstabPage;
    }
}