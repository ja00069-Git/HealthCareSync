namespace HealthCareSync.Views
{
    partial class GenerateReport
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
            resultDataGridView = new DataGridView();
            dateRangeLabel = new Label();
            queryTextBox = new TextBox();
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            viewReportButton = new Button();
            executeQueryButton = new Button();
            resultLabel = new Label();
            fromLabel = new Label();
            toLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Location = new Point(74, 70);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.Size = new Size(808, 30);
            resultDataGridView.TabIndex = 4;
            // 
            // dateRangeLabel
            // 
            dateRangeLabel.AutoSize = true;
            dateRangeLabel.Location = new Point(647, 67);
            dateRangeLabel.Name = "dateRangeLabel";
            dateRangeLabel.Size = new Size(67, 15);
            dateRangeLabel.TabIndex = 5;
            dateRangeLabel.Text = "Date Range";
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(142, 38);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(352, 162);
            queryTextBox.TabIndex = 6;
            queryTextBox.TextChanged += queryTextBox_TextChanged;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(573, 106);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(87, 23);
            fromDateTimePicker.TabIndex = 7;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(699, 106);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(87, 23);
            toDateTimePicker.TabIndex = 8;
            // 
            // viewReportButton
            // 
            viewReportButton.Location = new Point(633, 162);
            viewReportButton.Name = "viewReportButton";
            viewReportButton.Size = new Size(93, 23);
            viewReportButton.TabIndex = 9;
            viewReportButton.Text = "View Report";
            viewReportButton.UseVisualStyleBackColor = true;
            viewReportButton.Click += viewReportButton_Click;
            // 
            // executeQueryButton
            // 
            executeQueryButton.Enabled = false;
            executeQueryButton.Location = new Point(271, 232);
            executeQueryButton.Name = "executeQueryButton";
            executeQueryButton.Size = new Size(97, 23);
            executeQueryButton.TabIndex = 10;
            executeQueryButton.Text = "Execute Query";
            executeQueryButton.UseVisualStyleBackColor = true;
            executeQueryButton.Click += executeQueryButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(455, 38);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(39, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "Result";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Location = new Point(600, 88);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(33, 15);
            fromLabel.TabIndex = 12;
            fromLabel.Text = "from";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Location = new Point(735, 88);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(18, 15);
            toLabel.TabIndex = 13;
            toLabel.Text = "to";
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 277);
            Controls.Add(toLabel);
            Controls.Add(fromLabel);
            Controls.Add(resultLabel);
            Controls.Add(executeQueryButton);
            Controls.Add(viewReportButton);
            Controls.Add(toDateTimePicker);
            Controls.Add(fromDateTimePicker);
            Controls.Add(queryTextBox);
            Controls.Add(dateRangeLabel);
            Controls.Add(resultDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "GenerateReport";
            Text = "GenerateReport";
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView resultDataGridView;
        private Label dateRangeLabel;
        private TextBox queryTextBox;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Button viewReportButton;
        private Button executeQueryButton;
        private Label resultLabel;
        private Label fromLabel;
        private Label toLabel;
    }
}