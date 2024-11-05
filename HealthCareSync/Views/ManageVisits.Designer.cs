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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(142, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 38);
            label1.TabIndex = 3;
            label1.Text = "Visits";
            // 
            // visitsListBox
            // 
            visitsListBox.Font = new Font("Segoe UI", 12F);
            visitsListBox.FormattingEnabled = true;
            visitsListBox.ItemHeight = 32;
            visitsListBox.Location = new Point(72, 68);
            visitsListBox.Margin = new Padding(4, 5, 4, 5);
            visitsListBox.Name = "visitsListBox";
            visitsListBox.Size = new Size(250, 324);
            visitsListBox.TabIndex = 2;
            visitsListBox.SelectedIndexChanged += visitsListBox_SelectedIndexChanged;
            // 
            // visitDateTimePicker
            // 
            visitDateTimePicker.CustomFormat = "MM/dd/yyyy   hh:mm tt";
            visitDateTimePicker.Enabled = false;
            visitDateTimePicker.Font = new Font("Segoe UI", 12F);
            visitDateTimePicker.Format = DateTimePickerFormat.Custom;
            visitDateTimePicker.Location = new Point(683, 103);
            visitDateTimePicker.Margin = new Padding(4, 5, 4, 5);
            visitDateTimePicker.Name = "visitDateTimePicker";
            visitDateTimePicker.Size = new Size(291, 39);
            visitDateTimePicker.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.IndianRed;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Showcard Gothic", 12F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(918, 533);
            saveButton.Margin = new Padding(4, 5, 4, 5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(139, 54);
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
            bpmTextBox.Location = new Point(576, 340);
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
            clearButton.Location = new Point(626, 533);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(139, 54);
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
            weightTextBox.Location = new Point(797, 207);
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
            temperatureTextBox.Location = new Point(576, 205);
            temperatureTextBox.Margin = new Padding(4, 5, 4, 5);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(86, 36);
            temperatureTextBox.TabIndex = 11;
            temperatureTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.BorderStyle = BorderStyle.FixedSingle;
            symptomsTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            symptomsTextBox.ForeColor = SystemColors.HotTrack;
            symptomsTextBox.Location = new Point(783, 347);
            symptomsTextBox.Margin = new Padding(4, 5, 4, 5);
            symptomsTextBox.Multiline = true;
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(517, 141);
            symptomsTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 13;
            label2.Text = "Systolic";
            // 
            // appointmentIdTextBox
            // 
            appointmentIdTextBox.Enabled = false;
            appointmentIdTextBox.Font = new Font("Segoe UI Semibold", 12F);
            appointmentIdTextBox.Location = new Point(111, 430);
            appointmentIdTextBox.Margin = new Padding(4, 5, 4, 5);
            appointmentIdTextBox.Name = "appointmentIdTextBox";
            appointmentIdTextBox.Size = new Size(141, 39);
            appointmentIdTextBox.TabIndex = 14;
            appointmentIdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // diastolicTextBox
            // 
            diastolicTextBox.BorderStyle = BorderStyle.None;
            diastolicTextBox.Font = new Font("Microsoft YaHei UI", 14F);
            diastolicTextBox.ForeColor = SystemColors.HotTrack;
            diastolicTextBox.Location = new Point(393, 347);
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
            label3.Location = new Point(381, 314);
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
            label4.Location = new Point(551, 172);
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
            heightTextBox.Location = new Point(1020, 205);
            heightTextBox.Margin = new Padding(4, 5, 4, 5);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(86, 36);
            heightTextBox.TabIndex = 18;
            heightTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 397);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 19;
            label5.Text = "Appointment Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(593, 314);
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
            label7.Location = new Point(1020, 172);
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
            label8.Location = new Point(976, 314);
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
            label9.Location = new Point(797, 172);
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
            label10.Location = new Point(1114, 209);
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
            label11.Location = new Point(891, 207);
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
            label12.Location = new Point(703, 25);
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
            label13.Location = new Point(784, 68);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(62, 30);
            label13.TabIndex = 28;
            label13.Text = "Date";
            // 
            // panel15
            // 
            panel15.BackColor = Color.IndianRed;
            panel15.Location = new Point(379, 251);
            panel15.Margin = new Padding(4, 5, 4, 5);
            panel15.Name = "panel15";
            panel15.Size = new Size(71, 2);
            panel15.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(576, 251);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 2);
            panel1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(panel11);
            panel2.Location = new Point(797, 251);
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
            panel3.Location = new Point(1020, 251);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(86, 2);
            panel3.TabIndex = 60;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(576, 390);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(86, 2);
            panel4.TabIndex = 61;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(379, 251);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(71, 2);
            panel10.TabIndex = 57;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(670, 209);
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
            systolicTextBox.Location = new Point(381, 205);
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
            successLabel.Location = new Point(532, 458);
            successLabel.Margin = new Padding(4, 0, 4, 0);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(0, 21);
            successLabel.TabIndex = 68;
            // 
            // panel9
            // 
            panel9.BackColor = Color.IndianRed;
            panel9.Location = new Point(797, 251);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(86, 2);
            panel9.TabIndex = 59;
            // 
            // panel13
            // 
            panel13.BackColor = Color.IndianRed;
            panel13.Location = new Point(379, 251);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(71, 2);
            panel13.TabIndex = 57;
            // 
            // panel14
            // 
            panel14.BackColor = Color.IndianRed;
            panel14.Location = new Point(379, 251);
            panel14.Margin = new Padding(4, 5, 4, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(71, 2);
            panel14.TabIndex = 57;
            // 
            // panel16
            // 
            panel16.BackColor = Color.IndianRed;
            panel16.Location = new Point(393, 390);
            panel16.Margin = new Padding(4, 5, 4, 5);
            panel16.Name = "panel16";
            panel16.Size = new Size(71, 2);
            panel16.TabIndex = 58;
            // 
            // panel17
            // 
            panel17.BackColor = Color.IndianRed;
            panel17.Location = new Point(393, 390);
            panel17.Margin = new Padding(4, 5, 4, 5);
            panel17.Name = "panel17";
            panel17.Size = new Size(71, 2);
            panel17.TabIndex = 59;
            // 
            // panel18
            // 
            panel18.BackColor = Color.IndianRed;
            panel18.Location = new Point(341, 25);
            panel18.Margin = new Padding(4, 5, 4, 5);
            panel18.Name = "panel18";
            panel18.Size = new Size(1, 549);
            panel18.TabIndex = 69;
            // 
            // ManageVisits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 615);
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
    }
}