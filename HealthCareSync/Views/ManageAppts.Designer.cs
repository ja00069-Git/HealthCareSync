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
            docTimesListBox = new ListBox();
            monthCalendar = new MonthCalendar();
            patientNameTBX = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            doctorsNameTBX = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            timeTBX = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            reasonTBX = new TextBox();
            panel4 = new Panel();
            scheduleBTN = new Button();
            EditBTN = new Button();
            appointments = new ListBox();
            searchTBX = new TextBox();
            panel5 = new Panel();
            searchBTN = new Button();
            searchErrorLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            clearBTN = new Button();
            patentNameErrorLabel = new Label();
            reasonLabel = new Label();
            SuspendLayout();
            // 
            // docTimesListBox
            // 
            docTimesListBox.BorderStyle = BorderStyle.FixedSingle;
            docTimesListBox.FormattingEnabled = true;
            docTimesListBox.ItemHeight = 25;
            docTimesListBox.Location = new Point(71, 267);
            docTimesListBox.Name = "docTimesListBox";
            docTimesListBox.Size = new Size(312, 177);
            docTimesListBox.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar.Location = new Point(71, -16);
            monthCalendar.Margin = new Padding(0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ScrollChange = 1;
            monthCalendar.ShowToday = false;
            monthCalendar.ShowTodayCircle = false;
            monthCalendar.TabIndex = 0;
            monthCalendar.TrailingForeColor = SystemColors.ActiveCaptionText;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // patientNameTBX
            // 
            patientNameTBX.BackColor = Color.White;
            patientNameTBX.BorderStyle = BorderStyle.None;
            patientNameTBX.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameTBX.ForeColor = SystemColors.HotTrack;
            patientNameTBX.Location = new Point(623, 12);
            patientNameTBX.Multiline = true;
            patientNameTBX.Name = "patientNameTBX";
            patientNameTBX.Size = new Size(165, 28);
            patientNameTBX.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(465, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 1);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(482, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 8;
            label1.Text = "Patient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(482, 95);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 11;
            label2.Text = "Doctor's Name:";
            // 
            // doctorsNameTBX
            // 
            doctorsNameTBX.BackColor = Color.White;
            doctorsNameTBX.BorderStyle = BorderStyle.None;
            doctorsNameTBX.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsNameTBX.ForeColor = SystemColors.HotTrack;
            doctorsNameTBX.Location = new Point(623, 95);
            doctorsNameTBX.Multiline = true;
            doctorsNameTBX.Name = "doctorsNameTBX";
            doctorsNameTBX.Size = new Size(165, 31);
            doctorsNameTBX.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(465, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 1);
            panel2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(482, 183);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 14;
            label3.Text = "Appt. Time:";
            // 
            // timeTBX
            // 
            timeTBX.BackColor = Color.White;
            timeTBX.BorderStyle = BorderStyle.None;
            timeTBX.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeTBX.ForeColor = SystemColors.HotTrack;
            timeTBX.Location = new Point(602, 182);
            timeTBX.Multiline = true;
            timeTBX.Name = "timeTBX";
            timeTBX.Size = new Size(193, 33);
            timeTBX.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.ForeColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(472, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 1);
            panel3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(482, 278);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 17;
            label4.Text = "Reason:";
            // 
            // reasonTBX
            // 
            reasonTBX.BackColor = Color.White;
            reasonTBX.BorderStyle = BorderStyle.None;
            reasonTBX.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reasonTBX.ForeColor = SystemColors.HotTrack;
            reasonTBX.Location = new Point(574, 277);
            reasonTBX.Multiline = true;
            reasonTBX.Name = "reasonTBX";
            reasonTBX.Size = new Size(214, 32);
            reasonTBX.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.ForeColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(472, 315);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 1);
            panel4.TabIndex = 16;
            // 
            // scheduleBTN
            // 
            scheduleBTN.BackColor = Color.IndianRed;
            scheduleBTN.FlatAppearance.BorderSize = 0;
            scheduleBTN.FlatStyle = FlatStyle.Flat;
            scheduleBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scheduleBTN.ForeColor = Color.White;
            scheduleBTN.Location = new Point(472, 384);
            scheduleBTN.Name = "scheduleBTN";
            scheduleBTN.Size = new Size(125, 44);
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
            EditBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBTN.ForeColor = Color.White;
            EditBTN.Location = new Point(641, 384);
            EditBTN.Name = "EditBTN";
            EditBTN.Size = new Size(125, 44);
            EditBTN.TabIndex = 19;
            EditBTN.Text = "Edit";
            EditBTN.UseVisualStyleBackColor = false;
            EditBTN.Click += EditBTN_Click;
            // 
            // appointments
            // 
            appointments.BorderStyle = BorderStyle.FixedSingle;
            appointments.FormattingEnabled = true;
            appointments.ItemHeight = 25;
            appointments.Location = new Point(863, 40);
            appointments.Name = "appointments";
            appointments.Size = new Size(307, 277);
            appointments.TabIndex = 20;
            // 
            // searchTBX
            // 
            searchTBX.BackColor = Color.White;
            searchTBX.BorderStyle = BorderStyle.None;
            searchTBX.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTBX.ForeColor = SystemColors.HotTrack;
            searchTBX.Location = new Point(847, 384);
            searchTBX.Multiline = true;
            searchTBX.Name = "searchTBX";
            searchTBX.Size = new Size(128, 37);
            searchTBX.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.ForeColor = SystemColors.ButtonShadow;
            panel5.Location = new Point(847, 427);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 1);
            panel5.TabIndex = 22;
            // 
            // searchBTN
            // 
            searchBTN.BackColor = Color.IndianRed;
            searchBTN.FlatAppearance.BorderSize = 0;
            searchBTN.FlatStyle = FlatStyle.Flat;
            searchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBTN.ForeColor = Color.White;
            searchBTN.Location = new Point(981, 377);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(95, 44);
            searchBTN.TabIndex = 23;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = false;
            searchBTN.Click += searchBTN_Click;
            // 
            // searchErrorLabel
            // 
            searchErrorLabel.AutoSize = true;
            searchErrorLabel.Location = new Point(862, 328);
            searchErrorLabel.Name = "searchErrorLabel";
            searchErrorLabel.Size = new Size(0, 25);
            searchErrorLabel.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(863, 12);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 25;
            label5.Text = "Appointments:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(71, 239);
            label6.Name = "label6";
            label6.Size = new Size(140, 25);
            label6.TabIndex = 26;
            label6.Text = "AvailableTimes:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(421, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 409);
            panel6.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(824, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 409);
            panel7.TabIndex = 28;
            // 
            // clearBTN
            // 
            clearBTN.BackColor = Color.IndianRed;
            clearBTN.FlatAppearance.BorderSize = 0;
            clearBTN.FlatStyle = FlatStyle.Flat;
            clearBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBTN.ForeColor = Color.White;
            clearBTN.Location = new Point(1082, 375);
            clearBTN.Name = "clearBTN";
            clearBTN.Size = new Size(95, 44);
            clearBTN.TabIndex = 29;
            clearBTN.Text = "Clear";
            clearBTN.UseVisualStyleBackColor = false;
            clearBTN.Click += clearBTN_Click;
            // 
            // patentNameErrorLabel
            // 
            patentNameErrorLabel.AutoSize = true;
            patentNameErrorLabel.Location = new Point(482, 50);
            patentNameErrorLabel.Name = "patentNameErrorLabel";
            patentNameErrorLabel.Size = new Size(0, 25);
            patentNameErrorLabel.TabIndex = 30;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new Point(482, 319);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(0, 25);
            reasonLabel.TabIndex = 31;
            // 
            // ManageAppts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(reasonLabel);
            Controls.Add(patentNameErrorLabel);
            Controls.Add(clearBTN);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(searchErrorLabel);
            Controls.Add(searchBTN);
            Controls.Add(searchTBX);
            Controls.Add(panel5);
            Controls.Add(appointments);
            Controls.Add(EditBTN);
            Controls.Add(scheduleBTN);
            Controls.Add(label4);
            Controls.Add(reasonTBX);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(timeTBX);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(doctorsNameTBX);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(patientNameTBX);
            Controls.Add(panel1);
            Controls.Add(docTimesListBox);
            Controls.Add(monthCalendar);
            Name = "ManageAppts";
            Size = new Size(1191, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox docTimesListBox;
        private MonthCalendar monthCalendar;
        private TextBox patientNameTBX;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox doctorsNameTBX;
        private Panel panel2;
        private Label label3;
        private TextBox timeTBX;
        private Panel panel3;
        private Label label4;
        private TextBox reasonTBX;
        private Panel panel4;
        private Button scheduleBTN;
        private Button EditBTN;
        private ListBox appointments;
        private TextBox searchTBX;
        private Panel panel5;
        private Button searchBTN;
        private Label searchErrorLabel;
        private Label label5;
        private Label label6;
        private Panel panel6;
        private Panel panel7;
        private Button clearBTN;
        private Label patentNameErrorLabel;
        private Label reasonLabel;
    }
}