namespace UserInterface.Forms
{
    partial class ClientInterestCalculator
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnCalculate = new Button();
            txtTotalLoanAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLoanTermYears = new TextBox();
            dgvResults = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtAnnualInterestRate = new TextBox();
            btnClear = new Button();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            lblShowCalculation = new Label();
            panel3 = new Panel();
            lblShowYearlyPayments = new Label();
            panel4 = new Panel();
            dgvResultEveryMonth = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultEveryMonth).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(238, 227);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 52);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculateClick;
            // 
            // txtTotalLoanAmount
            // 
            txtTotalLoanAmount.Location = new Point(173, 90);
            txtTotalLoanAmount.Name = "txtTotalLoanAmount";
            txtTotalLoanAmount.Size = new Size(170, 27);
            txtTotalLoanAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 90);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Total loan size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 135);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 0;
            label2.Text = "Interest per year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 182);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Term (years):";
            // 
            // txtLoanTermYears
            // 
            txtLoanTermYears.Location = new Point(173, 182);
            txtLoanTermYears.Name = "txtLoanTermYears";
            txtLoanTermYears.Size = new Size(170, 27);
            txtLoanTermYears.TabIndex = 4;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeColumns = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.BackgroundColor = SystemColors.Control;
            dgvResults.BorderStyle = BorderStyle.None;
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column18 });
            dgvResults.Location = new Point(419, 87);
            dgvResults.MultiSelect = false;
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.RowTemplate.Height = 25;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(1107, 115);
            dgvResults.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Loan Amount";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.ToolTipText = "This is the amount you a borrowing";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Annual Interest Rate";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.ToolTipText = "This is the annual interest rate";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Loan Term (Years)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.ToolTipText = "How many years";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Monthly Payment";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.ToolTipText = "You monthly repayment";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Yearly Payment";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            Column5.ToolTipText = "Your yearly repayment";
            // 
            // Column18
            // 
            Column18.HeaderText = "Yearly interest";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 125;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1556, 141);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.helperIcon;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(1504, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += HelpIconClick;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.lawhouse_high_resolution_logo_transparent;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(348, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtAnnualInterestRate
            // 
            txtAnnualInterestRate.Location = new Point(173, 135);
            txtAnnualInterestRate.Name = "txtAnnualInterestRate";
            txtAnnualInterestRate.Size = new Size(170, 27);
            txtAnnualInterestRate.TabIndex = 3;
            txtAnnualInterestRate.TextChanged += txtAnnualInterestRate_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(32, 227);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 52);
            btnClear.TabIndex = 5;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClearClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(12, 737);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(dgvResults);
            panel2.Controls.Add(btnCalculate);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(txtTotalLoanAmount);
            panel2.Controls.Add(txtAnnualInterestRate);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLoanTermYears);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(1556, 325);
            panel2.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(lblShowCalculation);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1556, 36);
            panel6.TabIndex = 7;
            // 
            // lblShowCalculation
            // 
            lblShowCalculation.AutoSize = true;
            lblShowCalculation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShowCalculation.Location = new Point(14, 2);
            lblShowCalculation.Name = "lblShowCalculation";
            lblShowCalculation.Size = new Size(65, 28);
            lblShowCalculation.TabIndex = 0;
            lblShowCalculation.Text = "label4";
            lblShowCalculation.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblShowYearlyPayments);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 466);
            panel3.Name = "panel3";
            panel3.Size = new Size(1556, 36);
            panel3.TabIndex = 13;
            // 
            // lblShowYearlyPayments
            // 
            lblShowYearlyPayments.AutoSize = true;
            lblShowYearlyPayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShowYearlyPayments.Location = new Point(14, 2);
            lblShowYearlyPayments.Name = "lblShowYearlyPayments";
            lblShowYearlyPayments.Size = new Size(65, 28);
            lblShowYearlyPayments.TabIndex = 0;
            lblShowYearlyPayments.Text = "label5";
            lblShowYearlyPayments.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(dgvResultEveryMonth);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 502);
            panel4.Name = "panel4";
            panel4.Size = new Size(1556, 211);
            panel4.TabIndex = 14;
            // 
            // dgvResultEveryMonth
            // 
            dgvResultEveryMonth.AllowUserToAddRows = false;
            dgvResultEveryMonth.AllowUserToDeleteRows = false;
            dgvResultEveryMonth.AllowUserToResizeColumns = false;
            dgvResultEveryMonth.AllowUserToResizeRows = false;
            dgvResultEveryMonth.BackgroundColor = SystemColors.Control;
            dgvResultEveryMonth.BorderStyle = BorderStyle.None;
            dgvResultEveryMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvResultEveryMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvResultEveryMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultEveryMonth.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvResultEveryMonth.DefaultCellStyle = dataGridViewCellStyle5;
            dgvResultEveryMonth.Location = new Point(32, 26);
            dgvResultEveryMonth.MultiSelect = false;
            dgvResultEveryMonth.Name = "dgvResultEveryMonth";
            dgvResultEveryMonth.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvResultEveryMonth.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvResultEveryMonth.RowHeadersWidth = 51;
            dgvResultEveryMonth.RowTemplate.Height = 25;
            dgvResultEveryMonth.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvResultEveryMonth.Size = new Size(1494, 150);
            dgvResultEveryMonth.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.HeaderText = "January";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "Febuary";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 121;
            // 
            // Column8
            // 
            Column8.HeaderText = "March";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "April";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 120;
            // 
            // Column10
            // 
            Column10.HeaderText = "May";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 120;
            // 
            // Column11
            // 
            Column11.HeaderText = "June";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 121;
            // 
            // Column12
            // 
            Column12.HeaderText = "July";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 120;
            // 
            // Column13
            // 
            Column13.HeaderText = "August";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 120;
            // 
            // Column14
            // 
            Column14.HeaderText = "September";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 120;
            // 
            // Column15
            // 
            Column15.HeaderText = "October";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 121;
            // 
            // Column16
            // 
            Column16.HeaderText = "November";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 120;
            // 
            // Column17
            // 
            Column17.HeaderText = "December";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 120;
            // 
            // ClientInterestCalculator
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1556, 772);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ClientInterestCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientInterestCalculatorClick";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultEveryMonth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtTotalLoanAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLoanTermYears;
        private DataGridView dgvResults;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtAnnualInterestRate;
        private Button btnClear;
        private ErrorProvider errorProvider1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Label lblShowYearlyPayments;
        private Label lblShowCalculation;
        private Panel panel4;
        private DataGridView dgvResultEveryMonth;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column18;
    }
}