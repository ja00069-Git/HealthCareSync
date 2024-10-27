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
            SuspendLayout();
            // 
            // patientListBox
            // 
            patientListBox.FormattingEnabled = true;
            patientListBox.ItemHeight = 15;
            patientListBox.Location = new Point(79, 170);
            patientListBox.Name = "patientListBox";
            patientListBox.Size = new Size(163, 184);
            patientListBox.TabIndex = 0;
            patientListBox.SelectedIndexChanged += PatientListBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(549, 282);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 33);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(322, 124);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(341, 106);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(462, 106);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(574, 106);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(59, 15);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new Point(341, 165);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(58, 15);
            address1Label.TabIndex = 6;
            address1Label.Text = "Address 1";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new Point(462, 231);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(55, 15);
            zipcodeLabel.TabIndex = 7;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(357, 231);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(33, 15);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(440, 124);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(586, 165);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new Point(462, 165);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(58, 15);
            address2Label.TabIndex = 12;
            address2Label.Text = "Address 2";
            // 
            // address1TextBox
            // 
            address1TextBox.Location = new Point(322, 183);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(100, 23);
            address1TextBox.TabIndex = 15;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(440, 249);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(100, 23);
            zipTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(549, 183);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(440, 183);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(100, 23);
            address2TextBox.TabIndex = 19;
            // 
            // flagStatusLabel
            // 
            flagStatusLabel.AutoSize = true;
            flagStatusLabel.Location = new Point(341, 282);
            flagStatusLabel.Name = "flagStatusLabel";
            flagStatusLabel.Size = new Size(64, 15);
            flagStatusLabel.TabIndex = 20;
            flagStatusLabel.Text = "Flag Status";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(130, 357);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(59, 15);
            idLabel.TabIndex = 22;
            idLabel.Text = "Patient_Id";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(111, 375);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 23;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(549, 249);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 24;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(556, 231);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // flagStatusComboBox
            // 
            flagStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flagStatusComboBox.FormattingEnabled = true;
            flagStatusComboBox.Location = new Point(322, 300);
            flagStatusComboBox.Name = "flagStatusComboBox";
            flagStatusComboBox.Size = new Size(100, 23);
            flagStatusComboBox.TabIndex = 26;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(319, 72);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 30);
            errorLabel.TabIndex = 27;
            // 
            // addButton
            // 
            addButton.Location = new Point(440, 282);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 33);
            addButton.TabIndex = 28;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // unselectButton
            // 
            unselectButton.Location = new Point(549, 321);
            unselectButton.Name = "unselectButton";
            unselectButton.Size = new Size(100, 33);
            unselectButton.TabIndex = 30;
            unselectButton.Text = "Unselect";
            unselectButton.UseVisualStyleBackColor = true;
            unselectButton.Click += unselectButton_Click;
            // 
            // stateComboBox
            // 
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(322, 249);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(100, 23);
            stateComboBox.TabIndex = 31;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(655, 183);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(38, 23);
            genderComboBox.TabIndex = 32;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(651, 165);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 33;
            genderLabel.Text = "Gender";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(549, 124);
            birthDateTimePicker.MaxDate = new DateTime(9998, 12, 25, 0, 0, 0, 0);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(100, 23);
            birthDateTimePicker.TabIndex = 34;
            birthDateTimePicker.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // searchLastNameTextBox
            // 
            searchLastNameTextBox.Location = new Point(167, 110);
            searchLastNameTextBox.Name = "searchLastNameTextBox";
            searchLastNameTextBox.Size = new Size(100, 23);
            searchLastNameTextBox.TabIndex = 35;
            // 
            // searchBirthDatePicker
            // 
            searchBirthDatePicker.Format = DateTimePickerFormat.Short;
            searchBirthDatePicker.Location = new Point(111, 40);
            searchBirthDatePicker.Name = "searchBirthDatePicker";
            searchBirthDatePicker.Size = new Size(100, 23);
            searchBirthDatePicker.TabIndex = 36;
            // 
            // searchFirstNameTextBox
            // 
            searchFirstNameTextBox.Location = new Point(54, 110);
            searchFirstNameTextBox.Name = "searchFirstNameTextBox";
            searchFirstNameTextBox.Size = new Size(100, 23);
            searchFirstNameTextBox.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 92);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 40;
            label1.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 92);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 41;
            label2.Text = "Last";
            // 
            // searchByBirthDateCheckBox
            // 
            searchByBirthDateCheckBox.AutoSize = true;
            searchByBirthDateCheckBox.Location = new Point(120, 15);
            searchByBirthDateCheckBox.Name = "searchByBirthDateCheckBox";
            searchByBirthDateCheckBox.Size = new Size(132, 19);
            searchByBirthDateCheckBox.TabIndex = 42;
            searchByBirthDateCheckBox.Text = "Search by Birth Date";
            searchByBirthDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchByNameCheckBox
            // 
            searchByNameCheckBox.AutoSize = true;
            searchByNameCheckBox.Location = new Point(120, 69);
            searchByNameCheckBox.Name = "searchByNameCheckBox";
            searchByNameCheckBox.Size = new Size(112, 19);
            searchByNameCheckBox.TabIndex = 43;
            searchByNameCheckBox.Text = "Search by Name";
            searchByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Enabled = false;
            searchButton.Location = new Point(167, 141);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 44;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resetSearchButton
            // 
            resetSearchButton.Location = new Point(79, 141);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new Size(75, 23);
            resetSearchButton.TabIndex = 45;
            resetSearchButton.Text = "Reset";
            resetSearchButton.UseVisualStyleBackColor = true;
            resetSearchButton.Click += resetSearchButton_Click;
            // 
            // Manage_Patients
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(723, 404);
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
    }
}