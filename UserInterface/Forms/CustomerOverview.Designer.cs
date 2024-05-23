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
            lblCases = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCases
            // 
            dgvCases.AllowUserToAddRows = false;
            dgvCases.AllowUserToDeleteRows = false;
            dgvCases.AllowUserToResizeColumns = false;
            dgvCases.AllowUserToResizeRows = false;
            dgvCases.AutoGenerateColumns = false;
            dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, caseNameDataGridViewTextBoxColumn, caseDescriptionDataGridViewTextBoxColumn, estimatedEndDateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, caseClosedDataGridViewCheckBoxColumn, employeeDataGridViewTextBoxColumn });
            dgvCases.DataSource = uiCaseBindingSource;
            dgvCases.Location = new Point(22, 45);
            dgvCases.Margin = new Padding(3, 2, 3, 2);
            dgvCases.Name = "dgvCases";
            dgvCases.ReadOnly = true;
            dgvCases.RowHeadersWidth = 51;
            dgvCases.RowTemplate.Height = 29;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.Size = new Size(798, 373);
            dgvCases.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseNameDataGridViewTextBoxColumn
            // 
            caseNameDataGridViewTextBoxColumn.DataPropertyName = "CaseName";
            caseNameDataGridViewTextBoxColumn.HeaderText = "CaseName";
            caseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseNameDataGridViewTextBoxColumn.Name = "caseNameDataGridViewTextBoxColumn";
            caseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseDescriptionDataGridViewTextBoxColumn
            // 
            caseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.HeaderText = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseDescriptionDataGridViewTextBoxColumn.Name = "caseDescriptionDataGridViewTextBoxColumn";
            caseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estimatedEndDateDataGridViewTextBoxColumn
            // 
            estimatedEndDateDataGridViewTextBoxColumn.DataPropertyName = "EstimatedEndDate";
            estimatedEndDateDataGridViewTextBoxColumn.HeaderText = "EstimatedEndDate";
            estimatedEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimatedEndDateDataGridViewTextBoxColumn.Name = "estimatedEndDateDataGridViewTextBoxColumn";
            estimatedEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseClosedDataGridViewCheckBoxColumn
            // 
            caseClosedDataGridViewCheckBoxColumn.DataPropertyName = "CaseClosed";
            caseClosedDataGridViewCheckBoxColumn.HeaderText = "CaseClosed";
            caseClosedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            caseClosedDataGridViewCheckBoxColumn.Name = "caseClosedDataGridViewCheckBoxColumn";
            caseClosedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uiCaseBindingSource
            // 
            uiCaseBindingSource.DataSource = typeof(UIModels.UiCase);
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 440);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(376, 440);
            btnSelect.Margin = new Padding(3, 2, 3, 2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(82, 22);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // lblCases
            // 
            lblCases.AutoSize = true;
            lblCases.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblCases.Location = new Point(22, 7);
            lblCases.Name = "lblCases";
            lblCases.Size = new Size(156, 37);
            lblCases.TabIndex = 3;
            lblCases.Text = "Your Cases:";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 491);
            panel1.TabIndex = 4;
            // 
            // CustomerOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 470);
            Controls.Add(lblCases);
            Controls.Add(btnSelect);
            Controls.Add(btnBack);
            Controls.Add(dgvCases);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerOverview";
            ((System.ComponentModel.ISupportInitialize)dgvCases).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblCases;
        private Panel panel1;
    }
}