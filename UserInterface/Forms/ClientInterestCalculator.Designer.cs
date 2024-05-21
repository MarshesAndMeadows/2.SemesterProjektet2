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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCalculate = new Button();
            txtLoanSize = new TextBox();
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtInterestPerYear = new TextBox();
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
            btnCalculate.Location = new Point(204, 227);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 52);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += BtnCalculateClick;
            // 
            // txtLoanSize
            // 
            txtLoanSize.Location = new Point(139, 87);
            txtLoanSize.Name = "txtLoanSize";
            txtLoanSize.Size = new Size(170, 23);
            txtLoanSize.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 90);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Total loan size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 135);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Interest per year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 182);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 0;
            label3.Text = "Payments pr year:";
            // 
            // txtLoanTermYears
            // 
            txtLoanTermYears.Location = new Point(139, 179);
            txtLoanTermYears.Name = "txtLoanTermYears";
            txtLoanTermYears.Size = new Size(170, 23);
            txtLoanTermYears.TabIndex = 4;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AllowUserToResizeColumns = false;
            dgvResults.AllowUserToResizeRows = false;
            dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvResults.Location = new Point(384, 87);
            dgvResults.Name = "dgvResults";
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new Size(771, 161);
            dgvResults.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Loan Amount";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Annual Interest Rate";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Loan Term (Years)";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Monthly Payment";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Yearly Payment";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Resizable = DataGridViewTriState.False;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 144);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.helperIcon;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(1137, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.lawhouse_high_resolution_logo_transparent;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(173, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtInterestPerYear
            // 
            txtInterestPerYear.Location = new Point(139, 132);
            txtInterestPerYear.Name = "txtInterestPerYear";
            txtInterestPerYear.Size = new Size(170, 23);
            txtInterestPerYear.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(32, 227);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 52);
            btnClear.TabIndex = 5;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(12, 722);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
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
            panel2.Controls.Add(txtLoanSize);
            panel2.Controls.Add(txtInterestPerYear);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLoanTermYears);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(1189, 325);
            panel2.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(lblShowCalculation);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1189, 36);
            panel6.TabIndex = 7;
            // 
            // lblShowCalculation
            // 
            lblShowCalculation.AutoSize = true;
            lblShowCalculation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShowCalculation.Location = new Point(14, 9);
            lblShowCalculation.Name = "lblShowCalculation";
            lblShowCalculation.Size = new Size(52, 21);
            lblShowCalculation.TabIndex = 0;
            lblShowCalculation.Text = "label4";
            lblShowCalculation.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblShowYearlyPayments);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 469);
            panel3.Name = "panel3";
            panel3.Size = new Size(1189, 36);
            panel3.TabIndex = 13;
            // 
            // lblShowYearlyPayments
            // 
            lblShowYearlyPayments.AutoSize = true;
            lblShowYearlyPayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblShowYearlyPayments.Location = new Point(14, 9);
            lblShowYearlyPayments.Name = "lblShowYearlyPayments";
            lblShowYearlyPayments.Size = new Size(52, 21);
            lblShowYearlyPayments.TabIndex = 0;
            lblShowYearlyPayments.Text = "label5";
            lblShowYearlyPayments.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(dgvResultEveryMonth);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 505);
            panel4.Name = "panel4";
            panel4.Size = new Size(1189, 211);
            panel4.TabIndex = 14;
            // 
            // dgvResultEveryMonth
            // 
            dgvResultEveryMonth.AllowUserToAddRows = false;
            dgvResultEveryMonth.AllowUserToDeleteRows = false;
            dgvResultEveryMonth.AllowUserToResizeColumns = false;
            dgvResultEveryMonth.AllowUserToResizeRows = false;
            dgvResultEveryMonth.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultEveryMonth.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResultEveryMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultEveryMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultEveryMonth.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResultEveryMonth.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResultEveryMonth.Location = new Point(32, 26);
            dgvResultEveryMonth.Name = "dgvResultEveryMonth";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvResultEveryMonth.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvResultEveryMonth.RowTemplate.Height = 25;
            dgvResultEveryMonth.Size = new Size(1123, 150);
            dgvResultEveryMonth.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.HeaderText = "January";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Febuary";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "March";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "April";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "May";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "June";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "July";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "August";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "September";
            Column14.Name = "Column14";
            // 
            // Column15
            // 
            Column15.HeaderText = "October";
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "November";
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "December";
            Column17.Name = "Column17";
            // 
            // ClientInterestCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 754);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ClientInterestCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientInterestCalculator";
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
        private TextBox txtLoanSize;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLoanTermYears;
        private DataGridView dgvResults;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtInterestPerYear;
        private Button btnClear;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
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
    }
}