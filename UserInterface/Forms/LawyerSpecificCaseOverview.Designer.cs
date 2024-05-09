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
            lblServicesTitle = new Label();
            panel7 = new Panel();
            btnAddNewService = new Button();
            txtBServiceNote = new TextBox();
            lblServiceNote = new Label();
            dgvService = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            UnitCount = new DataGridViewTextBoxColumn();
            UnitCostActual = new DataGridViewTextBoxColumn();
            StartPaymentActual = new DataGridViewTextBoxColumn();
            uiAppliedServiceBindingSource1 = new BindingSource(components);
            dgvServices = new DataGridView();
            uiAppliedServiceBindingSource = new BindingSource(components);
            panel8 = new Panel();
            lblClientTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            txtBClientZipcode = new TextBox();
            lblClientZipcode = new Label();
            txtBClientAddress = new TextBox();
            txtBClientPhone = new TextBox();
            txtBClientEmail = new TextBox();
            txtBClientBirthdate = new TextBox();
            txtBClientSex = new TextBox();
            txtBClientName = new TextBox();
            btnSaveClient = new Button();
            checkboxClientSubscription = new CheckBox();
            lblClientSubscribed = new Label();
            lblClientAddressLeft = new Label();
            lblClientPhonenumberLeft = new Label();
            lblClientEmailLeft = new Label();
            lblClientBirthdateLeft = new Label();
            lblClientSexLeft = new Label();
            btnEditClient = new Button();
            lblClientNameLeft = new Label();
            btnBack = new Button();
            panel4 = new Panel();
            txtBCaseName = new TextBox();
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            btnChangeLawyer = new Button();
            txtBCaseEndDate = new TextBox();
            txtBCaseStartDate = new TextBox();
            txtBLawyerOnCase = new TextBox();
            btnSaveCase = new Button();
            txtBCaseDescription = new TextBox();
            lblDescriptionCase = new Label();
            checkboxCasedClosed = new CheckBox();
            lblEmployeeOnCaseLeft = new Label();
            lblIsFinishedLeft = new Label();
            btnEditCase = new Button();
            lblStartDateLeft = new Label();
            lblEstimatedEndDateLeft = new Label();
            uIServiceBindingSource = new BindingSource(components);
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource).BeginInit();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblServicesTitle
            // 
            lblServicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblServicesTitle.AutoSize = true;
            lblServicesTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicesTitle.Location = new Point(29, 299);
            lblServicesTitle.Name = "lblServicesTitle";
            lblServicesTitle.Size = new Size(111, 37);
            lblServicesTitle.TabIndex = 7;
            lblServicesTitle.Text = "Services";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel7.BackColor = SystemColors.AppWorkspace;
            panel7.Controls.Add(btnAddNewService);
            panel7.Controls.Add(txtBServiceNote);
            panel7.Controls.Add(lblServiceNote);
            panel7.Controls.Add(dgvService);
            panel7.Controls.Add(dgvServices);
            panel7.Location = new Point(12, 338);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(1360, 270);
            panel7.TabIndex = 2;
            // 
            // btnAddNewService
            // 
            btnAddNewService.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddNewService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddNewService.Location = new Point(1233, 196);
            btnAddNewService.Margin = new Padding(3, 2, 3, 2);
            btnAddNewService.MaximumSize = new Size(105, 52);
            btnAddNewService.Name = "btnAddNewService";
            btnAddNewService.Size = new Size(105, 52);
            btnAddNewService.TabIndex = 20;
            btnAddNewService.Text = "Add new service";
            btnAddNewService.UseVisualStyleBackColor = true;
            btnAddNewService.Click += btnAddNewService_Click;
            // 
            // txtBServiceNote
            // 
            txtBServiceNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtBServiceNote.Location = new Point(564, 41);
            txtBServiceNote.Multiline = true;
            txtBServiceNote.Name = "txtBServiceNote";
            txtBServiceNote.ReadOnly = true;
            txtBServiceNote.Size = new Size(663, 207);
            txtBServiceNote.TabIndex = 19;
            // 
            // lblServiceNote
            // 
            lblServiceNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblServiceNote.AutoSize = true;
            lblServiceNote.BackColor = SystemColors.Control;
            lblServiceNote.Location = new Point(564, 23);
            lblServiceNote.Name = "lblServiceNote";
            lblServiceNote.Size = new Size(36, 15);
            lblServiceNote.TabIndex = 13;
            lblServiceNote.Text = "Note:";
            // 
            // dgvService
            // 
            dgvService.AllowUserToAddRows = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AllowUserToResizeColumns = false;
            dgvService.AllowUserToResizeRows = false;
            dgvService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvService.AutoGenerateColumns = false;
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, UnitCount, UnitCostActual, StartPaymentActual });
            dgvService.DataSource = uiAppliedServiceBindingSource1;
            dgvService.Location = new Point(17, 12);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dgvService.RowHeadersVisible = false;
            dgvService.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvService.RowTemplate.Height = 25;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.Size = new Size(531, 247);
            dgvService.TabIndex = 3;
            dgvService.SelectionChanged += dgvService_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "AppliedServiceId";
            dataGridViewTextBoxColumn1.FillWeight = 25F;
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "ServicePerformed";
            dataGridViewTextBoxColumn6.HeaderText = "Preformed";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn6.Width = 88;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Service";
            dataGridViewTextBoxColumn7.HeaderText = "Service";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            // 
            // UnitCount
            // 
            UnitCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UnitCount.DataPropertyName = "UnitCount";
            UnitCount.HeaderText = "Count";
            UnitCount.Name = "UnitCount";
            UnitCount.ReadOnly = true;
            UnitCount.Resizable = DataGridViewTriState.False;
            UnitCount.Width = 65;
            // 
            // UnitCostActual
            // 
            UnitCostActual.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UnitCostActual.DataPropertyName = "UnitCostActual";
            UnitCostActual.HeaderText = "Cost per unit";
            UnitCostActual.Name = "UnitCostActual";
            UnitCostActual.ReadOnly = true;
            UnitCostActual.Resizable = DataGridViewTriState.False;
            UnitCostActual.Width = 73;
            // 
            // StartPaymentActual
            // 
            StartPaymentActual.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StartPaymentActual.DataPropertyName = "StartPaymentActual";
            StartPaymentActual.HeaderText = "Start Payment";
            StartPaymentActual.Name = "StartPaymentActual";
            StartPaymentActual.ReadOnly = true;
            StartPaymentActual.Resizable = DataGridViewTriState.False;
            StartPaymentActual.Width = 97;
            // 
            // uiAppliedServiceBindingSource1
            // 
            uiAppliedServiceBindingSource1.DataSource = typeof(UIModels.UiAppliedService);
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServices.AutoGenerateColumns = false;
            dgvServices.BackgroundColor = SystemColors.ButtonFace;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.DataSource = uiAppliedServiceBindingSource;
            dgvServices.Location = new Point(17, 12);
            dgvServices.Margin = new Padding(3, 2, 3, 2);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(1329, 247);
            dgvServices.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.AutoSize = true;
            panel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel8.Controls.Add(lblClientTitle);
            panel8.Controls.Add(panel2);
            panel8.Location = new Point(725, 11);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(647, 270);
            panel8.TabIndex = 1;
            // 
            // lblClientTitle
            // 
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.Location = new Point(24, 5);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(145, 37);
            lblClientTitle.TabIndex = 0;
            lblClientTitle.Text = "Client info:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 226);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(txtBClientZipcode);
            panel3.Controls.Add(lblClientZipcode);
            panel3.Controls.Add(txtBClientAddress);
            panel3.Controls.Add(txtBClientPhone);
            panel3.Controls.Add(txtBClientEmail);
            panel3.Controls.Add(txtBClientBirthdate);
            panel3.Controls.Add(txtBClientSex);
            panel3.Controls.Add(txtBClientName);
            panel3.Controls.Add(btnSaveClient);
            panel3.Controls.Add(checkboxClientSubscription);
            panel3.Controls.Add(lblClientSubscribed);
            panel3.Controls.Add(lblClientAddressLeft);
            panel3.Controls.Add(lblClientPhonenumberLeft);
            panel3.Controls.Add(lblClientEmailLeft);
            panel3.Controls.Add(lblClientBirthdateLeft);
            panel3.Controls.Add(lblClientSexLeft);
            panel3.Controls.Add(btnEditClient);
            panel3.Controls.Add(lblClientNameLeft);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(15, 16);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 197);
            panel3.TabIndex = 0;
            // 
            // txtBClientZipcode
            // 
            txtBClientZipcode.Location = new Point(294, 138);
            txtBClientZipcode.Name = "txtBClientZipcode";
            txtBClientZipcode.ReadOnly = true;
            txtBClientZipcode.Size = new Size(120, 23);
            txtBClientZipcode.TabIndex = 24;
            // 
            // lblClientZipcode
            // 
            lblClientZipcode.AutoSize = true;
            lblClientZipcode.Location = new Point(235, 144);
            lblClientZipcode.Name = "lblClientZipcode";
            lblClientZipcode.Size = new Size(53, 15);
            lblClientZipcode.TabIndex = 23;
            lblClientZipcode.Text = "Zipcode:";
            // 
            // txtBClientAddress
            // 
            txtBClientAddress.Location = new Point(109, 138);
            txtBClientAddress.Name = "txtBClientAddress";
            txtBClientAddress.ReadOnly = true;
            txtBClientAddress.Size = new Size(120, 23);
            txtBClientAddress.TabIndex = 22;
            // 
            // txtBClientPhone
            // 
            txtBClientPhone.Location = new Point(109, 112);
            txtBClientPhone.Name = "txtBClientPhone";
            txtBClientPhone.ReadOnly = true;
            txtBClientPhone.Size = new Size(120, 23);
            txtBClientPhone.TabIndex = 21;
            // 
            // txtBClientEmail
            // 
            txtBClientEmail.Location = new Point(109, 86);
            txtBClientEmail.Name = "txtBClientEmail";
            txtBClientEmail.ReadOnly = true;
            txtBClientEmail.Size = new Size(200, 23);
            txtBClientEmail.TabIndex = 20;
            // 
            // txtBClientBirthdate
            // 
            txtBClientBirthdate.Location = new Point(109, 61);
            txtBClientBirthdate.Name = "txtBClientBirthdate";
            txtBClientBirthdate.ReadOnly = true;
            txtBClientBirthdate.Size = new Size(120, 23);
            txtBClientBirthdate.TabIndex = 19;
            // 
            // txtBClientSex
            // 
            txtBClientSex.Location = new Point(109, 36);
            txtBClientSex.Name = "txtBClientSex";
            txtBClientSex.ReadOnly = true;
            txtBClientSex.Size = new Size(25, 23);
            txtBClientSex.TabIndex = 18;
            // 
            // txtBClientName
            // 
            txtBClientName.Location = new Point(109, 11);
            txtBClientName.Name = "txtBClientName";
            txtBClientName.ReadOnly = true;
            txtBClientName.Size = new Size(120, 23);
            txtBClientName.TabIndex = 17;
            // 
            // btnSaveClient
            // 
            btnSaveClient.Location = new Point(502, 81);
            btnSaveClient.Margin = new Padding(3, 2, 3, 2);
            btnSaveClient.MaximumSize = new Size(105, 52);
            btnSaveClient.Name = "btnSaveClient";
            btnSaveClient.Size = new Size(105, 52);
            btnSaveClient.TabIndex = 16;
            btnSaveClient.Text = "Save";
            btnSaveClient.UseVisualStyleBackColor = true;
            btnSaveClient.Visible = false;
            btnSaveClient.Click += btnSave_Click;
            // 
            // checkboxClientSubscription
            // 
            checkboxClientSubscription.AutoSize = true;
            checkboxClientSubscription.Enabled = false;
            checkboxClientSubscription.Location = new Point(109, 169);
            checkboxClientSubscription.Margin = new Padding(3, 2, 3, 2);
            checkboxClientSubscription.Name = "checkboxClientSubscription";
            checkboxClientSubscription.Size = new Size(15, 14);
            checkboxClientSubscription.TabIndex = 15;
            checkboxClientSubscription.UseVisualStyleBackColor = true;
            // 
            // lblClientSubscribed
            // 
            lblClientSubscribed.AutoSize = true;
            lblClientSubscribed.Location = new Point(14, 168);
            lblClientSubscribed.Name = "lblClientSubscribed";
            lblClientSubscribed.Size = new Size(78, 15);
            lblClientSubscribed.TabIndex = 14;
            lblClientSubscribed.Text = "Subscription?";
            // 
            // lblClientAddressLeft
            // 
            lblClientAddressLeft.AutoSize = true;
            lblClientAddressLeft.Location = new Point(14, 144);
            lblClientAddressLeft.Name = "lblClientAddressLeft";
            lblClientAddressLeft.Size = new Size(52, 15);
            lblClientAddressLeft.TabIndex = 12;
            lblClientAddressLeft.Text = "Address:";
            // 
            // lblClientPhonenumberLeft
            // 
            lblClientPhonenumberLeft.AutoSize = true;
            lblClientPhonenumberLeft.Location = new Point(14, 118);
            lblClientPhonenumberLeft.Name = "lblClientPhonenumberLeft";
            lblClientPhonenumberLeft.Size = new Size(89, 15);
            lblClientPhonenumberLeft.TabIndex = 10;
            lblClientPhonenumberLeft.Text = "Phone number:";
            // 
            // lblClientEmailLeft
            // 
            lblClientEmailLeft.AutoSize = true;
            lblClientEmailLeft.Location = new Point(14, 93);
            lblClientEmailLeft.Name = "lblClientEmailLeft";
            lblClientEmailLeft.Size = new Size(39, 15);
            lblClientEmailLeft.TabIndex = 8;
            lblClientEmailLeft.Text = "Email:";
            // 
            // lblClientBirthdateLeft
            // 
            lblClientBirthdateLeft.AutoSize = true;
            lblClientBirthdateLeft.Location = new Point(14, 65);
            lblClientBirthdateLeft.Name = "lblClientBirthdateLeft";
            lblClientBirthdateLeft.Size = new Size(58, 15);
            lblClientBirthdateLeft.TabIndex = 6;
            lblClientBirthdateLeft.Text = "Birthdate:";
            // 
            // lblClientSexLeft
            // 
            lblClientSexLeft.AutoSize = true;
            lblClientSexLeft.Location = new Point(14, 40);
            lblClientSexLeft.Name = "lblClientSexLeft";
            lblClientSexLeft.Size = new Size(28, 15);
            lblClientSexLeft.TabIndex = 4;
            lblClientSexLeft.Text = "Sex:";
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(502, 138);
            btnEditClient.Margin = new Padding(3, 2, 3, 2);
            btnEditClient.MaximumSize = new Size(105, 52);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(105, 52);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // lblClientNameLeft
            // 
            lblClientNameLeft.AutoSize = true;
            lblClientNameLeft.Location = new Point(14, 15);
            lblClientNameLeft.Name = "lblClientNameLeft";
            lblClientNameLeft.Size = new Size(74, 15);
            lblClientNameLeft.TabIndex = 0;
            lblClientNameLeft.Text = "Client name:";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(12, 612);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(txtBCaseName);
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 11);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(673, 270);
            panel4.TabIndex = 2;
            // 
            // txtBCaseName
            // 
            txtBCaseName.BorderStyle = BorderStyle.None;
            txtBCaseName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtBCaseName.Location = new Point(95, 5);
            txtBCaseName.Name = "txtBCaseName";
            txtBCaseName.ReadOnly = true;
            txtBCaseName.Size = new Size(565, 36);
            txtBCaseName.TabIndex = 18;
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
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 42);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(670, 226);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Controls.Add(btnChangeLawyer);
            panel6.Controls.Add(txtBCaseEndDate);
            panel6.Controls.Add(txtBCaseStartDate);
            panel6.Controls.Add(txtBLawyerOnCase);
            panel6.Controls.Add(btnSaveCase);
            panel6.Controls.Add(txtBCaseDescription);
            panel6.Controls.Add(lblDescriptionCase);
            panel6.Controls.Add(checkboxCasedClosed);
            panel6.Controls.Add(lblEmployeeOnCaseLeft);
            panel6.Controls.Add(lblIsFinishedLeft);
            panel6.Controls.Add(btnEditCase);
            panel6.Controls.Add(lblStartDateLeft);
            panel6.Controls.Add(lblEstimatedEndDateLeft);
            panel6.Location = new Point(17, 16);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(639, 197);
            panel6.TabIndex = 0;
            // 
            // btnChangeLawyer
            // 
            btnChangeLawyer.Location = new Point(195, 5);
            btnChangeLawyer.Margin = new Padding(3, 2, 3, 2);
            btnChangeLawyer.MaximumSize = new Size(105, 52);
            btnChangeLawyer.Name = "btnChangeLawyer";
            btnChangeLawyer.Size = new Size(103, 25);
            btnChangeLawyer.TabIndex = 23;
            btnChangeLawyer.Text = "Change Lawyer";
            btnChangeLawyer.UseVisualStyleBackColor = true;
            btnChangeLawyer.Visible = false;
            btnChangeLawyer.Click += btnChangeLawyer_Click;
            // 
            // txtBCaseEndDate
            // 
            txtBCaseEndDate.Location = new Point(273, 34);
            txtBCaseEndDate.Name = "txtBCaseEndDate";
            txtBCaseEndDate.ReadOnly = true;
            txtBCaseEndDate.Size = new Size(80, 23);
            txtBCaseEndDate.TabIndex = 22;
            // 
            // txtBCaseStartDate
            // 
            txtBCaseStartDate.Location = new Point(70, 34);
            txtBCaseStartDate.Name = "txtBCaseStartDate";
            txtBCaseStartDate.ReadOnly = true;
            txtBCaseStartDate.Size = new Size(80, 23);
            txtBCaseStartDate.TabIndex = 21;
            // 
            // txtBLawyerOnCase
            // 
            txtBLawyerOnCase.Location = new Point(70, 5);
            txtBLawyerOnCase.Name = "txtBLawyerOnCase";
            txtBLawyerOnCase.ReadOnly = true;
            txtBLawyerOnCase.Size = new Size(120, 23);
            txtBLawyerOnCase.TabIndex = 20;
            // 
            // btnSaveCase
            // 
            btnSaveCase.Location = new Point(526, 81);
            btnSaveCase.Margin = new Padding(3, 2, 3, 2);
            btnSaveCase.MaximumSize = new Size(105, 52);
            btnSaveCase.Name = "btnSaveCase";
            btnSaveCase.Size = new Size(105, 52);
            btnSaveCase.TabIndex = 19;
            btnSaveCase.Text = "Save";
            btnSaveCase.UseVisualStyleBackColor = true;
            btnSaveCase.Visible = false;
            btnSaveCase.Click += btnSaveCase_Click;
            // 
            // txtBCaseDescription
            // 
            txtBCaseDescription.Location = new Point(9, 105);
            txtBCaseDescription.Multiline = true;
            txtBCaseDescription.Name = "txtBCaseDescription";
            txtBCaseDescription.ReadOnly = true;
            txtBCaseDescription.Size = new Size(382, 85);
            txtBCaseDescription.TabIndex = 18;
            // 
            // lblDescriptionCase
            // 
            lblDescriptionCase.AutoSize = true;
            lblDescriptionCase.Location = new Point(9, 89);
            lblDescriptionCase.Name = "lblDescriptionCase";
            lblDescriptionCase.Size = new Size(70, 15);
            lblDescriptionCase.TabIndex = 12;
            lblDescriptionCase.Text = "Description:";
            // 
            // checkboxCasedClosed
            // 
            checkboxCasedClosed.AutoSize = true;
            checkboxCasedClosed.Enabled = false;
            checkboxCasedClosed.Location = new Point(89, 67);
            checkboxCasedClosed.Margin = new Padding(3, 2, 3, 2);
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
            // btnEditCase
            // 
            btnEditCase.Location = new Point(526, 137);
            btnEditCase.Margin = new Padding(3, 2, 3, 2);
            btnEditCase.Name = "btnEditCase";
            btnEditCase.Size = new Size(105, 52);
            btnEditCase.TabIndex = 1;
            btnEditCase.Text = "Edit Case";
            btnEditCase.UseVisualStyleBackColor = true;
            btnEditCase.Click += btnEditCase_Click;
            // 
            // lblStartDateLeft
            // 
            lblStartDateLeft.AutoSize = true;
            lblStartDateLeft.Location = new Point(9, 37);
            lblStartDateLeft.Name = "lblStartDateLeft";
            lblStartDateLeft.Size = new Size(60, 15);
            lblStartDateLeft.TabIndex = 2;
            lblStartDateLeft.Text = "Start date:";
            // 
            // lblEstimatedEndDateLeft
            // 
            lblEstimatedEndDateLeft.AutoSize = true;
            lblEstimatedEndDateLeft.Location = new Point(156, 37);
            lblEstimatedEndDateLeft.Name = "lblEstimatedEndDateLeft";
            lblEstimatedEndDateLeft.Size = new Size(111, 15);
            lblEstimatedEndDateLeft.TabIndex = 1;
            lblEstimatedEndDateLeft.Text = "Estimated end date:";
            // 
            // LawyerSpecificCaseOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1384, 640);
            Controls.Add(lblServicesTitle);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(btnBack);
            Controls.Add(panel8);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LawyerSpecificCaseOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerSpecificCaseOverview";
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiAppliedServiceBindingSource).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)uIServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Button btnEditClient;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dgvServices;
        private Label lblCaseTitle;
        private Label lblClientNameLeft;
        private Label lblEstimatedEndDateLeft;
        private Label lblStartDateLeft;
        private Panel panel7;
        private Button btnEditCase;
        private Button btnBack;
        private Label lblIsFinishedLeft;
        private BindingSource uIServiceBindingSource;
        private CheckBox checkboxCasedClosed;
        private Label lblEmployeeOnCaseLeft;
        private Panel panel8;
        private Label lblClientTitle;
        private Label lblDescriptionCase;
        private Label lblClientEmailLeft;
        private Label lblClientBirthdateLeft;
        private Label lblClientSexLeft;
        private Label lblClientPhonenumberLeft;
        private Label lblClientAddressLeft;
        private CheckBox checkboxClientSubscription;
        private Label lblClientSubscribed;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPaymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyCostDataGridViewTextBoxColumn;
        private Label lblServicesTitle;
        private DataGridViewTextBoxColumn appliedServiceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitCostActualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPaymentActualDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn servicePerformedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private BindingSource uiAppliedServiceBindingSource;
        private Button btnSaveClient;
        private TextBox txtBClientName;
        private TextBox txtBClientBirthdate;
        private TextBox txtBClientSex;
        private TextBox txtBClientEmail;
        private TextBox txtBClientPhone;
        private TextBox txtBClientAddress;
        private Label lblClientZipcode;
        private TextBox txtBClientZipcode;
        private TextBox txtBCaseName;
        private TextBox txtBCaseDescription;
        private Button btnSaveCase;
        private TextBox txtBCaseEndDate;
        private TextBox txtBCaseStartDate;
        private TextBox txtBLawyerOnCase;
        private DataGridView dgvService;
        private BindingSource uiAppliedServiceBindingSource1;
        private TextBox txtBServiceNote;
        private Label lblServiceNote;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn UnitCount;
        private DataGridViewTextBoxColumn UnitCostActual;
        private DataGridViewTextBoxColumn StartPaymentActual;
        private Button btnAddNewService;
        private Button btnChangeLawyer;
    }
}