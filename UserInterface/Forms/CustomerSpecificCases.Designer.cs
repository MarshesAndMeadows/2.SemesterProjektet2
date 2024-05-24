namespace UserInterface.Forms
{
    partial class CustomerSpecificCases
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
            panel4 = new Panel();
            lblCaseName = new Label();
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            lblLawyerName = new Label();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            pnlCaseDescription = new Panel();
            lblCaseDescription = new Label();
            lblDescriptionCase = new Label();
            checkboxCasedClosed = new CheckBox();
            lblEmployeeOnCaseLeft = new Label();
            lblIsFinishedLeft = new Label();
            lblStartDateLeft = new Label();
            lblEstimatedEndDateLeft = new Label();
            btnBack = new Button();
            dgvAppServices = new DataGridView();
            serviceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lawyerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitCostActualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startPaymentActualDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            servicePerformedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiAppliedServiceBindingSource = new BindingSource(components);
            panel1 = new Panel();
            btnPrint = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            pnlCaseDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(lblCaseName);
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 12);
            panel4.MinimumSize = new Size(769, 360);
            panel4.Name = "panel4";
            panel4.Size = new Size(673, 270);
            panel4.TabIndex = 3;
            // 
            // lblCaseName
            // 
            lblCaseName.AutoSize = true;
            lblCaseName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseName.Location = new Point(122, 5);
            lblCaseName.Name = "lblCaseName";
            lblCaseName.Size = new Size(174, 46);
            lblCaseName.TabIndex = 2;
            lblCaseName.Text = "caseName";
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseTitle.Location = new Point(17, 4);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(79, 37);
            lblCaseTitle.TabIndex = 1;
            lblCaseTitle.Text = "Case:";
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 56);
            panel5.MinimumSize = new Size(766, 301);
            panel5.Name = "panel5";
            panel5.Size = new Size(670, 226);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.AutoSize = true;
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(lblLawyerName);
            panel6.Controls.Add(dtpEnd);
            panel6.Controls.Add(dtpStart);
            panel6.Controls.Add(pnlCaseDescription);
            panel6.Controls.Add(lblDescriptionCase);
            panel6.Controls.Add(checkboxCasedClosed);
            panel6.Controls.Add(lblEmployeeOnCaseLeft);
            panel6.Controls.Add(lblIsFinishedLeft);
            panel6.Controls.Add(lblStartDateLeft);
            panel6.Controls.Add(lblEstimatedEndDateLeft);
            panel6.Location = new Point(19, 21);
            panel6.MinimumSize = new Size(730, 263);
            panel6.Name = "panel6";
            panel6.Size = new Size(639, 197);
            panel6.TabIndex = 0;
            // 
            // lblLawyerName
            // 
            lblLawyerName.AutoSize = true;
            lblLawyerName.Location = new Point(74, 11);
            lblLawyerName.Name = "lblLawyerName";
            lblLawyerName.Size = new Size(92, 20);
            lblLawyerName.TabIndex = 26;
            lblLawyerName.Text = "lawyerName";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(477, 58);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 25;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(477, 11);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 24;
            // 
            // pnlCaseDescription
            // 
            pnlCaseDescription.AutoSize = true;
            pnlCaseDescription.BorderStyle = BorderStyle.FixedSingle;
            pnlCaseDescription.Controls.Add(lblCaseDescription);
            pnlCaseDescription.Location = new Point(3, 142);
            pnlCaseDescription.Name = "pnlCaseDescription";
            pnlCaseDescription.Size = new Size(724, 118);
            pnlCaseDescription.TabIndex = 23;
            // 
            // lblCaseDescription
            // 
            lblCaseDescription.AutoSize = true;
            lblCaseDescription.Location = new Point(3, 0);
            lblCaseDescription.MaximumSize = new Size(585, 110);
            lblCaseDescription.Name = "lblCaseDescription";
            lblCaseDescription.Size = new Size(50, 20);
            lblCaseDescription.TabIndex = 0;
            lblCaseDescription.Text = "label1";
            // 
            // lblDescriptionCase
            // 
            lblDescriptionCase.AutoSize = true;
            lblDescriptionCase.Location = new Point(9, 89);
            lblDescriptionCase.Name = "lblDescriptionCase";
            lblDescriptionCase.Size = new Size(128, 20);
            lblDescriptionCase.TabIndex = 12;
            lblDescriptionCase.Text = "Note from lawyer:";
            // 
            // checkboxCasedClosed
            // 
            checkboxCasedClosed.AutoSize = true;
            checkboxCasedClosed.Enabled = false;
            checkboxCasedClosed.Location = new Point(110, 91);
            checkboxCasedClosed.Name = "checkboxCasedClosed";
            checkboxCasedClosed.Size = new Size(15, 14);
            checkboxCasedClosed.TabIndex = 10;
            checkboxCasedClosed.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeOnCaseLeft
            // 
            lblEmployeeOnCaseLeft.AutoSize = true;
            lblEmployeeOnCaseLeft.Location = new Point(9, 8);
            lblEmployeeOnCaseLeft.Name = "lblEmployeeOnCaseLeft";
            lblEmployeeOnCaseLeft.Size = new Size(47, 15);
            lblEmployeeOnCaseLeft.TabIndex = 8;
            lblEmployeeOnCaseLeft.Text = "Lawyer:";
            // 
            // lblIsFinishedLeft
            // 
            lblIsFinishedLeft.AutoSize = true;
            lblIsFinishedLeft.Location = new Point(9, 66);
            lblIsFinishedLeft.Name = "lblIsFinishedLeft";
            lblIsFinishedLeft.Size = new Size(74, 15);
            lblIsFinishedLeft.TabIndex = 6;
            lblIsFinishedLeft.Text = "Case closed?";
            // 
            // lblStartDateLeft
            // 
            lblStartDateLeft.AutoSize = true;
            lblStartDateLeft.Location = new Point(394, 16);
            lblStartDateLeft.Name = "lblStartDateLeft";
            lblStartDateLeft.Size = new Size(60, 15);
            lblStartDateLeft.TabIndex = 2;
            lblStartDateLeft.Text = "Start date:";
            // 
            // lblEstimatedEndDateLeft
            // 
            lblEstimatedEndDateLeft.AutoSize = true;
            lblEstimatedEndDateLeft.Location = new Point(330, 63);
            lblEstimatedEndDateLeft.Name = "lblEstimatedEndDateLeft";
            lblEstimatedEndDateLeft.Size = new Size(111, 15);
            lblEstimatedEndDateLeft.TabIndex = 1;
            lblEstimatedEndDateLeft.Text = "Estimated end date:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 647);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvAppServices
            // 
            dgvAppServices.AutoGenerateColumns = false;
            dgvAppServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppServices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAppServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppServices.Columns.AddRange(new DataGridViewColumn[] { serviceDataGridViewTextBoxColumn, lawyerDataGridViewTextBoxColumn, noteDataGridViewTextBoxColumn, unitCountDataGridViewTextBoxColumn, unitCostActualDataGridViewTextBoxColumn, startPaymentActualDataGridViewTextBoxColumn, servicePerformedDataGridViewTextBoxColumn });
            dgvAppServices.DataSource = uiAppliedServiceBindingSource;
            dgvAppServices.Location = new Point(19, 18);
            dgvAppServices.MinimumSize = new Size(730, 227);
            dgvAppServices.MultiSelect = false;
            dgvAppServices.Name = "dgvAppServices";
            dgvAppServices.ReadOnly = true;
            dgvAppServices.RowHeadersWidth = 51;
            dgvAppServices.RowTemplate.Height = 29;
            dgvAppServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppServices.Size = new Size(730, 227);
            dgvAppServices.TabIndex = 5;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lawyerDataGridViewTextBoxColumn
            // 
            lawyerDataGridViewTextBoxColumn.DataPropertyName = "Lawyer";
            lawyerDataGridViewTextBoxColumn.HeaderText = "Lawyer";
            lawyerDataGridViewTextBoxColumn.MinimumWidth = 6;
            lawyerDataGridViewTextBoxColumn.Name = "lawyerDataGridViewTextBoxColumn";
            lawyerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            noteDataGridViewTextBoxColumn.HeaderText = "Note";
            noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitCountDataGridViewTextBoxColumn
            // 
            unitCountDataGridViewTextBoxColumn.DataPropertyName = "UnitCount";
            unitCountDataGridViewTextBoxColumn.HeaderText = "UnitCount";
            unitCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitCountDataGridViewTextBoxColumn.Name = "unitCountDataGridViewTextBoxColumn";
            unitCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitCostActualDataGridViewTextBoxColumn
            // 
            unitCostActualDataGridViewTextBoxColumn.DataPropertyName = "UnitCostActual";
            unitCostActualDataGridViewTextBoxColumn.HeaderText = "UnitCostActual";
            unitCostActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitCostActualDataGridViewTextBoxColumn.Name = "unitCostActualDataGridViewTextBoxColumn";
            unitCostActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startPaymentActualDataGridViewTextBoxColumn
            // 
            startPaymentActualDataGridViewTextBoxColumn.DataPropertyName = "StartPaymentActual";
            startPaymentActualDataGridViewTextBoxColumn.HeaderText = "StartPaymentActual";
            startPaymentActualDataGridViewTextBoxColumn.MinimumWidth = 6;
            startPaymentActualDataGridViewTextBoxColumn.Name = "startPaymentActualDataGridViewTextBoxColumn";
            startPaymentActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicePerformedDataGridViewTextBoxColumn
            // 
            servicePerformedDataGridViewTextBoxColumn.DataPropertyName = "ServicePerformed";
            servicePerformedDataGridViewTextBoxColumn.HeaderText = "ServicePerformed";
            servicePerformedDataGridViewTextBoxColumn.MinimumWidth = 6;
            servicePerformedDataGridViewTextBoxColumn.Name = "servicePerformedDataGridViewTextBoxColumn";
            servicePerformedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uiAppliedServiceBindingSource
            // 
            uiAppliedServiceBindingSource.DataSource = typeof(UIModels.UiAppliedService);
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dgvAppServices);
            panel1.Location = new Point(12, 378);
            panel1.MinimumSize = new Size(766, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 263);
            panel1.TabIndex = 5;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(687, 647);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Save as file";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_ClickAsync;
            // 
            // CustomerSpecificCases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 688);
            Controls.Add(btnPrint);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerSpecificCases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerSpecificCases";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlCaseDescription.ResumeLayout(false);
            pnlCaseDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label lblCaseTitle;
        private Panel panel5;
        private Panel panel6;
        private Label lblDescriptionCase;
        private CheckBox checkboxCasedClosed;
        private Label lblEmployeeOnCaseLeft;
        private Label lblIsFinishedLeft;
        private Label lblStartDateLeft;
        private Label lblEstimatedEndDateLeft;
        private Button btnBack;
        private Label lblCaseName;
        private Panel pnlCaseDescription;
        private Label lblCaseDescription;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Label lblLawyerName;
        private DataGridView dgvAppServices;
        private BindingSource uiAppliedServiceBindingSource;
        private Panel panel1;
        private DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lawyerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitCostActualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPaymentActualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servicePerformedDataGridViewTextBoxColumn;
        private Button btnPrint;
    }
}