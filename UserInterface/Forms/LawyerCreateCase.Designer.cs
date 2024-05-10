﻿namespace UserInterface.Forms
{
    partial class LawyerCreateCase
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
            panel1 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            dgvEmployeeDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            workPositionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateHiredDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            workPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiLawyerBindingSource1 = new BindingSource(components);
            lblServices = new Label();
            btnBack = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            txtboxSearchClient = new TextBox();
            dgvClientDataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            uiClientBindingSource1 = new BindingSource(components);
            lblClientInfo = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            ComboBoxClient = new ComboBox();
            uiClientBindingSource2 = new BindingSource(components);
            btnCreate = new Button();
            DescriptionTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            comboboxSelectLawyer = new ComboBox();
            uiLawyerBindingSource = new BindingSource(components);
            CaseNameTextBox = new TextBox();
            lblCaseName = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblCaseInfo = new Label();
            uiClientBindingSource = new BindingSource(components);
            CreateCaseErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CreateCaseErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-8, -38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 900);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(dataGridView2);
            panel6.Controls.Add(dgvEmployeeDataGrid);
            panel6.Controls.Add(lblServices);
            panel6.Location = new Point(776, 82);
            panel6.Name = "panel6";
            panel6.Size = new Size(802, 762);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(466, 38);
            label4.Name = "label4";
            label4.Size = new Size(333, 20);
            label4.TabIndex = 3;
            label4.Text = "This is a list of the services attached to the case ...";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 467);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(796, 292);
            dataGridView2.TabIndex = 2;
            // 
            // dgvEmployeeDataGrid
            // 
            dgvEmployeeDataGrid.AutoGenerateColumns = false;
            dgvEmployeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, workPositionDataGridViewTextBoxColumn, dateHiredDataGridViewTextBoxColumn, dataGridViewTextBoxColumn11, workPhoneDataGridViewTextBoxColumn });
            dgvEmployeeDataGrid.DataSource = uiLawyerBindingSource1;
            dgvEmployeeDataGrid.Location = new Point(3, 61);
            dgvEmployeeDataGrid.Name = "dgvEmployeeDataGrid";
            dgvEmployeeDataGrid.ReadOnly = true;
            dgvEmployeeDataGrid.RowHeadersWidth = 51;
            dgvEmployeeDataGrid.RowTemplate.Height = 29;
            dgvEmployeeDataGrid.Size = new Size(796, 339);
            dgvEmployeeDataGrid.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Firstname";
            dataGridViewTextBoxColumn8.HeaderText = "Firstname";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Lastname";
            dataGridViewTextBoxColumn9.HeaderText = "Lastname";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Sex";
            dataGridViewTextBoxColumn10.HeaderText = "Sex";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // workPositionDataGridViewTextBoxColumn
            // 
            workPositionDataGridViewTextBoxColumn.DataPropertyName = "WorkPosition";
            workPositionDataGridViewTextBoxColumn.HeaderText = "WorkPosition";
            workPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            workPositionDataGridViewTextBoxColumn.Name = "workPositionDataGridViewTextBoxColumn";
            workPositionDataGridViewTextBoxColumn.ReadOnly = true;
            workPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateHiredDataGridViewTextBoxColumn
            // 
            dateHiredDataGridViewTextBoxColumn.DataPropertyName = "DateHired";
            dateHiredDataGridViewTextBoxColumn.HeaderText = "DateHired";
            dateHiredDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateHiredDataGridViewTextBoxColumn.Name = "dateHiredDataGridViewTextBoxColumn";
            dateHiredDataGridViewTextBoxColumn.ReadOnly = true;
            dateHiredDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Email";
            dataGridViewTextBoxColumn11.HeaderText = "Email";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.HeaderText = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            workPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            workPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // uiLawyerBindingSource1
            // 
            uiLawyerBindingSource1.DataSource = typeof(UIModels.UiLawyer);
            // 
            // lblServices
            // 
            lblServices.AutoSize = true;
            lblServices.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblServices.Location = new Point(3, 12);
            lblServices.Name = "lblServices";
            lblServices.Size = new Size(173, 46);
            lblServices.TabIndex = 0;
            lblServices.Text = "Employee:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 850);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblClientInfo);
            panel3.Location = new Point(20, 488);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 356);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtboxSearchClient);
            panel5.Controls.Add(dgvClientDataGrid);
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(744, 292);
            panel5.TabIndex = 1;
            // 
            // txtboxSearchClient
            // 
            txtboxSearchClient.Location = new Point(381, 8);
            txtboxSearchClient.Name = "txtboxSearchClient";
            txtboxSearchClient.PlaceholderText = "Search for an existing client ...";
            txtboxSearchClient.Size = new Size(360, 27);
            txtboxSearchClient.TabIndex = 1;
            // 
            // dgvClientDataGrid
            // 
            dgvClientDataGrid.AutoGenerateColumns = false;
            dgvClientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewCheckBoxColumn1 });
            dgvClientDataGrid.DataSource = uiClientBindingSource1;
            dgvClientDataGrid.Location = new Point(3, 41);
            dgvClientDataGrid.Name = "dgvClientDataGrid";
            dgvClientDataGrid.ReadOnly = true;
            dgvClientDataGrid.RowHeadersWidth = 51;
            dgvClientDataGrid.RowTemplate.Height = 29;
            dgvClientDataGrid.Size = new Size(738, 248);
            dgvClientDataGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Firstname";
            dataGridViewTextBoxColumn1.HeaderText = "Firstname";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Lastname";
            dataGridViewTextBoxColumn2.HeaderText = "Lastname";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Sex";
            dataGridViewTextBoxColumn3.HeaderText = "Sex";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            dataGridViewTextBoxColumn4.HeaderText = "Birthday";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn6.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            dataGridViewTextBoxColumn7.HeaderText = "Address";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "Subscribed";
            dataGridViewCheckBoxColumn1.HeaderText = "Subscribed";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // uiClientBindingSource1
            // 
            uiClientBindingSource1.DataSource = typeof(UIModels.UiClient);
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientInfo.Location = new Point(3, 12);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(113, 46);
            lblClientInfo.TabIndex = 0;
            lblClientInfo.Text = "Client:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblCaseInfo);
            panel2.Location = new Point(20, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(750, 400);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Controls.Add(ComboBoxClient);
            panel4.Controls.Add(btnCreate);
            panel4.Controls.Add(DescriptionTextBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(comboboxSelectLawyer);
            panel4.Controls.Add(CaseNameTextBox);
            panel4.Controls.Add(lblCaseName);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Location = new Point(3, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(744, 336);
            panel4.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 91);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 16;
            label10.Text = "Client:";
            // 
            // ComboBoxClient
            // 
            ComboBoxClient.DataSource = uiClientBindingSource2;
            ComboBoxClient.DisplayMember = "Firstname";
            ComboBoxClient.FormattingEnabled = true;
            ComboBoxClient.Location = new Point(93, 88);
            ComboBoxClient.Name = "ComboBoxClient";
            ComboBoxClient.Size = new Size(200, 28);
            ComboBoxClient.TabIndex = 15;
            ComboBoxClient.Format += ComboBoxClient_Format;
            // 
            // uiClientBindingSource2
            // 
            uiClientBindingSource2.DataSource = typeof(UIModels.UiClient);
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(637, 295);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += Createbtn_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(93, 131);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(250, 69);
            DescriptionTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 134);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Lawyer:";
            // 
            // comboboxSelectLawyer
            // 
            comboboxSelectLawyer.DataSource = uiLawyerBindingSource;
            comboboxSelectLawyer.DisplayMember = "Firstname";
            comboboxSelectLawyer.FormattingEnabled = true;
            comboboxSelectLawyer.Location = new Point(93, 45);
            comboboxSelectLawyer.Name = "comboboxSelectLawyer";
            comboboxSelectLawyer.Size = new Size(200, 28);
            comboboxSelectLawyer.TabIndex = 6;
            comboboxSelectLawyer.Format += comboboxSelectLawyer_Format;
            // 
            // uiLawyerBindingSource
            // 
            uiLawyerBindingSource.DataSource = typeof(UIModels.UiLawyer);
            // 
            // CaseNameTextBox
            // 
            CaseNameTextBox.Location = new Point(93, 6);
            CaseNameTextBox.Name = "CaseNameTextBox";
            CaseNameTextBox.Size = new Size(200, 27);
            CaseNameTextBox.TabIndex = 5;
            // 
            // lblCaseName
            // 
            lblCaseName.AutoSize = true;
            lblCaseName.Location = new Point(3, 9);
            lblCaseName.Name = "lblCaseName";
            lblCaseName.Size = new Size(84, 20);
            lblCaseName.TabIndex = 4;
            lblCaseName.Text = "Case name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 254);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "End date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 221);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Start date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(93, 249);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblCaseInfo
            // 
            lblCaseInfo.AutoSize = true;
            lblCaseInfo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseInfo.Location = new Point(3, 12);
            lblCaseInfo.Name = "lblCaseInfo";
            lblCaseInfo.Size = new Size(281, 46);
            lblCaseInfo.TabIndex = 0;
            lblCaseInfo.Text = "Case information:";
            // 
            // CreateCaseErrorProvider
            // 
            CreateCaseErrorProvider.ContainerControl = this;
            // 
            // LawyerCreateCase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerCreateCase";
            Text = "LawyerCreateCase";
            Load += LawyerCreateCase_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)CreateCaseErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lblClientInfo;
        private Panel panel2;
        private Label lblCaseInfo;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnBack;
        private Label lblCaseName;
        private Label label3;
        private ComboBox comboboxSelectLawyer;
        private TextBox CaseNameTextBox;
        private Panel panel6;
        private DataGridView dgvEmployeeDataGrid;
        private Label lblServices;
        private Label label4;
        private DataGridView dataGridView2;
        private TextBox txtboxSearchClient;
        private DataGridView dgvClientDataGrid;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn subscribedDataGridViewCheckBoxColumn;
        private BindingSource uiClientBindingSource;
        private TextBox DescriptionTextBox;
        private Label label5;
        private Button btnCreate;
        private Label label10;
        private ComboBox ComboBoxClient;
        private ErrorProvider CreateCaseErrorProvider;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private BindingSource uiClientBindingSource1;
        private BindingSource uiLawyerBindingSource;
        private BindingSource uiClientBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn workPositionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateHiredDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private BindingSource uiLawyerBindingSource1;
    }
}