namespace UserInterface.Forms
{
    partial class CustomerOverview
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
            dgvCases = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedEndDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseClosedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiCaseBindingSource = new BindingSource(components);
            btnBack = new Button();
            btnSelect = new Button();
            cbClient = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCases
            // 
            dgvCases.AutoGenerateColumns = false;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, caseNameDataGridViewTextBoxColumn, caseDescriptionDataGridViewTextBoxColumn, estimatedEndDateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, caseClosedDataGridViewCheckBoxColumn, employeeDataGridViewTextBoxColumn });
            dgvCases.DataSource = uiCaseBindingSource;
            dgvCases.Location = new Point(17, 68);
            dgvCases.Name = "dgvCases";
            dgvCases.RowHeadersWidth = 51;
            dgvCases.RowTemplate.Height = 29;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.Size = new Size(929, 485);
            dgvCases.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // caseNameDataGridViewTextBoxColumn
            // 
            caseNameDataGridViewTextBoxColumn.DataPropertyName = "CaseName";
            caseNameDataGridViewTextBoxColumn.HeaderText = "CaseName";
            caseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseNameDataGridViewTextBoxColumn.Name = "caseNameDataGridViewTextBoxColumn";
            caseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // caseDescriptionDataGridViewTextBoxColumn
            // 
            caseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.HeaderText = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseDescriptionDataGridViewTextBoxColumn.Name = "caseDescriptionDataGridViewTextBoxColumn";
            caseDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn
            // 
            estimatedEndDateDataGridViewTextBoxColumn.DataPropertyName = "EstimatedEndDate";
            estimatedEndDateDataGridViewTextBoxColumn.HeaderText = "EstimatedEndDate";
            estimatedEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimatedEndDateDataGridViewTextBoxColumn.Name = "estimatedEndDateDataGridViewTextBoxColumn";
            estimatedEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // caseClosedDataGridViewCheckBoxColumn
            // 
            caseClosedDataGridViewCheckBoxColumn.DataPropertyName = "CaseClosed";
            caseClosedDataGridViewCheckBoxColumn.HeaderText = "CaseClosed";
            caseClosedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            caseClosedDataGridViewCheckBoxColumn.Name = "caseClosedDataGridViewCheckBoxColumn";
            caseClosedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // uiCaseBindingSource
            // 
            uiCaseBindingSource.DataSource = typeof(UIModels.UiCase);
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(420, 571);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // cbClient
            // 
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(743, 12);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(203, 28);
            cbClient.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbClient);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(dgvCases);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 655);
            panel1.TabIndex = 4;
            // 
            // CustomerOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 627);
            Controls.Add(panel1);
            Name = "CustomerOverview";
            Text = "CustomerOverview";
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private DataGridView dgvCases;
        private BindingSource uiCaseBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn caseClosedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private Button btnBack;
        private Button btnSelect;
        private ComboBox cbClient;
        private Panel panel1;
    }
}