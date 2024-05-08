namespace UserInterface.Forms
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
            EmployeeDataGrid = new DataGridView();
            lblServices = new Label();
            btnBack = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            txtboxSearchClient = new TextBox();
            ClientDataGrid = new DataGridView();
            uiClientBindingSource = new BindingSource(components);
            lblClientInfo = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            ComboBoxClient = new ComboBox();
            Createbtn = new Button();
            DescriptionTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            comboboxSelectLawyer = new ComboBox();
            CaseNameTextBox = new TextBox();
            lblCaseName = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblCaseInfo = new Label();
            CreateCaseErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panel6.Controls.Add(EmployeeDataGrid);
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
            // EmployeeDataGrid
            // 
            EmployeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGrid.Location = new Point(3, 61);
            EmployeeDataGrid.Name = "EmployeeDataGrid";
            EmployeeDataGrid.RowHeadersWidth = 51;
            EmployeeDataGrid.RowTemplate.Height = 29;
            EmployeeDataGrid.Size = new Size(796, 339);
            EmployeeDataGrid.TabIndex = 1;
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
            panel5.Controls.Add(ClientDataGrid);
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
            // ClientDataGrid
            // 
            ClientDataGrid.AutoGenerateColumns = false;
            ClientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientDataGrid.DataSource = uiClientBindingSource;
            ClientDataGrid.Location = new Point(3, 41);
            ClientDataGrid.Name = "ClientDataGrid";
            ClientDataGrid.RowHeadersWidth = 51;
            ClientDataGrid.RowTemplate.Height = 29;
            ClientDataGrid.Size = new Size(738, 248);
            ClientDataGrid.TabIndex = 0;
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
            panel4.Controls.Add(Createbtn);
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
            ComboBoxClient.FormattingEnabled = true;
            ComboBoxClient.Location = new Point(93, 88);
            ComboBoxClient.Name = "ComboBoxClient";
            ComboBoxClient.Size = new Size(200, 28);
            ComboBoxClient.TabIndex = 15;
            // 
            // Createbtn
            // 
            Createbtn.Location = new Point(637, 295);
            Createbtn.Name = "Createbtn";
            Createbtn.Size = new Size(94, 29);
            Createbtn.TabIndex = 10;
            Createbtn.Text = "Create";
            Createbtn.UseVisualStyleBackColor = true;
            Createbtn.Click += Createbtn_Click;
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
            comboboxSelectLawyer.FormattingEnabled = true;
            comboboxSelectLawyer.Location = new Point(93, 45);
            comboboxSelectLawyer.Name = "comboboxSelectLawyer";
            comboboxSelectLawyer.Size = new Size(200, 28);
            comboboxSelectLawyer.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClientDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private DataGridView EmployeeDataGrid;
        private Label lblServices;
        private Label label4;
        private DataGridView dataGridView2;
        private TextBox txtboxSearchClient;
        private DataGridView ClientDataGrid;
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
        private Button Createbtn;
        private Label label10;
        private ComboBox ComboBoxClient;
        private ErrorProvider CreateCaseErrorProvider;
    }
}