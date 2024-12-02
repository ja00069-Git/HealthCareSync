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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCareSync.Views
{
    public partial class GenerateReport : Form
    {
        private static readonly string ERROR_QUERY = "Cannot execute query.";
        private static readonly string ERROR_DATES = "From date must be before To Date.";
        private static readonly string NO_VISITS = "There were no visits during the specified timeframe.";

        private int DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX;
        private int TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX;
        private int VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX;
        private int EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX;
        private int LEFT_PANEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int RIGHT_PANEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int TOP_PANEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int BOTTOM_PANEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int ENTER_QUERY_LABEL_Y_DIFFERENCE_TO_TEXTBOX;
        private int VIEW_REPORT_LABEL_Y_DIFFERENCE_TO_TEXTBOX;

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
            int calculateYDifference(Control targetControl)
            {
                return this.queryTextBox.Location.Y - targetControl.Location.Y;
            }

            this.DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.dateRangeLabel);
            this.FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.fromLabel);
            this.TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.toLabel);
            this.FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.fromDateTimePicker);
            this.TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.toDateTimePicker);
            this.VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.viewReportButton);
            this.EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.executeQueryButton);
            this.LEFT_PANEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.leftPanel);
            this.RIGHT_PANEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.rightPanel);
            this.TOP_PANEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.topPanel);
            this.BOTTOM_PANEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.bottomPanel);
            this.ENTER_QUERY_LABEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.enterQueryLabel);
            this.VIEW_REPORT_LABEL_Y_DIFFERENCE_TO_TEXTBOX = calculateYDifference(this.viewReportLabel);
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

            if (table.Rows.Count == 0)
            {
                MessageBox.Show(NO_VISITS, "Could not find visits", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.resultDataGridView.Visible = true;
            this.resultLabel.Visible = true;
            this.resultDataGridView.DataSource = table;
            this.AdjustFormAndDataGridViewSize();
            this.moveTextBoxY(this.resultDataGridView.Bottom + 250);
            this.ParentForm!.Height = Math.Max(this.executeQueryButton.Bottom + 50, 400);
            this.queryTextBox.Clear();
        }

        private void AdjustFormAndDataGridViewSize()
        {
            int headerHeight = this.resultDataGridView.ColumnHeadersHeight;
            int rowHeight = this.resultDataGridView.RowTemplate.Height;
            int totalRowsHeight = this.resultDataGridView.Rows.Count * rowHeight;

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
            void updateControlY(Control control, int yDifference)
            {
                control.Location = new Point(control.Location.X, y - yDifference);
            }

            this.queryTextBox.Location = new Point(this.queryTextBox.Location.X, y);

            updateControlY(this.executeQueryButton, EXECUTE_QUERY_BUTTON_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.dateRangeLabel, DATE_RANGE_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.fromLabel, FROM_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.toLabel, TO_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.fromDateTimePicker, FROM_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.toDateTimePicker, TO_DATE_PICKER_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.viewReportButton, VIEW_REPORT_BUTTON_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.topPanel, TOP_PANEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.bottomPanel, BOTTOM_PANEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.leftPanel, LEFT_PANEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.rightPanel, RIGHT_PANEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.enterQueryLabel, ENTER_QUERY_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
            updateControlY(this.viewReportLabel, VIEW_REPORT_LABEL_Y_DIFFERENCE_TO_TEXTBOX);
        }

    }
}
