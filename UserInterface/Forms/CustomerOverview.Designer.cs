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
            btnBack = new Button();
            btnSelect = new Button();
            comboSelectedClient = new ComboBox();
            uiCaseBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvCases
            // 
            dgvCases.AutoGenerateColumns = false;
            dgvCases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCases.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn6 });
            dgvCases.DataSource = uiCaseBindingSource;
            dgvCases.Location = new Point(12, 46);
            dgvCases.Name = "dgvCases";
            dgvCases.RowHeadersWidth = 51;
            dgvCases.RowTemplate.Height = 29;
            dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCases.Size = new Size(929, 507);
            dgvCases.TabIndex = 0;
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
            btnSelect.Location = new Point(413, 571);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // comboSelectedClient
            // 
            comboSelectedClient.FormattingEnabled = true;
            comboSelectedClient.Location = new Point(741, 12);
            comboSelectedClient.Name = "comboSelectedClient";
            comboSelectedClient.Size = new Size(200, 28);
            comboSelectedClient.TabIndex = 3;
            comboSelectedClient.SelectedIndexChanged += comboSelectedClient_SelectedIndexChanged;
            // 
            // uiCaseBindingSource
            // 
            uiCaseBindingSource.DataSource = typeof(UIModels.UiCase);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CaseName";
            dataGridViewTextBoxColumn2.HeaderText = "CaseName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CaseDescription";
            dataGridViewTextBoxColumn3.HeaderText = "CaseDescription";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "EstimatedEndDate";
            dataGridViewTextBoxColumn4.HeaderText = "EstimatedEndDate";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "StartDate";
            dataGridViewTextBoxColumn5.HeaderText = "StartDate";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "CaseClosed";
            dataGridViewCheckBoxColumn1.HeaderText = "CaseClosed";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Employee";
            dataGridViewTextBoxColumn6.HeaderText = "Employee";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // CustomerOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 627);
            Controls.Add(comboSelectedClient);
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn caseClosedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private Button btnBack;
        private Button btnSelect;
        private ComboBox comboSelectedClient;
        private BindingSource uiCaseBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}