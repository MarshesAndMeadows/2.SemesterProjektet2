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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LawyerSpecificCaseOverview));
            panel1 = new Panel();
            lblServicesTitle = new Label();
            btnEditService = new Button();
            panel7 = new Panel();
            dgvServices = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oneTimePaymentDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            startPaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uIServiceBindingSource = new BindingSource(components);
            panel8 = new Panel();
            lblClientTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            checkboxClientSubscription = new CheckBox();
            lblClientSubscribed = new Label();
            lblClientAddressRight = new Label();
            lblClientAddressLeft = new Label();
            lblClientPhonenumberRight = new Label();
            lblClientPhonenumberLeft = new Label();
            lblClientEmailRight = new Label();
            lblClientEmailLeft = new Label();
            lblClientAgeRight = new Label();
            lblClientAgeLeft = new Label();
            lblClientSexRight = new Label();
            lblClientSexLeft = new Label();
            btnEditClient = new Button();
            lblClientNameLeft = new Label();
            lblClientNameRight = new Label();
            btnPrintInvoice = new Button();
            btnAddService = new Button();
            btnEditCase = new Button();
            btnBack = new Button();
            panel4 = new Panel();
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            lblDescription = new Label();
            panel9 = new Panel();
            lblCaseDescription = new Label();
            checkboxOngoing = new CheckBox();
            lblEmployeeOnCaseRight = new Label();
            lblEmployeeOnCaseLeft = new Label();
            lblIsFinishedLeft = new Label();
            lblEstimatedEndDateRight = new Label();
            lblStartDateRight = new Label();
            lblStartDateLeft = new Label();
            lblEstimatedEndDateLeft = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).BeginInit();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(lblServicesTitle);
            panel1.Controls.Add(btnEditService);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(btnPrintInvoice);
            panel1.Controls.Add(btnAddService);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1561, 829);
            panel1.TabIndex = 0;
            // 
            // lblServicesTitle
            // 
            lblServicesTitle.AutoSize = true;
            lblServicesTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicesTitle.Location = new Point(244, 423);
            lblServicesTitle.Name = "lblServicesTitle";
            lblServicesTitle.Size = new Size(140, 46);
            lblServicesTitle.TabIndex = 7;
            lblServicesTitle.Text = "Services";
            // 
            // btnEditService
            // 
            btnEditService.Location = new Point(23, 487);
            btnEditService.Name = "btnEditService";
            btnEditService.Size = new Size(120, 70);
            btnEditService.TabIndex = 6;
            btnEditService.Text = "Edit service";
            btnEditService.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.AppWorkspace;
            panel7.Controls.Add(dgvServices);
            panel7.Location = new Point(220, 472);
            panel7.Name = "panel7";
            panel7.Size = new Size(1327, 305);
            panel7.TabIndex = 2;
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.AutoGenerateColumns = false;
            dgvServices.BackgroundColor = SystemColors.ButtonFace;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, oneTimePaymentDataGridViewCheckBoxColumn, startPaymentDataGridViewTextBoxColumn, hourlyCostDataGridViewTextBoxColumn });
            dgvServices.DataSource = uIServiceBindingSource;
            dgvServices.Location = new Point(24, 20);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(1277, 259);
            dgvServices.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // oneTimePaymentDataGridViewCheckBoxColumn
            // 
            oneTimePaymentDataGridViewCheckBoxColumn.DataPropertyName = "OneTimePayment";
            oneTimePaymentDataGridViewCheckBoxColumn.HeaderText = "OneTimePayment";
            oneTimePaymentDataGridViewCheckBoxColumn.MinimumWidth = 6;
            oneTimePaymentDataGridViewCheckBoxColumn.Name = "oneTimePaymentDataGridViewCheckBoxColumn";
            oneTimePaymentDataGridViewCheckBoxColumn.ReadOnly = true;
            oneTimePaymentDataGridViewCheckBoxColumn.Width = 150;
            // 
            // startPaymentDataGridViewTextBoxColumn
            // 
            startPaymentDataGridViewTextBoxColumn.DataPropertyName = "StartPayment";
            startPaymentDataGridViewTextBoxColumn.HeaderText = "StartPayment";
            startPaymentDataGridViewTextBoxColumn.MinimumWidth = 6;
            startPaymentDataGridViewTextBoxColumn.Name = "startPaymentDataGridViewTextBoxColumn";
            startPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            startPaymentDataGridViewTextBoxColumn.Width = 250;
            // 
            // hourlyCostDataGridViewTextBoxColumn
            // 
            hourlyCostDataGridViewTextBoxColumn.DataPropertyName = "HourlyCost";
            hourlyCostDataGridViewTextBoxColumn.HeaderText = "HourlyCost";
            hourlyCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            hourlyCostDataGridViewTextBoxColumn.Name = "hourlyCostDataGridViewTextBoxColumn";
            hourlyCostDataGridViewTextBoxColumn.ReadOnly = true;
            hourlyCostDataGridViewTextBoxColumn.Width = 250;
            // 
            // uIServiceBindingSource
            // 
            uIServiceBindingSource.DataSource = typeof(UIModels.UIService);
            // 
            // panel8
            // 
            panel8.Controls.Add(lblClientTitle);
            panel8.Controls.Add(panel2);
            panel8.Location = new Point(799, 40);
            panel8.Name = "panel8";
            panel8.Size = new Size(759, 365);
            panel8.TabIndex = 1;
            // 
            // lblClientTitle
            // 
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.Location = new Point(27, 7);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(173, 46);
            lblClientTitle.TabIndex = 0;
            lblClientTitle.Text = "Client info";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(745, 302);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(checkboxClientSubscription);
            panel3.Controls.Add(lblClientSubscribed);
            panel3.Controls.Add(lblClientAddressRight);
            panel3.Controls.Add(lblClientAddressLeft);
            panel3.Controls.Add(lblClientPhonenumberRight);
            panel3.Controls.Add(lblClientPhonenumberLeft);
            panel3.Controls.Add(lblClientEmailRight);
            panel3.Controls.Add(lblClientEmailLeft);
            panel3.Controls.Add(lblClientAgeRight);
            panel3.Controls.Add(lblClientAgeLeft);
            panel3.Controls.Add(lblClientSexRight);
            panel3.Controls.Add(lblClientSexLeft);
            panel3.Controls.Add(btnEditClient);
            panel3.Controls.Add(lblClientNameLeft);
            panel3.Controls.Add(lblClientNameRight);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(27, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(692, 258);
            panel3.TabIndex = 0;
            // 
            // checkboxClientSubscription
            // 
            checkboxClientSubscription.AutoSize = true;
            checkboxClientSubscription.Location = new Point(135, 204);
            checkboxClientSubscription.Name = "checkboxClientSubscription";
            checkboxClientSubscription.Size = new Size(18, 17);
            checkboxClientSubscription.TabIndex = 15;
            checkboxClientSubscription.UseVisualStyleBackColor = true;
            // 
            // lblClientSubscribed
            // 
            lblClientSubscribed.AutoSize = true;
            lblClientSubscribed.Location = new Point(16, 202);
            lblClientSubscribed.Name = "lblClientSubscribed";
            lblClientSubscribed.Size = new Size(98, 20);
            lblClientSubscribed.TabIndex = 14;
            lblClientSubscribed.Text = "Subscription?";
            // 
            // lblClientAddressRight
            // 
            lblClientAddressRight.AutoSize = true;
            lblClientAddressRight.Location = new Point(131, 173);
            lblClientAddressRight.Name = "lblClientAddressRight";
            lblClientAddressRight.Size = new Size(26, 20);
            lblClientAddressRight.TabIndex = 13;
            lblClientAddressRight.Text = "txt";
            // 
            // lblClientAddressLeft
            // 
            lblClientAddressLeft.AutoSize = true;
            lblClientAddressLeft.Location = new Point(16, 173);
            lblClientAddressLeft.Name = "lblClientAddressLeft";
            lblClientAddressLeft.Size = new Size(65, 20);
            lblClientAddressLeft.TabIndex = 12;
            lblClientAddressLeft.Text = "Address:";
            // 
            // lblClientPhonenumberRight
            // 
            lblClientPhonenumberRight.AutoSize = true;
            lblClientPhonenumberRight.Location = new Point(131, 145);
            lblClientPhonenumberRight.Name = "lblClientPhonenumberRight";
            lblClientPhonenumberRight.Size = new Size(26, 20);
            lblClientPhonenumberRight.TabIndex = 11;
            lblClientPhonenumberRight.Text = "txt";
            // 
            // lblClientPhonenumberLeft
            // 
            lblClientPhonenumberLeft.AutoSize = true;
            lblClientPhonenumberLeft.Location = new Point(16, 145);
            lblClientPhonenumberLeft.Name = "lblClientPhonenumberLeft";
            lblClientPhonenumberLeft.Size = new Size(108, 20);
            lblClientPhonenumberLeft.TabIndex = 10;
            lblClientPhonenumberLeft.Text = "Phone number:";
            // 
            // lblClientEmailRight
            // 
            lblClientEmailRight.AutoSize = true;
            lblClientEmailRight.Location = new Point(131, 114);
            lblClientEmailRight.Name = "lblClientEmailRight";
            lblClientEmailRight.Size = new Size(26, 20);
            lblClientEmailRight.TabIndex = 9;
            lblClientEmailRight.Text = "txt";
            // 
            // lblClientEmailLeft
            // 
            lblClientEmailLeft.AutoSize = true;
            lblClientEmailLeft.Location = new Point(16, 114);
            lblClientEmailLeft.Name = "lblClientEmailLeft";
            lblClientEmailLeft.Size = new Size(49, 20);
            lblClientEmailLeft.TabIndex = 8;
            lblClientEmailLeft.Text = "Email:";
            // 
            // lblClientAgeRight
            // 
            lblClientAgeRight.AutoSize = true;
            lblClientAgeRight.Location = new Point(131, 83);
            lblClientAgeRight.Name = "lblClientAgeRight";
            lblClientAgeRight.Size = new Size(26, 20);
            lblClientAgeRight.TabIndex = 7;
            lblClientAgeRight.Text = "txt";
            // 
            // lblClientAgeLeft
            // 
            lblClientAgeLeft.AutoSize = true;
            lblClientAgeLeft.Location = new Point(16, 83);
            lblClientAgeLeft.Name = "lblClientAgeLeft";
            lblClientAgeLeft.Size = new Size(39, 20);
            lblClientAgeLeft.TabIndex = 6;
            lblClientAgeLeft.Text = "Age:";
            // 
            // lblClientSexRight
            // 
            lblClientSexRight.AutoSize = true;
            lblClientSexRight.Location = new Point(131, 53);
            lblClientSexRight.Name = "lblClientSexRight";
            lblClientSexRight.Size = new Size(26, 20);
            lblClientSexRight.TabIndex = 5;
            lblClientSexRight.Text = "txt";
            // 
            // lblClientSexLeft
            // 
            lblClientSexLeft.AutoSize = true;
            lblClientSexLeft.Location = new Point(16, 53);
            lblClientSexLeft.Name = "lblClientSexLeft";
            lblClientSexLeft.Size = new Size(35, 20);
            lblClientSexLeft.TabIndex = 4;
            lblClientSexLeft.Text = "Sex:";
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(552, 173);
            btnEditClient.MaximumSize = new Size(120, 70);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(120, 70);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit client info";
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // lblClientNameLeft
            // 
            lblClientNameLeft.AutoSize = true;
            lblClientNameLeft.Location = new Point(16, 21);
            lblClientNameLeft.Name = "lblClientNameLeft";
            lblClientNameLeft.Size = new Size(91, 20);
            lblClientNameLeft.TabIndex = 0;
            lblClientNameLeft.Text = "Client name:";
            // 
            // lblClientNameRight
            // 
            lblClientNameRight.AutoSize = true;
            lblClientNameRight.Location = new Point(131, 21);
            lblClientNameRight.Name = "lblClientNameRight";
            lblClientNameRight.Size = new Size(26, 20);
            lblClientNameRight.TabIndex = 3;
            lblClientNameRight.Text = "txt";
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Location = new Point(26, 563);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(120, 70);
            btnPrintInvoice.TabIndex = 5;
            btnPrintInvoice.Text = "Print invoice";
            btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(26, 639);
            btnAddService.MaximumSize = new Size(120, 70);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(120, 70);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // btnEditCase
            // 
            btnEditCase.Location = new Point(3, 185);
            btnEditCase.Name = "btnEditCase";
            btnEditCase.Size = new Size(120, 70);
            btnEditCase.TabIndex = 4;
            btnEditCase.Text = "Edit case info";
            btnEditCase.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(26, 797);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(23, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(745, 365);
            panel4.TabIndex = 2;
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseTitle.Location = new Point(23, 7);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(91, 46);
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
            panel6.Controls.Add(lblDescription);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(checkboxOngoing);
            panel6.Controls.Add(lblEmployeeOnCaseRight);
            panel6.Controls.Add(lblEmployeeOnCaseLeft);
            panel6.Controls.Add(lblIsFinishedLeft);
            panel6.Controls.Add(btnEditCase);
            panel6.Controls.Add(lblEstimatedEndDateRight);
            panel6.Controls.Add(lblStartDateRight);
            panel6.Controls.Add(lblStartDateLeft);
            panel6.Controls.Add(lblEstimatedEndDateLeft);
            panel6.Location = new Point(20, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(692, 258);
            panel6.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(311, 19);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description:";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.HighlightText;
            panel9.Controls.Add(lblCaseDescription);
            panel9.Location = new Point(311, 42);
            panel9.Name = "panel9";
            panel9.Size = new Size(378, 213);
            panel9.TabIndex = 11;
            // 
            // lblCaseDescription
            // 
            lblCaseDescription.AutoSize = true;
            lblCaseDescription.Location = new Point(3, 1);
            lblCaseDescription.MaximumSize = new Size(380, 200);
            lblCaseDescription.Name = "lblCaseDescription";
            lblCaseDescription.Size = new Size(364, 200);
            lblCaseDescription.TabIndex = 0;
            lblCaseDescription.Text = resources.GetString("lblCaseDescription.Text");
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
            // LawyerSpecificCaseOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerSpecificCaseOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerSpecificCaseOverview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
        private BindingSource uIServiceBindingSource;
        private CheckBox checkboxOngoing;
        private Label lblEmployeeOnCaseRight;
        private Label lblEmployeeOnCaseLeft;
        private Panel panel8;
        private Label lblClientTitle;
        private Panel panel9;
        private Label lblDescription;
        private Label lblCaseDescription;
        private Label lblClientEmailRight;
        private Label lblClientEmailLeft;
        private Label lblClientAgeRight;
        private Label lblClientAgeLeft;
        private Label lblClientSexRight;
        private Label lblClientSexLeft;
        private Label lblClientPhonenumberRight;
        private Label lblClientPhonenumberLeft;
        private Label lblClientAddressLeft;
        private CheckBox checkboxClientSubscription;
        private Label lblClientSubscribed;
        private Label lblClientAddressRight;
        private Button btnEditService;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn oneTimePaymentDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn startPaymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyCostDataGridViewTextBoxColumn;
        private Label lblServicesTitle;
    }
}