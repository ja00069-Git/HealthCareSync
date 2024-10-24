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
            SuspendLayout();
            // 
            // patientListBox
            // 
            patientListBox.FormattingEnabled = true;
            patientListBox.ItemHeight = 15;
            patientListBox.Location = new Point(51, 12);
            patientListBox.Name = "patientListBox";
            patientListBox.Size = new Size(120, 184);
            patientListBox.TabIndex = 0;
            patientListBox.SelectedIndexChanged += PatientListBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(413, 189);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 33);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(186, 31);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(205, 13);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(326, 13);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(438, 13);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(59, 15);
            birthDateLabel.TabIndex = 5;
            birthDateLabel.Text = "Birth Date";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new Point(205, 72);
            address1Label.Name = "address1Label";
            address1Label.Size = new Size(58, 15);
            address1Label.TabIndex = 6;
            address1Label.Text = "Address 1";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new Point(326, 138);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(55, 15);
            zipcodeLabel.TabIndex = 7;
            zipcodeLabel.Text = "Zip Code";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(221, 138);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(33, 15);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(304, 31);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 9;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(450, 72);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 11;
            cityLabel.Text = "City";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new Point(326, 72);
            address2Label.Name = "address2Label";
            address2Label.Size = new Size(58, 15);
            address2Label.TabIndex = 12;
            address2Label.Text = "Address 2";
            // 
            // address1TextBox
            // 
            address1TextBox.Location = new Point(186, 90);
            address1TextBox.Name = "address1TextBox";
            address1TextBox.Size = new Size(100, 23);
            address1TextBox.TabIndex = 15;
            // 
            // zipTextBox
            // 
            zipTextBox.Location = new Point(304, 156);
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(100, 23);
            zipTextBox.TabIndex = 16;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(413, 90);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 17;
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(304, 90);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(100, 23);
            address2TextBox.TabIndex = 19;
            // 
            // flagStatusLabel
            // 
            flagStatusLabel.AutoSize = true;
            flagStatusLabel.Location = new Point(205, 189);
            flagStatusLabel.Name = "flagStatusLabel";
            flagStatusLabel.Size = new Size(64, 15);
            flagStatusLabel.TabIndex = 20;
            flagStatusLabel.Text = "Flag Status";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(85, 199);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(59, 15);
            idLabel.TabIndex = 22;
            idLabel.Text = "Patient_Id";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(62, 217);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 23;
            idTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(413, 156);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 24;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(420, 138);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // flagStatusComboBox
            // 
            flagStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flagStatusComboBox.FormattingEnabled = true;
            flagStatusComboBox.Location = new Point(186, 207);
            flagStatusComboBox.Name = "flagStatusComboBox";
            flagStatusComboBox.Size = new Size(100, 23);
            flagStatusComboBox.TabIndex = 26;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 8F);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(51, 246);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 13);
            errorLabel.TabIndex = 27;
            // 
            // addButton
            // 
            addButton.Location = new Point(304, 189);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 33);
            addButton.TabIndex = 28;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // unselectButton
            // 
            unselectButton.Location = new Point(413, 228);
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
            stateComboBox.Location = new Point(186, 156);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(100, 23);
            stateComboBox.TabIndex = 31;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(519, 90);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(38, 23);
            genderComboBox.TabIndex = 32;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(515, 72);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 33;
            genderLabel.Text = "Gender";
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(413, 31);
            birthDateTimePicker.MaxDate = new DateTime(9998, 12, 25, 0, 0, 0, 0);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(100, 23);
            birthDateTimePicker.TabIndex = 34;
            birthDateTimePicker.Value = new DateTime(2024, 10, 9, 0, 0, 0, 0);
            // 
            // Manage_Patients
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(567, 270);
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
    }
}