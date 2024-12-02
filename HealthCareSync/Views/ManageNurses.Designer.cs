namespace HealthCareSync.Views
{
    partial class ManageNurses
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
            idTextBox = new TextBox();
            idLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            address2TextBox = new TextBox();
            cityTextBox = new TextBox();
            zipTextBox = new TextBox();
            address1TextBox = new TextBox();
            address2Label = new Label();
            cityLabel = new Label();
            lastNameTextBox = new TextBox();
            stateLabel = new Label();
            zipcodeLabel = new Label();
            address1Label = new Label();
            birthDateLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            editNurseButton = new Button();
            nurseListBox = new ListBox();
            phoneNumLabel = new Label();
            phoneNumTextBox = new TextBox();
            addNurseButton = new Button();
            unselectNurseButton = new Button();
            dateTimePickerForNurse = new DateTimePicker();
            stateComboBoxForNurse = new ComboBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            label1 = new Label();
            panel13 = new Panel();
            statusComboBox = new ComboBox();
            label2 = new Label();
            deleteNurseBTN = new Button();
            SuspendLayout();
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(1074, 364);
            idTextBox.Margin = new Padding(4, 5, 4, 5);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(123, 23);
            idTextBox.TabIndex = 67;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = Color.LightGray;
            idLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idLabel.Location = new Point(998, 367);
            idLabel.Margin = new Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(52, 15);
            idLabel.TabIndex = 66;
            idLabel.Text = "Nurse Id";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Location = new Point(479, 60);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(167, 15);
            usernameTextBox.TabIndex = 65;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.MenuHighlight;
            usernameLabel.Location = new Point(569, 88);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(64, 15);
            usernameLabel.TabIndex = 64;
            usernameLabel.Text = "Username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // address2TextBox
            // 
            address2TextBox.BorderStyle = BorderStyle.None;
            address2TextBox.Location = new Point(191, 332);
            address2TextBox.Margin = new Padding(4, 5, 4, 5);
            address2TextBox.Multiline = true;
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(719, 25);
            address2TextBox.TabIndex = 63;
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.None;
            cityTextBox.Location = new Point(152, 417);
            cityTextBox.Multiline = true;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(232, 15);
            cityTextBox.TabIndex = 61;
            // 
            // zipTextBox
            // 
            zipTextBox.BorderStyle = BorderStyle.None;
            zipTextBox.Location = new Point(170, 470);
            zipTextBox.Margin = new Padding(4, 5, 4, 5);
            zipTextBox.Multiline = true;
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(284, 32);
            zipTextBox.TabIndex = 60;
            // 
            // address1TextBox
            // 
            address1TextBox.BorderStyle = BorderStyle.None;
            address1TextBox.Location = new Point(191, 260);
            address1TextBox.Multiline = true;
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(498, 15);
            address1TextBox.TabIndex = 59;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.BackColor = Color.LightGray;
            address2Label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address2Label.Location = new Point(114, 337);
            address2Label.Margin = new Padding(4, 0, 4, 0);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(59, 15);
            address2Label.TabIndex = 58;
            address2Label.Text = "Address 2";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = Color.LightGray;
            cityLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityLabel.Location = new Point(114, 417);
            cityLabel.Margin = new Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(27, 15);
            cityLabel.TabIndex = 57;
            cityLabel.Text = "City";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.None;
            lastNameTextBox.Location = new Point(666, 27);
            lastNameTextBox.Margin = new Padding(4, 5, 4, 5);
            lastNameTextBox.Multiline = true;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(196, 15);
            lastNameTextBox.TabIndex = 55;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stateLabel.Location = new Point(564, 407);
            stateLabel.Margin = new Padding(4, 0, 4, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(34, 15);
            stateLabel.TabIndex = 54;
            stateLabel.Text = "State";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.BackColor = Color.LightGray;
            zipcodeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zipcodeLabel.Location = new Point(114, 477);
            zipcodeLabel.Margin = new Padding(4, 0, 4, 0);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(54, 15);
            zipcodeLabel.TabIndex = 53;
            zipcodeLabel.Text = "Zip Code";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.BackColor = Color.LightGray;
            address1Label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address1Label.Location = new Point(114, 260);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(57, 15);
            address1Label.TabIndex = 52;
            address1Label.Text = "Address 1";
            address1Label.Click += address1Label_Click;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.BackColor = Color.LightGray;
            birthDateLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthDateLabel.Location = new Point(114, 95);
            birthDateLabel.Margin = new Padding(4, 0, 4, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(60, 15);
            birthDateLabel.TabIndex = 51;
            birthDateLabel.Text = "Birth Date";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = Color.LightGray;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(569, 27);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 50;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.LightGray;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(113, 27);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 49;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.None;
            firstNameTextBox.Location = new Point(220, 27);
            firstNameTextBox.Margin = new Padding(4, 5, 4, 5);
            firstNameTextBox.Multiline = true;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(188, 15);
            firstNameTextBox.TabIndex = 48;
            // 
            // editNurseButton
            // 
            editNurseButton.BackColor = Color.RoyalBlue;
            editNurseButton.FlatAppearance.BorderSize = 0;
            editNurseButton.FlatStyle = FlatStyle.Flat;
            editNurseButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editNurseButton.ForeColor = Color.White;
            editNurseButton.Location = new Point(384, 564);
            editNurseButton.Margin = new Padding(4, 5, 4, 5);
            editNurseButton.Name = "editNurseButton";
            editNurseButton.Size = new Size(110, 37);
            editNurseButton.TabIndex = 47;
            editNurseButton.Text = "Edit";
            editNurseButton.UseVisualStyleBackColor = false;
            editNurseButton.Click += editNurseButton_Click;
            // 
            // nurseListBox
            // 
            nurseListBox.FormattingEnabled = true;
            nurseListBox.ItemHeight = 15;
            nurseListBox.Location = new Point(1004, 45);
            nurseListBox.Name = "nurseListBox";
            nurseListBox.Size = new Size(193, 274);
            nurseListBox.TabIndex = 46;
            nurseListBox.SelectedIndexChanged += NurseListBox_SelectedIndexChanged;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.BackColor = Color.LightGray;
            phoneNumLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumLabel.Location = new Point(117, 173);
            phoneNumLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(88, 15);
            phoneNumLabel.TabIndex = 69;
            phoneNumLabel.Text = "Phone Number";
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.BorderStyle = BorderStyle.None;
            phoneNumTextBox.Location = new Point(210, 167);
            phoneNumTextBox.Multiline = true;
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(221, 25);
            phoneNumTextBox.TabIndex = 68;
            // 
            // addNurseButton
            // 
            addNurseButton.BackColor = Color.RoyalBlue;
            addNurseButton.FlatAppearance.BorderSize = 0;
            addNurseButton.FlatStyle = FlatStyle.Flat;
            addNurseButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNurseButton.ForeColor = Color.White;
            addNurseButton.Location = new Point(210, 564);
            addNurseButton.Margin = new Padding(4, 5, 4, 5);
            addNurseButton.Name = "addNurseButton";
            addNurseButton.Size = new Size(115, 37);
            addNurseButton.TabIndex = 70;
            addNurseButton.Text = "Add";
            addNurseButton.UseVisualStyleBackColor = false;
            addNurseButton.Click += addNurseButton_Click;
            // 
            // unselectNurseButton
            // 
            unselectNurseButton.BackColor = Color.RoyalBlue;
            unselectNurseButton.FlatAppearance.BorderSize = 0;
            unselectNurseButton.FlatStyle = FlatStyle.Flat;
            unselectNurseButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unselectNurseButton.ForeColor = Color.White;
            unselectNurseButton.Location = new Point(722, 564);
            unselectNurseButton.Margin = new Padding(4, 5, 4, 5);
            unselectNurseButton.Name = "unselectNurseButton";
            unselectNurseButton.Size = new Size(156, 37);
            unselectNurseButton.TabIndex = 71;
            unselectNurseButton.Text = "Clear Fields";
            unselectNurseButton.UseVisualStyleBackColor = false;
            unselectNurseButton.Click += unselectNurseButton_Click;
            // 
            // dateTimePickerForNurse
            // 
            dateTimePickerForNurse.Format = DateTimePickerFormat.Short;
            dateTimePickerForNurse.Location = new Point(180, 87);
            dateTimePickerForNurse.Name = "dateTimePickerForNurse";
            dateTimePickerForNurse.Size = new Size(197, 23);
            dateTimePickerForNurse.TabIndex = 74;
            // 
            // stateComboBoxForNurse
            // 
            stateComboBoxForNurse.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBoxForNurse.FormattingEnabled = true;
            stateComboBoxForNurse.Location = new Point(626, 403);
            stateComboBoxForNurse.Margin = new Padding(4, 5, 4, 5);
            stateComboBoxForNurse.Name = "stateComboBoxForNurse";
            stateComboBoxForNurse.Size = new Size(222, 23);
            stateComboBoxForNurse.TabIndex = 75;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(488, 106);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(166, 15);
            passwordTextBox.TabIndex = 76;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.ActiveCaption;
            passwordLabel.Location = new Point(569, 155);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(59, 15);
            passwordLabel.TabIndex = 77;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(569, 62);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 1);
            panel3.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Location = new Point(113, 62);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 1);
            panel1.TabIndex = 79;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(113, 137);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 1);
            panel2.TabIndex = 79;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.Location = new Point(114, 212);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 1);
            panel4.TabIndex = 80;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Blue;
            panel5.Location = new Point(569, 120);
            panel5.Name = "panel5";
            panel5.Size = new Size(264, 1);
            panel5.TabIndex = 81;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Blue;
            panel6.Location = new Point(118, 287);
            panel6.Name = "panel6";
            panel6.Size = new Size(580, 1);
            panel6.TabIndex = 82;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Blue;
            panel7.Location = new Point(117, 367);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(580, 1);
            panel7.TabIndex = 83;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Blue;
            panel8.Location = new Point(117, 447);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(264, 1);
            panel8.TabIndex = 81;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Blue;
            panel9.Location = new Point(114, 517);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(264, 1);
            panel9.TabIndex = 81;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Blue;
            panel10.Location = new Point(564, 447);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(264, 1);
            panel10.TabIndex = 84;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Blue;
            panel11.Location = new Point(983, 10);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 573);
            panel11.TabIndex = 84;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Blue;
            panel12.Location = new Point(569, 173);
            panel12.Name = "panel12";
            panel12.Size = new Size(274, 2);
            panel12.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGray;
            label1.Location = new Point(1004, 27);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 85;
            label1.Text = "Nurses:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Blue;
            panel13.Location = new Point(564, 517);
            panel13.Margin = new Padding(4, 5, 4, 5);
            panel13.Name = "panel13";
            panel13.Size = new Size(377, 2);
            panel13.TabIndex = 88;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(626, 470);
            statusComboBox.Margin = new Padding(4, 5, 4, 5);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(315, 23);
            statusComboBox.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(564, 473);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 86;
            label2.Text = "Status";
            // 
            // deleteNurseBTN
            // 
            deleteNurseBTN.BackColor = Color.RoyalBlue;
            deleteNurseBTN.FlatAppearance.BorderSize = 0;
            deleteNurseBTN.FlatStyle = FlatStyle.Flat;
            deleteNurseBTN.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteNurseBTN.ForeColor = Color.White;
            deleteNurseBTN.Location = new Point(556, 564);
            deleteNurseBTN.Margin = new Padding(4, 5, 4, 5);
            deleteNurseBTN.Name = "deleteNurseBTN";
            deleteNurseBTN.Size = new Size(110, 37);
            deleteNurseBTN.TabIndex = 89;
            deleteNurseBTN.Text = "Delete";
            deleteNurseBTN.UseVisualStyleBackColor = false;
            deleteNurseBTN.Click += deleteNurseBTN_Click;
            // 
            // ManageNurses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 615);
            Controls.Add(deleteNurseBTN);
            Controls.Add(panel13);
            Controls.Add(statusComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(stateComboBoxForNurse);
            Controls.Add(dateTimePickerForNurse);
            Controls.Add(unselectNurseButton);
            Controls.Add(addNurseButton);
            Controls.Add(phoneNumLabel);
            Controls.Add(phoneNumTextBox);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
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
            Controls.Add(editNurseButton);
            Controls.Add(nurseListBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageNurses";
            Text = "ManageNurses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextBox;
        private Label idLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private TextBox address2TextBox;
        private TextBox cityTextBox;
        private TextBox zipTextBox;
        private TextBox address1TextBox;
        private Label address2Label;
        private Label cityLabel;
        private TextBox lastNameTextBox;
        private Label stateLabel;
        private Label zipcodeLabel;
        private Label address1Label;
        private Label birthDateLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Button editNurseButton;
        private ListBox nurseListBox;
        private Label phoneNumLabel;
        private TextBox phoneNumTextBox;
        private Button addNurseButton;
        private Button unselectNurseButton;
        private DateTimePicker dateTimePickerForNurse;
        private ComboBox stateComboBoxForNurse;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label1;
        private Panel panel13;
        private ComboBox statusComboBox;
        private Label label2;
        private Button deleteNurseBTN;
    }
}