using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class GenerateReport : Form
    {
        private static readonly string ERROR_QUERY = "Cannot execute query.";
        private static readonly string ERROR_DATES = "From date must be before To Date.";

        private int DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX;
        private int TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX;
        private int VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX;
        private int EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX;

        private GenerateReportViewModel viewmodel;

        public GenerateReport()
        {
            InitializeComponent();
            this.viewmodel = new GenerateReportViewModel();
            this.resultDataGridView.Visible = false;
            this.resultLabel.Visible = false;
            this.setupDataGridView();
            this.initializeControlsYDifference();
        }

        private void initializeControlsYDifference()
        {
            this.DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.dateRangeLabel.Location.Y;
            this.FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.fromLabel.Location.Y;
            this.TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.toLabel.Location.Y;
            this.FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.fromDateTimePicker.Location.Y;
            this.TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.toDateTimePicker.Location.Y;  
            this.VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.viewReportButton.Location.Y;
            this.EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX = this.queryTextBox.Location.Y - this.executeQueryButton.Location.Y;
        }

        private void setupDataGridView()
        {
            this.resultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.ReadOnly = true;
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            string query = this.queryTextBox.Text;

            var tuple = this.viewmodel.ExecuteQuery(query);

            if (tuple.Item1 == null)
            {
                MessageBox.Show(tuple.Item2, ERROR_QUERY, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.resultDataGridView.Visible = true;
                this.resultLabel.Visible = true;
                this.resultDataGridView.DataSource = tuple.Item1;
                this.AdjustFormAndDataGridViewSize();
                this.moveTextBoxY(this.resultDataGridView.Bottom + 50);
                this.ParentForm!.Height = Math.Max(this.executeQueryButton.Bottom + 50, 400);
            }
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            var fromDate = this.fromDateTimePicker.Value;
            var toDate = this.toDateTimePicker.Value;

            if (fromDate.Date > toDate.Date)
            {
                MessageBox.Show(ERROR_DATES, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var table = this.viewmodel.ViewReport(fromDate, toDate);

            this.resultDataGridView.Visible = true;
            this.resultLabel.Visible = true;
            this.resultDataGridView.DataSource = table;
            this.AdjustFormAndDataGridViewSize();
            this.moveTextBoxY(this.resultDataGridView.Bottom + 50);
            this.ParentForm!.Height = Math.Max(this.executeQueryButton.Bottom + 50, 400);     
            this.queryTextBox.Clear();
        }

        private void AdjustFormAndDataGridViewSize()
        {
            int headerHeight = this.resultDataGridView.ColumnHeadersHeight;
            int rowHeight = this.resultDataGridView.RowTemplate.Height;
            int totalRowsHeight = this.resultDataGridView.Rows.Count * rowHeight;
            int scrollbarHeight = SystemInformation.HorizontalScrollBarHeight;

            int calculatedHeight = headerHeight + totalRowsHeight;

            if (calculatedHeight > 800)
            {
                calculatedHeight = 800;
                this.resultDataGridView.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                this.resultDataGridView.ScrollBars = ScrollBars.None;
            }

            this.resultDataGridView.Height = calculatedHeight;
        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(queryTextBox.Text))
            {
                this.executeQueryButton.Enabled = true;
            }
            else
            {
                this.executeQueryButton.Enabled = false;
            }
        }

        private void moveTextBoxY(int y)
        {
            this.queryTextBox.Location = new Point(this.queryTextBox.Location.X, y);
            this.executeQueryButton.Location = new Point(this.executeQueryButton.Location.X, y - EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX);
            this.dateRangeLabel.Location = new Point(this.dateRangeLabel.Location.X, y - DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            this.fromLabel.Location = new Point(this.fromLabel.Location.X, y - FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            this.toLabel.Location = new Point(this.toLabel.Location.X, y - TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            this.fromDateTimePicker.Location = new Point(this.fromDateTimePicker.Location.X, y - FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX);
            this.toDateTimePicker.Location = new Point(this.toDateTimePicker.Location.X, y - TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX);
            this.viewReportButton.Location = new Point(this.viewReportButton.Location.X, y - VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX);
        }
    }
}
