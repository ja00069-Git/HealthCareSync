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
            topPanel = new Panel();
            bottomPanel = new Panel();
            leftPanel = new Panel();
            rightPanel = new Panel();
            enterQueryLabel = new Label();
            viewReportLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Location = new Point(74, 70);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.Size = new Size(783, 30);
            resultDataGridView.TabIndex = 4;
            // 
            // dateRangeLabel
            // 
            dateRangeLabel.AutoSize = true;
            dateRangeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dateRangeLabel.Location = new Point(647, 123);
            dateRangeLabel.Name = "dateRangeLabel";
            dateRangeLabel.Size = new Size(68, 15);
            dateRangeLabel.TabIndex = 5;
            dateRangeLabel.Text = "Date Range";
            // 
            // queryTextBox
            // 
            queryTextBox.AcceptsTab = true;
            queryTextBox.Font = new Font("Microsoft YaHei UI", 10F);
            queryTextBox.ForeColor = SystemColors.HotTrack;
            queryTextBox.Location = new Point(142, 94);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.ScrollBars = ScrollBars.Vertical;
            queryTextBox.Size = new Size(352, 162);
            queryTextBox.TabIndex = 6;
            queryTextBox.TextChanged += queryTextBox_TextChanged;
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Format = DateTimePickerFormat.Short;
            fromDateTimePicker.Location = new Point(573, 162);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(87, 23);
            fromDateTimePicker.TabIndex = 7;
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.CalendarTrailingForeColor = Color.Gray;
            toDateTimePicker.Format = DateTimePickerFormat.Short;
            toDateTimePicker.Location = new Point(699, 162);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(87, 23);
            toDateTimePicker.TabIndex = 8;
            // 
            // viewReportButton
            // 
            viewReportButton.BackColor = Color.IndianRed;
            viewReportButton.FlatStyle = FlatStyle.Flat;
            viewReportButton.Font = new Font("Showcard Gothic", 12F);
            viewReportButton.ForeColor = Color.White;
            viewReportButton.Location = new Point(633, 218);
            viewReportButton.Name = "viewReportButton";
            viewReportButton.Size = new Size(93, 31);
            viewReportButton.TabIndex = 9;
            viewReportButton.Text = "View Report";
            viewReportButton.UseVisualStyleBackColor = false;
            viewReportButton.Click += viewReportButton_Click;
            // 
            // executeQueryButton
            // 
            executeQueryButton.BackColor = Color.IndianRed;
            executeQueryButton.Enabled = false;
            executeQueryButton.FlatStyle = FlatStyle.Flat;
            executeQueryButton.Font = new Font("Showcard Gothic", 12F);
            executeQueryButton.ForeColor = Color.White;
            executeQueryButton.Location = new Point(271, 288);
            executeQueryButton.Name = "executeQueryButton";
            executeQueryButton.Size = new Size(97, 33);
            executeQueryButton.TabIndex = 10;
            executeQueryButton.Text = "Execute Query";
            executeQueryButton.UseVisualStyleBackColor = false;
            executeQueryButton.Click += executeQueryButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            resultLabel.ForeColor = Color.IndianRed;
            resultLabel.Location = new Point(455, 38);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(66, 25);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "Result";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            fromLabel.Location = new Point(600, 144);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(33, 15);
            fromLabel.TabIndex = 12;
            fromLabel.Text = "from";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            toLabel.Location = new Point(735, 144);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(18, 15);
            toLabel.TabIndex = 13;
            toLabel.Text = "to";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.IndianRed;
            topPanel.Location = new Point(142, 94);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(352, 1);
            topPanel.TabIndex = 78;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.IndianRed;
            bottomPanel.Location = new Point(142, 255);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(352, 1);
            bottomPanel.TabIndex = 79;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.IndianRed;
            leftPanel.Location = new Point(142, 94);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(1, 162);
            leftPanel.TabIndex = 80;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.IndianRed;
            rightPanel.Location = new Point(493, 94);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1, 162);
            rightPanel.TabIndex = 81;
            // 
            // enterQueryLabel
            // 
            enterQueryLabel.AutoSize = true;
            enterQueryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            enterQueryLabel.ForeColor = Color.IndianRed;
            enterQueryLabel.Location = new Point(261, 66);
            enterQueryLabel.Name = "enterQueryLabel";
            enterQueryLabel.Size = new Size(119, 25);
            enterQueryLabel.TabIndex = 83;
            enterQueryLabel.Text = "Enter Query";
            // 
            // viewReportLabel
            // 
            viewReportLabel.AutoSize = true;
            viewReportLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            viewReportLabel.ForeColor = Color.IndianRed;
            viewReportLabel.Location = new Point(550, 66);
            viewReportLabel.Name = "viewReportLabel";
            viewReportLabel.Size = new Size(290, 25);
            viewReportLabel.TabIndex = 84;
            viewReportLabel.Text = "View Report During Timeframe";
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 349);
            Controls.Add(viewReportLabel);
            Controls.Add(enterQueryLabel);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
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
        private Panel topPanel;
        private Panel bottomPanel;
        private Panel leftPanel;
        private Panel rightPanel;
        private Label enterQueryLabel;
        private Label viewReportLabel;
    }
}