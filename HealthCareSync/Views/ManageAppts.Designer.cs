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
            docsTimesListBox = new ListBox();
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
            searchTextBox = new TextBox();
            panel5 = new Panel();
            searchBTN = new Button();
            searchLabel = new Label();
            appointmentLabel = new Label();
            avalableTimesLabel = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            clearSearchBTN = new Button();
            patentNameErrorLabel = new Label();
            reasonErrorLabel = new Label();
            patientNameErrorLabel = new Label();
            generalErrorlLabel = new Label();
            SuspendLayout();
            // 
            // docsTimesListBox
            // 
            docsTimesListBox.BorderStyle = BorderStyle.FixedSingle;
            docsTimesListBox.FormattingEnabled = true;
            docsTimesListBox.ItemHeight = 25;
            docsTimesListBox.Location = new Point(71, 267);
            docsTimesListBox.Name = "docsTimesListBox";
            docsTimesListBox.Size = new Size(312, 177);
            docsTimesListBox.TabIndex = 1;
            docsTimesListBox.SelectedIndexChanged += docsTimesListBox_SelectedIndexChanged;
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
            // patientNameTextBox
            // 
            patientNameTextBox.BackColor = Color.White;
            patientNameTextBox.BorderStyle = BorderStyle.None;
            patientNameTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientNameTextBox.ForeColor = SystemColors.HotTrack;
            patientNameTextBox.Location = new Point(623, 12);
            patientNameTextBox.Multiline = true;
            patientNameTextBox.Name = "patientNameTextBox";
            patientNameTextBox.Size = new Size(246, 28);
            patientNameTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(465, 46);
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
            patientNameLabel.Location = new Point(482, 12);
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
            doctorsNameLabel.Location = new Point(482, 88);
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
            doctorsNameTextBox.Location = new Point(623, 83);
            doctorsNameTextBox.Multiline = true;
            doctorsNameTextBox.Name = "doctorsNameTextBox";
            doctorsNameTextBox.Size = new Size(246, 31);
            doctorsNameTextBox.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(465, 116);
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
            appointmentTimeLabel.Location = new Point(482, 163);
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
            appointmentTimeTextBox.Location = new Point(595, 157);
            appointmentTimeTextBox.Multiline = true;
            appointmentTimeTextBox.Name = "appointmentTimeTextBox";
            appointmentTimeTextBox.Size = new Size(274, 33);
            appointmentTimeTextBox.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.ForeColor = SystemColors.ButtonShadow;
            panel3.Location = new Point(472, 192);
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
            reasonLabel.Location = new Point(482, 250);
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
            reasonTextBox.Location = new Point(574, 249);
            reasonTextBox.Multiline = true;
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(295, 32);
            reasonTextBox.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.ForeColor = SystemColors.ButtonShadow;
            panel4.Location = new Point(472, 287);
            panel4.Name = "panel4";
            panel4.Size = new Size(404, 1);
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
            // appointmentsListBox
            // 
            appointmentsListBox.BorderStyle = BorderStyle.FixedSingle;
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 25;
            appointmentsListBox.Location = new Point(940, 40);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(326, 277);
            appointmentsListBox.TabIndex = 20;
            appointmentsListBox.SelectedIndexChanged += appointmentsListBox_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.White;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.ForeColor = SystemColors.HotTrack;
            searchTextBox.Location = new Point(924, 384);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(128, 37);
            searchTextBox.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.ForeColor = SystemColors.ButtonShadow;
            panel5.Location = new Point(924, 427);
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
            searchBTN.Location = new Point(1058, 377);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(95, 44);
            searchBTN.TabIndex = 23;
            searchBTN.Text = "Search";
            searchBTN.UseVisualStyleBackColor = false;
            searchBTN.Click += searchBTN_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(939, 328);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(0, 25);
            searchLabel.TabIndex = 24;
            // 
            // appointmentLabel
            // 
            appointmentLabel.AutoSize = true;
            appointmentLabel.BackColor = SystemColors.Control;
            appointmentLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentLabel.ForeColor = SystemColors.ActiveCaptionText;
            appointmentLabel.Location = new Point(940, 12);
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
            avalableTimesLabel.Location = new Point(71, 239);
            avalableTimesLabel.Name = "avalableTimesLabel";
            avalableTimesLabel.Size = new Size(140, 25);
            avalableTimesLabel.TabIndex = 26;
            avalableTimesLabel.Text = "AvailableTimes:";
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
            panel7.Location = new Point(896, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 409);
            panel7.TabIndex = 28;
            // 
            // clearSearchBTN
            // 
            clearSearchBTN.BackColor = Color.IndianRed;
            clearSearchBTN.FlatAppearance.BorderSize = 0;
            clearSearchBTN.FlatStyle = FlatStyle.Flat;
            clearSearchBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearSearchBTN.ForeColor = Color.White;
            clearSearchBTN.Location = new Point(1159, 375);
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
            patentNameErrorLabel.Location = new Point(482, 50);
            patentNameErrorLabel.Name = "patentNameErrorLabel";
            patentNameErrorLabel.Size = new Size(0, 25);
            patentNameErrorLabel.TabIndex = 30;
            // 
            // reasonErrorLabel
            // 
            reasonErrorLabel.AutoSize = true;
            reasonErrorLabel.Location = new Point(482, 291);
            reasonErrorLabel.Name = "reasonErrorLabel";
            reasonErrorLabel.Size = new Size(0, 25);
            reasonErrorLabel.TabIndex = 31;
            // 
            // patientNameErrorLabel
            // 
            patientNameErrorLabel.AutoSize = true;
            patientNameErrorLabel.Location = new Point(482, 50);
            patientNameErrorLabel.Name = "patientNameErrorLabel";
            patientNameErrorLabel.Size = new Size(0, 25);
            patientNameErrorLabel.TabIndex = 32;
            // 
            // generalErrorlLabel
            // 
            generalErrorlLabel.AutoSize = true;
            generalErrorlLabel.Location = new Point(472, 339);
            generalErrorlLabel.Name = "generalErrorlLabel";
            generalErrorlLabel.Size = new Size(0, 25);
            generalErrorlLabel.TabIndex = 33;
            // 
            // ManageAppts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(generalErrorlLabel);
            Controls.Add(patientNameErrorLabel);
            Controls.Add(reasonErrorLabel);
            Controls.Add(patentNameErrorLabel);
            Controls.Add(clearSearchBTN);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(avalableTimesLabel);
            Controls.Add(appointmentLabel);
            Controls.Add(searchLabel);
            Controls.Add(searchBTN);
            Controls.Add(searchTextBox);
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
            Controls.Add(docsTimesListBox);
            Controls.Add(monthCalendar);
            Name = "ManageAppts";
            Size = new Size(1308, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox docsTimesListBox;
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
        private TextBox searchTextBox;
        private Panel panel5;
        private Button searchBTN;
        private Label searchLabel;
        private Label appointmentLabel;
        private Label avalableTimesLabel;
        private Panel panel6;
        private Panel panel7;
        private Button clearSearchBTN;
        private Label patentNameErrorLabel;
        private Label reasonErrorLabel;
        private Label patientNameErrorLabel;
        private Label generalErrorlLabel;
    }
}