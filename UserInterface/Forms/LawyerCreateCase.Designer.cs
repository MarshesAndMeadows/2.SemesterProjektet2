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
            pictureBox1 = new PictureBox();
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
            lblClientInfo = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnSelectLawyer = new Button();
            lblLawyerName = new Label();
            lblSelectedClient = new Label();
            label10 = new Label();
            btnCreate = new Button();
            DescriptionTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            CaseNameTextBox = new TextBox();
            lblCaseName = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblCaseInfo = new Label();
            CreateCaseErrorProvider = new ErrorProvider(components);
            UIClientBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientDataGrid).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CreateCaseErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UIClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 676);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helperIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(634, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += HelpIconClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 638);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblClientInfo);
            panel3.Location = new Point(18, 366);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 267);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtboxSearchClient);
            panel5.Controls.Add(dgvClientDataGrid);
            panel5.Location = new Point(3, 46);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(651, 219);
            panel5.TabIndex = 1;
            // 
            // txtboxSearchClient
            // 
            txtboxSearchClient.Location = new Point(333, 6);
            txtboxSearchClient.Margin = new Padding(3, 2, 3, 2);
            txtboxSearchClient.Name = "txtboxSearchClient";
            txtboxSearchClient.PlaceholderText = "Search for an existing client ...";
            txtboxSearchClient.Size = new Size(316, 23);
            txtboxSearchClient.TabIndex = 1;
            // 
            // dgvClientDataGrid
            // 
            dgvClientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewCheckBoxColumn1 });
            dgvClientDataGrid.Location = new Point(3, 31);
            dgvClientDataGrid.Margin = new Padding(3, 2, 3, 2);
            dgvClientDataGrid.MultiSelect = false;
            dgvClientDataGrid.Name = "dgvClientDataGrid";
            dgvClientDataGrid.ReadOnly = true;
            dgvClientDataGrid.RowHeadersWidth = 51;
            dgvClientDataGrid.RowTemplate.Height = 29;
            dgvClientDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientDataGrid.Size = new Size(646, 186);
            dgvClientDataGrid.TabIndex = 0;
            dgvClientDataGrid.CellDoubleClick += dgvClientDataGrid_CellDoubleClick;
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
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientInfo.Location = new Point(3, 9);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(92, 37);
            lblClientInfo.TabIndex = 0;
            lblClientInfo.Text = "Client:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblCaseInfo);
            panel2.Location = new Point(18, 86);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 276);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSelectLawyer);
            panel4.Controls.Add(lblLawyerName);
            panel4.Controls.Add(lblSelectedClient);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btnCreate);
            panel4.Controls.Add(DescriptionTextBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(CaseNameTextBox);
            panel4.Controls.Add(lblCaseName);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Location = new Point(3, 48);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(651, 250);
            panel4.TabIndex = 1;
            // 
            // btnSelectLawyer
            // 
            btnSelectLawyer.Location = new Point(218, 33);
            btnSelectLawyer.Margin = new Padding(3, 2, 3, 2);
            btnSelectLawyer.Name = "btnSelectLawyer";
            btnSelectLawyer.Size = new Size(82, 22);
            btnSelectLawyer.TabIndex = 19;
            btnSelectLawyer.Text = "Click here";
            btnSelectLawyer.UseVisualStyleBackColor = true;
            btnSelectLawyer.Click += btnSelectLawyer_Click;
            // 
            // lblLawyerName
            // 
            lblLawyerName.AutoSize = true;
            lblLawyerName.Location = new Point(81, 36);
            lblLawyerName.Name = "lblLawyerName";
            lblLawyerName.Size = new Size(84, 15);
            lblLawyerName.TabIndex = 18;
            lblLawyerName.Text = "Select a lawyer";
            // 
            // lblSelectedClient
            // 
            lblSelectedClient.AutoSize = true;
            lblSelectedClient.Location = new Point(81, 68);
            lblSelectedClient.Name = "lblSelectedClient";
            lblSelectedClient.Size = new Size(82, 15);
            lblSelectedClient.TabIndex = 17;
            lblSelectedClient.Text = "SelectedClient";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 68);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 16;
            label10.Text = "Client:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(543, 166);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(105, 52);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += Createbtn_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(81, 98);
            DescriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(219, 53);
            DescriptionTextBox.TabIndex = 9;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 100);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Lawyer:";
            // 
            // CaseNameTextBox
            // 
            CaseNameTextBox.Location = new Point(81, 4);
            CaseNameTextBox.Margin = new Padding(3, 2, 3, 2);
            CaseNameTextBox.Name = "CaseNameTextBox";
            CaseNameTextBox.Size = new Size(219, 23);
            CaseNameTextBox.TabIndex = 5;
            CaseNameTextBox.TextChanged += CaseNameTextBox_TextChanged;
            // 
            // lblCaseName
            // 
            lblCaseName.AutoSize = true;
            lblCaseName.Location = new Point(3, 7);
            lblCaseName.Name = "lblCaseName";
            lblCaseName.Size = new Size(68, 15);
            lblCaseName.TabIndex = 4;
            lblCaseName.Text = "Case name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 190);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "End date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 166);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Start date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(81, 187);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(81, 162);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblCaseInfo
            // 
            lblCaseInfo.AutoSize = true;
            lblCaseInfo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseInfo.Location = new Point(3, 9);
            lblCaseInfo.Name = "lblCaseInfo";
            lblCaseInfo.Size = new Size(225, 37);
            lblCaseInfo.TabIndex = 0;
            lblCaseInfo.Text = "Case information:";
            // 
            // CreateCaseErrorProvider
            // 
            CreateCaseErrorProvider.ContainerControl = this;
            // 
            // UIClientBindingSource
            // 
            UIClientBindingSource.DataSource = typeof(UIModels.UiClient);
            // 
            // LawyerCreateCase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 640);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LawyerCreateCase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerCreateCase";       
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CreateCaseErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)UIClientBindingSource).EndInit();
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
        private TextBox CaseNameTextBox;
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
        private TextBox DescriptionTextBox;
        private Label label5;
        private Button btnCreate;
        private Label label10;
        private ErrorProvider CreateCaseErrorProvider;
        private Label lblSelectedClient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private BindingSource UIClientBindingSource;
        private Button btnSelectLawyer;
        private Label lblLawyerName;
        private PictureBox pictureBox1;
    }
}