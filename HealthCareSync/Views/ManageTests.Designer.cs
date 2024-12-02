namespace HealthCareSync.Views
{
    partial class ManageTests
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
            patient_listBox = new ListBox();
            lab_test_listBox = new ListBox();
            testNameLabel = new Label();
            test_name_textBox = new TextBox();
            test_code_label = new Label();
            textBox1 = new TextBox();
            low_value_textBox = new TextBox();
            high_value_textBox = new TextBox();
            unit_measurement_textBox = new TextBox();
            low_value_label = new Label();
            high_value_label = new Label();
            unit_messurement_label = new Label();
            add_button = new Button();
            delete_button = new Button();
            clear_button = new Button();
            panel7 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // patient_listBox
            // 
            patient_listBox.FormattingEnabled = true;
            patient_listBox.ItemHeight = 25;
            patient_listBox.Location = new Point(97, 90);
            patient_listBox.Margin = new Padding(4, 5, 4, 5);
            patient_listBox.Name = "patient_listBox";
            patient_listBox.Size = new Size(236, 454);
            patient_listBox.TabIndex = 1;
            patient_listBox.SelectedIndexChanged += patient_listBox_SelectedIndexChanged;
            // 
            // lab_test_listBox
            // 
            lab_test_listBox.FormattingEnabled = true;
            lab_test_listBox.ItemHeight = 25;
            lab_test_listBox.Location = new Point(370, 84);
            lab_test_listBox.Margin = new Padding(4, 5, 4, 5);
            lab_test_listBox.Name = "lab_test_listBox";
            lab_test_listBox.Size = new Size(225, 454);
            lab_test_listBox.TabIndex = 2;
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            testNameLabel.Location = new Point(635, 87);
            testNameLabel.Margin = new Padding(4, 0, 4, 0);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new Size(111, 25);
            testNameLabel.TabIndex = 3;
            testNameLabel.Text = "Test Name :";
            // 
            // test_name_textBox
            // 
            test_name_textBox.BackColor = SystemColors.Info;
            test_name_textBox.BorderStyle = BorderStyle.None;
            test_name_textBox.Location = new Point(751, 86);
            test_name_textBox.Margin = new Padding(4, 5, 4, 5);
            test_name_textBox.Name = "test_name_textBox";
            test_name_textBox.Size = new Size(151, 24);
            test_name_textBox.TabIndex = 4;
            // 
            // test_code_label
            // 
            test_code_label.AutoSize = true;
            test_code_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            test_code_label.Location = new Point(981, 87);
            test_code_label.Margin = new Padding(4, 0, 4, 0);
            test_code_label.Name = "test_code_label";
            test_code_label.Size = new Size(104, 25);
            test_code_label.TabIndex = 5;
            test_code_label.Text = "Test Code :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(1093, 88);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 24);
            textBox1.TabIndex = 6;
            // 
            // low_value_textBox
            // 
            low_value_textBox.BackColor = SystemColors.Info;
            low_value_textBox.BorderStyle = BorderStyle.None;
            low_value_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            low_value_textBox.Location = new Point(751, 201);
            low_value_textBox.Margin = new Padding(4, 5, 4, 5);
            low_value_textBox.Name = "low_value_textBox";
            low_value_textBox.Size = new Size(151, 24);
            low_value_textBox.TabIndex = 7;
            // 
            // high_value_textBox
            // 
            high_value_textBox.BackColor = SystemColors.Info;
            high_value_textBox.BorderStyle = BorderStyle.None;
            high_value_textBox.Location = new Point(1093, 198);
            high_value_textBox.Margin = new Padding(4, 5, 4, 5);
            high_value_textBox.Name = "high_value_textBox";
            high_value_textBox.Size = new Size(151, 24);
            high_value_textBox.TabIndex = 8;
            // 
            // unit_measurement_textBox
            // 
            unit_measurement_textBox.BackColor = SystemColors.Info;
            unit_measurement_textBox.BorderStyle = BorderStyle.None;
            unit_measurement_textBox.Location = new Point(811, 307);
            unit_measurement_textBox.Margin = new Padding(4, 5, 4, 5);
            unit_measurement_textBox.Name = "unit_measurement_textBox";
            unit_measurement_textBox.Size = new Size(91, 24);
            unit_measurement_textBox.TabIndex = 9;
            // 
            // low_value_label
            // 
            low_value_label.AutoSize = true;
            low_value_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            low_value_label.Location = new Point(635, 207);
            low_value_label.Margin = new Padding(4, 0, 4, 0);
            low_value_label.Name = "low_value_label";
            low_value_label.Size = new Size(108, 25);
            low_value_label.TabIndex = 10;
            low_value_label.Text = "Low Value :";
            // 
            // high_value_label
            // 
            high_value_label.AutoSize = true;
            high_value_label.BackColor = SystemColors.Window;
            high_value_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            high_value_label.Location = new Point(981, 197);
            high_value_label.Margin = new Padding(4, 0, 4, 0);
            high_value_label.Name = "high_value_label";
            high_value_label.Size = new Size(115, 25);
            high_value_label.TabIndex = 11;
            high_value_label.Text = "High Value :";
            // 
            // unit_messurement_label
            // 
            unit_messurement_label.AutoSize = true;
            unit_messurement_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unit_messurement_label.Location = new Point(635, 307);
            unit_messurement_label.Margin = new Padding(4, 0, 4, 0);
            unit_messurement_label.Name = "unit_messurement_label";
            unit_messurement_label.Size = new Size(180, 25);
            unit_messurement_label.TabIndex = 12;
            unit_messurement_label.Text = "Unit Measurement :";
            // 
            // add_button
            // 
            add_button.BackColor = Color.IndianRed;
            add_button.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.Location = new Point(751, 452);
            add_button.Margin = new Padding(4, 5, 4, 5);
            add_button.Name = "add_button";
            add_button.Size = new Size(99, 51);
            add_button.TabIndex = 13;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            delete_button.BackColor = Color.IndianRed;
            delete_button.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_button.Location = new Point(928, 452);
            delete_button.Margin = new Padding(4, 5, 4, 5);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(99, 51);
            delete_button.TabIndex = 14;
            delete_button.Text = "DELETE";
            delete_button.UseVisualStyleBackColor = false;
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.IndianRed;
            clear_button.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_button.Location = new Point(1105, 452);
            clear_button.Margin = new Padding(4, 5, 4, 5);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(99, 51);
            clear_button.TabIndex = 15;
            clear_button.Text = "CLEAR";
            clear_button.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Location = new Point(635, 117);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(271, 1);
            panel7.TabIndex = 84;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(351, 29);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 547);
            panel1.TabIndex = 85;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(992, 117);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 1);
            panel2.TabIndex = 85;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Location = new Point(981, 117);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 1);
            panel3.TabIndex = 85;
            // 
            // panel4
            // 
            panel4.BackColor = Color.IndianRed;
            panel4.Location = new Point(635, 232);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 1);
            panel4.TabIndex = 86;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Location = new Point(981, 232);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 1);
            panel5.TabIndex = 85;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Location = new Point(635, 338);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 1);
            panel6.TabIndex = 87;
            // 
            // panel8
            // 
            panel8.BackColor = Color.IndianRed;
            panel8.Location = new Point(618, 29);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 547);
            panel8.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 41);
            label2.TabIndex = 88;
            label2.Text = "Patients";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(419, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 45);
            label3.TabIndex = 89;
            label3.Text = "Tests";
            // 
            // ManageTests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1308, 615);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(clear_button);
            Controls.Add(delete_button);
            Controls.Add(add_button);
            Controls.Add(unit_messurement_label);
            Controls.Add(high_value_label);
            Controls.Add(low_value_label);
            Controls.Add(unit_measurement_textBox);
            Controls.Add(high_value_textBox);
            Controls.Add(low_value_textBox);
            Controls.Add(textBox1);
            Controls.Add(test_code_label);
            Controls.Add(test_name_textBox);
            Controls.Add(testNameLabel);
            Controls.Add(lab_test_listBox);
            Controls.Add(patient_listBox);
            ForeColor = SystemColors.MenuText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "ManageTests";
            Text = "ManageTests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox patient_listBox;
        private ListBox lab_test_listBox;
        private Label testNameLabel;
        private TextBox test_name_textBox;
        private Label test_code_label;
        private TextBox textBox1;
        private TextBox low_value_textBox;
        private TextBox high_value_textBox;
        private TextBox unit_measurement_textBox;
        private Label low_value_label;
        private Label high_value_label;
        private Label unit_messurement_label;
        private Button add_button;
        private Button delete_button;
        private Button clear_button;
        private Panel panel7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Label label2;
        private Label label3;
    }
}