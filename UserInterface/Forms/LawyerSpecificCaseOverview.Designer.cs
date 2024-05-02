namespace UserInterface.Forms
{
    partial class LawyerSpecificCaseOverview
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
            btnPrintInvoice = new Button();
            btnAddService = new Button();
            btnEditCase = new Button();
            btnBack = new Button();
            panel4 = new Panel();
            panel7 = new Panel();
            dgvServices = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oneTimePaymentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            startPaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uIServiceBindingSource = new BindingSource(components);
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            checkboxOngoing = new CheckBox();
            lblEmployeeOnCaseRight = new Label();
            lblEmployeeOnCaseLeft = new Label();
            lblIsFinishedLeft = new Label();
            lblEstimatedEndDateRight = new Label();
            lblStartDateRight = new Label();
            lblClientNameRight = new Label();
            lblStartDateLeft = new Label();
            lblEstimatedEndDateLeft = new Label();
            lblClientNameLeft = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btnEditClient = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnPrintInvoice);
            panel1.Controls.Add(btnAddService);
            panel1.Controls.Add(btnEditCase);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1558, 829);
            panel1.TabIndex = 0;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Location = new Point(255, 722);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(120, 70);
            btnPrintInvoice.TabIndex = 5;
            btnPrintInvoice.Text = "Print invoice";
            btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(3, 721);
            btnAddService.MaximumSize = new Size(120, 70);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(120, 70);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // btnEditCase
            // 
            btnEditCase.Location = new Point(129, 721);
            btnEditCase.Name = "btnEditCase";
            btnEditCase.Size = new Size(120, 70);
            btnEditCase.TabIndex = 4;
            btnEditCase.Text = "Edit case";
            btnEditCase.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 797);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(23, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(742, 672);
            panel4.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.AppWorkspace;
            panel7.Controls.Add(dgvServices);
            panel7.Location = new Point(3, 364);
            panel7.Name = "panel7";
            panel7.Size = new Size(736, 305);
            panel7.TabIndex = 2;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.AutoGenerateColumns = false;
            dgvServices.BackgroundColor = SystemColors.ButtonFace;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, oneTimePaymentDataGridViewCheckBoxColumn, startPaymentDataGridViewTextBoxColumn, hourlyCostDataGridViewTextBoxColumn });
            dgvServices.DataSource = uIServiceBindingSource;
            dgvServices.Location = new Point(20, 21);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(692, 259);
            dgvServices.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // oneTimePaymentDataGridViewCheckBoxColumn
            // 
            oneTimePaymentDataGridViewCheckBoxColumn.DataPropertyName = "OneTimePayment";
            oneTimePaymentDataGridViewCheckBoxColumn.HeaderText = "OneTimePayment";
            oneTimePaymentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            oneTimePaymentDataGridViewCheckBoxColumn.Name = "oneTimePaymentDataGridViewCheckBoxColumn";
            oneTimePaymentDataGridViewCheckBoxColumn.ReadOnly = true;
            oneTimePaymentDataGridViewCheckBoxColumn.Width = 125;
            // 
            // startPaymentDataGridViewTextBoxColumn
            // 
            startPaymentDataGridViewTextBoxColumn.DataPropertyName = "StartPayment";
            startPaymentDataGridViewTextBoxColumn.HeaderText = "StartPayment";
            startPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            startPaymentDataGridViewTextBoxColumn.Name = "startPaymentDataGridViewTextBoxColumn";
            startPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            startPaymentDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlyCostDataGridViewTextBoxColumn
            // 
            hourlyCostDataGridViewTextBoxColumn.DataPropertyName = "HourlyCost";
            hourlyCostDataGridViewTextBoxColumn.HeaderText = "HourlyCost";
            hourlyCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            hourlyCostDataGridViewTextBoxColumn.Name = "hourlyCostDataGridViewTextBoxColumn";
            hourlyCostDataGridViewTextBoxColumn.ReadOnly = true;
            hourlyCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // uIServiceBindingSource
            // 
            uIServiceBindingSource.DataSource = typeof(UIModels.UIService);
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Location = new Point(23, 20);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(41, 20);
            lblCaseTitle.TabIndex = 1;
            lblCaseTitle.Text = "Title:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(736, 302);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(checkboxOngoing);
            panel6.Controls.Add(lblEmployeeOnCaseRight);
            panel6.Controls.Add(lblEmployeeOnCaseLeft);
            panel6.Controls.Add(lblIsFinishedLeft);
            panel6.Controls.Add(lblEstimatedEndDateRight);
            panel6.Controls.Add(lblStartDateRight);
            panel6.Controls.Add(lblClientNameRight);
            panel6.Controls.Add(lblStartDateLeft);
            panel6.Controls.Add(lblEstimatedEndDateLeft);
            panel6.Controls.Add(lblClientNameLeft);
            panel6.Location = new Point(20, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(692, 258);
            panel6.TabIndex = 0;
            // 
            // checkboxOngoing
            // 
            checkboxOngoing.AutoSize = true;
            checkboxOngoing.Location = new Point(182, 117);
            checkboxOngoing.Name = "checkboxOngoing";
            checkboxOngoing.Size = new Size(18, 17);
            checkboxOngoing.TabIndex = 10;
            checkboxOngoing.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeOnCaseRight
            // 
            lblEmployeeOnCaseRight.AutoSize = true;
            lblEmployeeOnCaseRight.Location = new Point(174, 145);
            lblEmployeeOnCaseRight.Name = "lblEmployeeOnCaseRight";
            lblEmployeeOnCaseRight.Size = new Size(26, 20);
            lblEmployeeOnCaseRight.TabIndex = 9;
            lblEmployeeOnCaseRight.Text = "txt";
            // 
            // lblEmployeeOnCaseLeft
            // 
            lblEmployeeOnCaseLeft.AutoSize = true;
            lblEmployeeOnCaseLeft.Location = new Point(13, 145);
            lblEmployeeOnCaseLeft.Name = "lblEmployeeOnCaseLeft";
            lblEmployeeOnCaseLeft.Size = new Size(58, 20);
            lblEmployeeOnCaseLeft.TabIndex = 8;
            lblEmployeeOnCaseLeft.Text = "Lawyer:";
            // 
            // lblIsFinishedLeft
            // 
            lblIsFinishedLeft.AutoSize = true;
            lblIsFinishedLeft.Location = new Point(13, 114);
            lblIsFinishedLeft.Name = "lblIsFinishedLeft";
            lblIsFinishedLeft.Size = new Size(74, 20);
            lblIsFinishedLeft.TabIndex = 6;
            lblIsFinishedLeft.Text = "Ongoing?";
            // 
            // lblEstimatedEndDateRight
            // 
            lblEstimatedEndDateRight.AutoSize = true;
            lblEstimatedEndDateRight.Location = new Point(174, 83);
            lblEstimatedEndDateRight.Name = "lblEstimatedEndDateRight";
            lblEstimatedEndDateRight.Size = new Size(26, 20);
            lblEstimatedEndDateRight.TabIndex = 5;
            lblEstimatedEndDateRight.Text = "txt";
            // 
            // lblStartDateRight
            // 
            lblStartDateRight.AutoSize = true;
            lblStartDateRight.Location = new Point(174, 53);
            lblStartDateRight.Name = "lblStartDateRight";
            lblStartDateRight.Size = new Size(26, 20);
            lblStartDateRight.TabIndex = 4;
            lblStartDateRight.Text = "txt";
            // 
            // lblClientNameRight
            // 
            lblClientNameRight.AutoSize = true;
            lblClientNameRight.Location = new Point(174, 21);
            lblClientNameRight.Name = "lblClientNameRight";
            lblClientNameRight.Size = new Size(26, 20);
            lblClientNameRight.TabIndex = 3;
            lblClientNameRight.Text = "txt";
            // 
            // lblStartDateLeft
            // 
            lblStartDateLeft.AutoSize = true;
            lblStartDateLeft.Location = new Point(13, 53);
            lblStartDateLeft.Name = "lblStartDateLeft";
            lblStartDateLeft.Size = new Size(77, 20);
            lblStartDateLeft.TabIndex = 2;
            lblStartDateLeft.Text = "Start date:";
            // 
            // lblEstimatedEndDateLeft
            // 
            lblEstimatedEndDateLeft.AutoSize = true;
            lblEstimatedEndDateLeft.Location = new Point(13, 83);
            lblEstimatedEndDateLeft.Name = "lblEstimatedEndDateLeft";
            lblEstimatedEndDateLeft.Size = new Size(141, 20);
            lblEstimatedEndDateLeft.TabIndex = 1;
            lblEstimatedEndDateLeft.Text = "Estimated end date:";
            // 
            // lblClientNameLeft
            // 
            lblClientNameLeft.AutoSize = true;
            lblClientNameLeft.Location = new Point(13, 21);
            lblClientNameLeft.Name = "lblClientNameLeft";
            lblClientNameLeft.Size = new Size(91, 20);
            lblClientNameLeft.TabIndex = 0;
            lblClientNameLeft.Text = "Client name:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(820, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 728);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(btnEditClient);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(39, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(646, 657);
            panel3.TabIndex = 0;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(523, 584);
            btnEditClient.MaximumSize = new Size(120, 70);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(120, 70);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit client info";
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // LawyerSpecificCaseOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerSpecificCaseOverview";
            Text = "LawyerSpecificCaseOverview";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnEditClient;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnAddService;
        private DataGridView dgvServices;
        private Label lblCaseTitle;
        private Label lblClientNameLeft;
        private Label lblEstimatedEndDateLeft;
        private Label lblStartDateLeft;
        private Panel panel7;
        private Label lblClientNameRight;
        private Label lblStartDateRight;
        private Label lblEstimatedEndDateRight;
        private Button btnEditCase;
        private Button btnBack;
        private Label lblIsFinishedLeft;
        private Button btnPrintInvoice;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn oneTimePaymentDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn startPaymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyCostDataGridViewTextBoxColumn;
        private BindingSource uIServiceBindingSource;
        private CheckBox checkboxOngoing;
        private Label lblEmployeeOnCaseRight;
        private Label lblEmployeeOnCaseLeft;
    }
}