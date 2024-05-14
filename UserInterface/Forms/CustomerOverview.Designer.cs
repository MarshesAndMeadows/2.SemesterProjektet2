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
            uiCaseBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimatedEndDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseClosedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCases
            // 
            dgvCases.AutoGenerateColumns = false;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, caseNameDataGridViewTextBoxColumn, caseDescriptionDataGridViewTextBoxColumn, estimatedEndDateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, caseClosedDataGridViewCheckBoxColumn, employeeDataGridViewTextBoxColumn });
            dgvCases.DataSource = uiCaseBindingSource;
            dgvCases.Location = new Point(12, 12);
            dgvCases.Name = "dgvCases";
            dgvCases.RowHeadersWidth = 51;
            dgvCases.RowTemplate.Height = 29;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.Size = new Size(929, 541);
            dgvCases.TabIndex = 0;
            // 
            // uiCaseBindingSource
            // 
            uiCaseBindingSource.DataSource = typeof(UIModels.UiCase);
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
            // btnBack
            // 
            btnBack.Location = new Point(12, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(413, 571);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // CustomerOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 627);
            Controls.Add(btnSelect);
            Controls.Add(btnBack);
            Controls.Add(dgvCases);
            Name = "CustomerOverview";
            Text = "CustomerOverview";
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).EndInit();
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
    }
}