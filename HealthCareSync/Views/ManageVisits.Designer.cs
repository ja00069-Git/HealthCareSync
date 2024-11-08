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
            appointmentIdTextBox = new TextBox();
            diastolicTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            heightTextBox = new TextBox();
            label5 = new Label();
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
            visitsListBox.Location = new Point(470, 40);
            visitsListBox.Name = "visitsListBox";
            visitsListBox.Size = new Size(270, 184);
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
            symptomsTextBox.Font = new Font("Microsoft YaHei UI", 14F);
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
            // appointmentIdTextBox
            // 
            appointmentIdTextBox.Enabled = false;
            appointmentIdTextBox.Font = new Font("Segoe UI Semibold", 12F);
            appointmentIdTextBox.Location = new Point(552, 256);
            appointmentIdTextBox.Name = "appointmentIdTextBox";
            appointmentIdTextBox.Size = new Size(100, 29);
            appointmentIdTextBox.TabIndex = 14;
            appointmentIdTextBox.TextAlign = HorizontalAlignment.Center;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(545, 236);
            label5.Name = "label5";
            label5.Size = new Size(114, 19);
            label5.TabIndex = 19;
            label5.Text = "Appointment Id";
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
            searchFirstNameTextBox.Location = new Point(254, 99);
            searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            searchFirstNameTextBox.Size = new Size(136, 17);
            searchFirstNameTextBox.TabIndex = 71;
            // 
            // searchLastNameTextBox
            // 
            searchLastNameTextBox.BorderStyle = BorderStyle.None;
            searchLastNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchLastNameTextBox.ForeColor = SystemColors.HotTrack;
            searchLastNameTextBox.Location = new Point(251, 179);
            searchLastNameTextBox.Name = "searchLastNameTextBox";
            searchLastNameTextBox.Size = new Size(139, 17);
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
            // ManageVisits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1469, 369);
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
            Controls.Add(label5);
            Controls.Add(heightTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(diastolicTextBox);
            Controls.Add(appointmentIdTextBox);
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
        private TextBox appointmentIdTextBox;
        private TextBox diastolicTextBox;
        private Label label3;
        private Label label4;
        private TextBox heightTextBox;
        private Label label5;
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
    }
}