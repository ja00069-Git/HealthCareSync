namespace HealthCareSync.Views
{
    partial class Manage_Patients
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
            patientListBox = new ListBox();
            saveButton = new Button();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            birthDateLabel = new Label();
            address1Label = new Label();
            zipcodeLabel = new Label();
            stateLabel = new Label();
            lastNameTextBox = new TextBox();
            cityLabel = new Label();
            address2Label = new Label();
            address1TextBox = new TextBox();
            zipTextBox = new TextBox();
            cityTextBox = new TextBox();
            address2TextBox = new TextBox();
            flagStatusLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            flagStatusComboBox = new ComboBox();
            errorLabel = new Label();
            addButton = new Button();
            unselectButton = new Button();
            stateComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            genderLabel = new Label();
            birthDateTimePicker = new DateTimePicker();
            searchLastNameTextBox = new TextBox();
            searchBirthDatePicker = new DateTimePicker();
            searchFirstNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            searchByBirthDateCheckBox = new CheckBox();
            searchByNameCheckBox = new CheckBox();
            searchButton = new Button();
            resetSearchButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            SuspendLayout();
            // 
            // patientListBox
            // 
            patientListBox.FormattingEnabled = true;
            patientListBox.ItemHeight = 15;
            patientListBox.Location = new Point(382, 40);
            patientListBox.Name = "patientListBox";
            patientListBox.Size = new Size(120, 169);
            patientListBox.TabIndex = 0;
            patientListBox.SelectedIndexChanged += PatientListBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.IndianRed;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Showcard Gothic", 9F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(873, 280);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 33);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            firstNameTextBox.ForeColor = SystemColors.HotTrack;
            firstNameTextBox.Location = new Point(652, 19);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 17);
            firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            firstNameLabel.Location = new Point(582, 19);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lastNameLabel.Location = new Point(583, 65);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            birthDateLabel.Location = new Point(583, 110);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(60, 15);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            address1Label.Location = new Point(856, 19);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(57, 15);
            address1Label.TabIndex = 6;
            address1Label.Text = "Address 1";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            zipcodeLabel.Location = new Point(856, 186);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(54, 15);
            zipcodeLabel.TabIndex = 7;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            stateLabel.Location = new Point(856, 146);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(34, 15);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            lastNameTextBox.ForeColor = SystemColors.HotTrack;
            lastNameTextBox.Location = new Point(652, 65);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 17);
            lastNameTextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            cityLabel.Location = new Point(856, 111);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(27, 15);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            address2Label.Location = new Point(856, 65);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(59, 15);
            address2Label.TabIndex = 12;
            address2Label.Text = "Address 2";
            // 
            // address1TextBox
            // 
            address1TextBox.BorderStyle = BorderStyle.None;
            address1TextBox.Font = new Font("Microsoft YaHei UI", 10F);
            address1TextBox.ForeColor = SystemColors.HotTrack;
            address1TextBox.Location = new Point(917, 21);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(100, 17);
            address1TextBox.TabIndex = 15;
            // 
            // zipTextBox
            // 
            zipTextBox.BorderStyle = BorderStyle.None;
            zipTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            zipTextBox.ForeColor = SystemColors.HotTrack;
            zipTextBox.Location = new Point(917, 187);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(100, 17);
            zipTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.None;
            cityTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            cityTextBox.ForeColor = SystemColors.HotTrack;
            cityTextBox.Location = new Point(887, 111);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 17);
            cityTextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            address2TextBox.BorderStyle = BorderStyle.None;
            address2TextBox.Font = new Font("Microsoft YaHei UI", 10F);
            address2TextBox.ForeColor = SystemColors.HotTrack;
            address2TextBox.Location = new Point(917, 64);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(100, 17);
            address2TextBox.TabIndex = 19;
            // 
            // flagStatusLabel
            // 
            flagStatusLabel.AutoSize = true;
            flagStatusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            flagStatusLabel.Location = new Point(773, 227);
            flagStatusLabel.Name = "flagStatusLabel";
            flagStatusLabel.Size = new Size(65, 15);
            flagStatusLabel.TabIndex = 20;
            flagStatusLabel.Text = "Flag Status";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            idLabel.Location = new Point(415, 227);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(60, 15);
            idLabel.TabIndex = 22;
            idLabel.Text = "Patient_Id";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(393, 245);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 23;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BorderStyle = BorderStyle.None;
            phoneNumberTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            phoneNumberTextBox.ForeColor = SystemColors.HotTrack;
            phoneNumberTextBox.Location = new Point(671, 186);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 17);
            phoneNumberTextBox.TabIndex = 24;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            phoneNumberLabel.Location = new Point(583, 187);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // flagStatusComboBox
            // 
            flagStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flagStatusComboBox.FormattingEnabled = true;
            flagStatusComboBox.Location = new Point(752, 245);
            flagStatusComboBox.Name = "flagStatusComboBox";
            flagStatusComboBox.Size = new Size(100, 23);
            flagStatusComboBox.TabIndex = 26;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(663, 329);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 30);
            errorLabel.TabIndex = 27;
            // 
            // addButton
            // 
            addButton.BackColor = Color.IndianRed;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Showcard Gothic", 9F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(624, 280);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 33);
            addButton.TabIndex = 28;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // unselectButton
            // 
            unselectButton.BackColor = Color.IndianRed;
            unselectButton.FlatStyle = FlatStyle.Flat;
            unselectButton.Font = new Font("Showcard Gothic", 9F);
            unselectButton.ForeColor = Color.White;
            unselectButton.Location = new Point(752, 280);
            unselectButton.Name = "unselectButton";
            unselectButton.Size = new Size(100, 33);
            unselectButton.TabIndex = 30;
            unselectButton.Text = "Unselect";
            unselectButton.UseVisualStyleBackColor = false;
            unselectButton.Click += unselectButton_Click;
            // 
            // stateComboBox
            // 
            stateComboBox.DisplayMember = "fdsf";
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(896, 139);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(100, 23);
            stateComboBox.TabIndex = 31;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(634, 141);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(38, 23);
            genderComboBox.TabIndex = 32;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            genderLabel.Location = new Point(583, 147);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 33;
            genderLabel.Text = "Gender";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(652, 104);
            birthDateTimePicker.MaxDate = new DateTime(9998, 12, 25, 0, 0, 0, 0);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(100, 23);
            birthDateTimePicker.TabIndex = 34;
            birthDateTimePicker.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // searchLastNameTextBox
            // 
            searchLastNameTextBox.BorderStyle = BorderStyle.None;
            searchLastNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchLastNameTextBox.ForeColor = SystemColors.HotTrack;
            searchLastNameTextBox.Location = new Point(162, 222);
            searchLastNameTextBox.Name = "searchLastNameTextBox";
            searchLastNameTextBox.Size = new Size(156, 17);
            searchLastNameTextBox.TabIndex = 35;
            // 
            // searchBirthDatePicker
            // 
            searchBirthDatePicker.Format = DateTimePickerFormat.Short;
            searchBirthDatePicker.Location = new Point(167, 83);
            searchBirthDatePicker.Name = "searchBirthDatePicker";
            searchBirthDatePicker.Size = new Size(100, 23);
            searchBirthDatePicker.TabIndex = 36;
            // 
            // searchFirstNameTextBox
            // 
            searchFirstNameTextBox.BorderStyle = BorderStyle.None;
            searchFirstNameTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            searchFirstNameTextBox.ForeColor = SystemColors.HotTrack;
            searchFirstNameTextBox.Location = new Point(165, 177);
            searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            searchFirstNameTextBox.Size = new Size(146, 17);
            searchFirstNameTextBox.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(92, 177);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 40;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(93, 223);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 41;
            label2.Text = "Last Name";
            // 
            // searchByBirthDateCheckBox
            // 
            searchByBirthDateCheckBox.AutoSize = true;
            searchByBirthDateCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            searchByBirthDateCheckBox.Location = new Point(155, 57);
            searchByBirthDateCheckBox.Name = "searchByBirthDateCheckBox";
            searchByBirthDateCheckBox.Size = new Size(134, 19);
            searchByBirthDateCheckBox.TabIndex = 42;
            searchByBirthDateCheckBox.Text = "Search by Birth Date";
            searchByBirthDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchByNameCheckBox
            // 
            searchByNameCheckBox.AutoSize = true;
            searchByNameCheckBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            searchByNameCheckBox.Location = new Point(155, 147);
            searchByNameCheckBox.Name = "searchByNameCheckBox";
            searchByNameCheckBox.Size = new Size(113, 19);
            searchByNameCheckBox.TabIndex = 43;
            searchByNameCheckBox.Text = "Search by Name";
            searchByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.IndianRed;
            searchButton.Enabled = false;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Showcard Gothic", 9F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(211, 280);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 33);
            searchButton.TabIndex = 44;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // resetSearchButton
            // 
            resetSearchButton.BackColor = Color.IndianRed;
            resetSearchButton.Enabled = false;
            resetSearchButton.FlatStyle = FlatStyle.Flat;
            resetSearchButton.Font = new Font("Showcard Gothic", 9F);
            resetSearchButton.ForeColor = Color.White;
            resetSearchButton.Location = new Point(79, 280);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new Size(100, 33);
            resetSearchButton.TabIndex = 45;
            resetSearchButton.Text = "Reset";
            resetSearchButton.UseVisualStyleBackColor = false;
            resetSearchButton.Click += resetSearchButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(571, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(571, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 47;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(571, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 48;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(839, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 49;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(804, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 205);
            panel5.TabIndex = 50;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(839, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 1);
            panel6.TabIndex = 49;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(839, 129);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 1);
            panel7.TabIndex = 50;
            // 
            // panel9
            // 
            panel9.BackColor = Color.IndianRed;
            panel9.Location = new Point(839, 168);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 1);
            panel9.TabIndex = 50;
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(839, 205);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 1);
            panel8.TabIndex = 52;
            // 
            // panel10
            // 
            panel10.BackColor = Color.IndianRed;
            panel10.Location = new Point(571, 170);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 1);
            panel10.TabIndex = 53;
            // 
            // panel11
            // 
            panel11.BackColor = Color.IndianRed;
            panel11.Location = new Point(571, 205);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 1);
            panel11.TabIndex = 54;
            // 
            // panel12
            // 
            panel12.BackColor = Color.IndianRed;
            panel12.Location = new Point(552, 19);
            panel12.Name = "panel12";
            panel12.Size = new Size(1, 290);
            panel12.TabIndex = 51;
            // 
            // panel13
            // 
            panel13.BackColor = Color.IndianRed;
            panel13.Location = new Point(337, 19);
            panel13.Name = "panel13";
            panel13.Size = new Size(1, 290);
            panel13.TabIndex = 52;
            // 
            // panel14
            // 
            panel14.AutoScroll = true;
            panel14.BackColor = Color.IndianRed;
            panel14.Location = new Point(562, 316);
            panel14.Name = "panel14";
            panel14.Size = new Size(480, 1);
            panel14.TabIndex = 55;
            // 
            // panel15
            // 
            panel15.BackColor = Color.IndianRed;
            panel15.Location = new Point(79, 124);
            panel15.Name = "panel15";
            panel15.Size = new Size(232, 1);
            panel15.TabIndex = 56;
            // 
            // panel16
            // 
            panel16.BackColor = Color.IndianRed;
            panel16.Location = new Point(79, 316);
            panel16.Name = "panel16";
            panel16.Size = new Size(245, 1);
            panel16.TabIndex = 57;
            // 
            // panel17
            // 
            panel17.BackColor = Color.IndianRed;
            panel17.Location = new Point(79, 196);
            panel17.Name = "panel17";
            panel17.Size = new Size(232, 1);
            panel17.TabIndex = 57;
            // 
            // panel18
            // 
            panel18.BackColor = Color.IndianRed;
            panel18.Location = new Point(79, 241);
            panel18.Name = "panel18";
            panel18.Size = new Size(232, 1);
            panel18.TabIndex = 57;
            // 
            // Manage_Patients
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1095, 368);
            Controls.Add(panel18);
            Controls.Add(panel17);
            Controls.Add(panel16);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(resetSearchButton);
            Controls.Add(searchButton);
            Controls.Add(searchByNameCheckBox);
            Controls.Add(searchByBirthDateCheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchFirstNameTextBox);
            Controls.Add(searchBirthDatePicker);
            Controls.Add(searchLastNameTextBox);
            Controls.Add(birthDateTimePicker);
            Controls.Add(genderLabel);
            Controls.Add(genderComboBox);
            Controls.Add(stateComboBox);
            Controls.Add(unselectButton);
            Controls.Add(addButton);
            Controls.Add(errorLabel);
            Controls.Add(flagStatusComboBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(flagStatusLabel);
            Controls.Add(address2TextBox);
            Controls.Add(cityTextBox);
            Controls.Add(zipTextBox);
            Controls.Add(address1TextBox);
            Controls.Add(address2Label);
            Controls.Add(cityLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(stateLabel);
            Controls.Add(zipcodeLabel);
            Controls.Add(address1Label);
            Controls.Add(birthDateLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(saveButton);
            Controls.Add(patientListBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Manage_Patients";
            Text = "Manage_Patients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox patientListBox;
        private Button saveButton;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label birthDateLabel;
        private Label address1Label;
        private Label zipcodeLabel;
        private Label stateLabel;
        private TextBox lastNameTextBox;
        private Label cityLabel;
        private Label address2Label;
        private TextBox address1TextBox;
        private TextBox zipTextBox;
        private TextBox cityTextBox;
        private TextBox address2TextBox;
        private Label flagStatusLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private ComboBox flagStatusComboBox;
        private Label errorLabel;
        private Button addButton;
        private Button unselectButton;
        private ComboBox stateComboBox;
        private ComboBox genderComboBox;
        private Label genderLabel;
        private DateTimePicker birthDateTimePicker;
        private TextBox searchLastNameTextBox;
        private DateTimePicker searchBirthDatePicker;
        private TextBox searchFirstNameTextBox;
        private Label label1;
        private Label label2;
        private CheckBox searchByBirthDateCheckBox;
        private CheckBox searchByNameCheckBox;
        private Button searchButton;
        private Button resetSearchButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
    }
}