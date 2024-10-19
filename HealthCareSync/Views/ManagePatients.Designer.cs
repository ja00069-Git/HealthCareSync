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
            birthDateTextBox = new TextBox();
            cityLabel = new Label();
            address2Label = new Label();
            address1TextBox = new TextBox();
            zipTextBox = new TextBox();
            cityTextBox = new TextBox();
            stateTextBox = new TextBox();
            address2TextBox = new TextBox();
            flagStatusLabel = new Label();
            flagStatusTextBox = new TextBox();
            idLabel = new Label();
            idTextBox = new TextBox();
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
            saveButton.Location = new Point(413, 207);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 40);
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
            zipcodeLabel.Location = new Point(326, 72);
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
            // birthDateTextBox
            // 
            birthDateTextBox.Location = new Point(413, 31);
            birthDateTextBox.Name = "birthDateTextBox";
            birthDateTextBox.Size = new Size(100, 23);
            birthDateTextBox.TabIndex = 10;
            birthDateTextBox.TextAlign = HorizontalAlignment.Center;
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
            address2Label.Location = new Point(326, 138);
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
            zipTextBox.Location = new Point(304, 90);
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
            // stateTextBox
            // 
            stateTextBox.Location = new Point(186, 156);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(100, 23);
            stateTextBox.TabIndex = 18;
            // 
            // address2TextBox
            // 
            address2TextBox.Location = new Point(304, 156);
            address2TextBox.Name = "address2TextBox";
            address2TextBox.Size = new Size(100, 23);
            address2TextBox.TabIndex = 19;
            // 
            // flagStatusLabel
            // 
            flagStatusLabel.AutoSize = true;
            flagStatusLabel.Location = new Point(433, 138);
            flagStatusLabel.Name = "flagStatusLabel";
            flagStatusLabel.Size = new Size(64, 15);
            flagStatusLabel.TabIndex = 20;
            flagStatusLabel.Text = "Flag Status";
            // 
            // flagStatusTextBox
            // 
            flagStatusTextBox.Location = new Point(413, 156);
            flagStatusTextBox.Name = "flagStatusTextBox";
            flagStatusTextBox.Size = new Size(100, 23);
            flagStatusTextBox.TabIndex = 21;
            flagStatusTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(104, 199);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 22;
            idLabel.Text = "Id";
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
            // Manage_Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(561, 270);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(flagStatusTextBox);
            Controls.Add(flagStatusLabel);
            Controls.Add(address2TextBox);
            Controls.Add(stateTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(zipTextBox);
            Controls.Add(address1TextBox);
            Controls.Add(address2Label);
            Controls.Add(cityLabel);
            Controls.Add(birthDateTextBox);
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
        private TextBox birthDateTextBox;
        private Label cityLabel;
        private Label address2Label;
        private TextBox address1TextBox;
        private TextBox zipTextBox;
        private TextBox cityTextBox;
        private TextBox stateTextBox;
        private TextBox address2TextBox;
        private Label flagStatusLabel;
        private TextBox flagStatusTextBox;
        private Label idLabel;
        private TextBox idTextBox;
    }
}