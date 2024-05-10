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
            lblServicesTitle.Location = new Point(33, 399);
            lblServicesTitle.Name = "lblServicesTitle";
            lblServicesTitle.Size = new Size(140, 46);
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
            panel7.Location = new Point(14, 451);
            panel7.Name = "panel7";
            panel7.Size = new Size(1554, 360);
            panel7.TabIndex = 2;
            // 
            // btnAddNewService
            // 
            btnAddNewService.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddNewService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddNewService.Location = new Point(1409, 261);
            btnAddNewService.MaximumSize = new Size(120, 69);
            btnAddNewService.Name = "btnAddNewService";
            btnAddNewService.Size = new Size(120, 69);
            btnAddNewService.TabIndex = 20;
            btnAddNewService.Text = "Add new service";
            btnAddNewService.UseVisualStyleBackColor = true;
            btnAddNewService.Click += btnAddNewService_Click;
            // 
            // txtBServiceNote
            // 
            txtBServiceNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtBServiceNote.Location = new Point(645, 55);
            txtBServiceNote.Margin = new Padding(3, 4, 3, 4);
            txtBServiceNote.Multiline = true;
            txtBServiceNote.Name = "txtBServiceNote";
            txtBServiceNote.ReadOnly = true;
            txtBServiceNote.Size = new Size(757, 275);
            txtBServiceNote.TabIndex = 19;
            // 
            // lblServiceNote
            // 
            lblServiceNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblServiceNote.AutoSize = true;
            lblServiceNote.BackColor = SystemColors.Control;
            lblServiceNote.Location = new Point(645, 31);
            lblServiceNote.Name = "lblServiceNote";
            lblServiceNote.Size = new Size(45, 20);
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
            dgvService.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, UnitCount, UnitCostActual, StartPaymentActual });
            dgvService.DataSource = uiAppliedServiceBindingSource1;
            dgvService.Location = new Point(19, 16);
            dgvService.Margin = new Padding(3, 4, 3, 4);
            dgvService.MultiSelect = false;
            dgvService.Name = "dgvService";
            dgvService.ReadOnly = true;
            dgvService.RowHeadersVisible = false;
            dgvService.RowHeadersWidth = 51;
            dgvService.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvService.RowTemplate.Height = 25;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvService.Size = new Size(607, 329);
            dgvService.TabIndex = 3;
            dgvService.SelectionChanged += dgvService_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "ServicePerformed";
            dataGridViewTextBoxColumn6.HeaderText = "Preformed";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn6.Width = 108;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "Service";
            dataGridViewTextBoxColumn7.HeaderText = "Service";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            // 
            // UnitCount
            // 
            UnitCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UnitCount.DataPropertyName = "UnitCount";
            UnitCount.HeaderText = "Count";
            UnitCount.MinimumWidth = 6;
            UnitCount.Name = "UnitCount";
            UnitCount.ReadOnly = true;
            UnitCount.Resizable = DataGridViewTriState.False;
            UnitCount.Width = 77;
            // 
            // UnitCostActual
            // 
            UnitCostActual.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UnitCostActual.DataPropertyName = "UnitCostActual";
            UnitCostActual.HeaderText = "Cost per unit";
            UnitCostActual.MinimumWidth = 6;
            UnitCostActual.Name = "UnitCostActual";
            UnitCostActual.ReadOnly = true;
            UnitCostActual.Resizable = DataGridViewTriState.False;
            UnitCostActual.Width = 90;
            // 
            // StartPaymentActual
            // 
            StartPaymentActual.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StartPaymentActual.DataPropertyName = "StartPaymentActual";
            StartPaymentActual.HeaderText = "Start Payment";
            StartPaymentActual.MinimumWidth = 6;
            StartPaymentActual.Name = "StartPaymentActual";
            StartPaymentActual.ReadOnly = true;
            StartPaymentActual.Resizable = DataGridViewTriState.False;
            StartPaymentActual.Width = 119;
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
            dgvServices.Location = new Point(19, 16);
            dgvServices.MultiSelect = false;
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(1519, 329);
            dgvServices.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel8.AutoSize = true;
            panel8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel8.Controls.Add(lblClientTitle);
            panel8.Controls.Add(panel2);
            panel8.Location = new Point(829, 15);
            panel8.Name = "panel8";
            panel8.Size = new Size(739, 360);
            panel8.TabIndex = 1;
            // 
            // lblClientTitle
            // 
            lblClientTitle.AutoSize = true;
            lblClientTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientTitle.Location = new Point(27, 7);
            lblClientTitle.Name = "lblClientTitle";
            lblClientTitle.Size = new Size(180, 46);
            lblClientTitle.TabIndex = 0;
            lblClientTitle.Text = "Client info:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 301);
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
            panel3.Location = new Point(17, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 263);
            panel3.TabIndex = 0;
            // 
            // txtBClientZipcode
            // 
            txtBClientZipcode.Location = new Point(336, 184);
            txtBClientZipcode.Margin = new Padding(3, 4, 3, 4);
            txtBClientZipcode.Name = "txtBClientZipcode";
            txtBClientZipcode.ReadOnly = true;
            txtBClientZipcode.Size = new Size(137, 27);
            txtBClientZipcode.TabIndex = 24;
            // 
            // lblClientZipcode
            // 
            lblClientZipcode.AutoSize = true;
            lblClientZipcode.Location = new Point(269, 192);
            lblClientZipcode.Name = "lblClientZipcode";
            lblClientZipcode.Size = new Size(67, 20);
            lblClientZipcode.TabIndex = 23;
            lblClientZipcode.Text = "Zipcode:";
            // 
            // txtBClientAddress
            // 
            txtBClientAddress.Location = new Point(125, 184);
            txtBClientAddress.Margin = new Padding(3, 4, 3, 4);
            txtBClientAddress.Name = "txtBClientAddress";
            txtBClientAddress.ReadOnly = true;
            txtBClientAddress.Size = new Size(137, 27);
            txtBClientAddress.TabIndex = 22;
            // 
            // txtBClientPhone
            // 
            txtBClientPhone.Location = new Point(125, 149);
            txtBClientPhone.Margin = new Padding(3, 4, 3, 4);
            txtBClientPhone.Name = "txtBClientPhone";
            txtBClientPhone.ReadOnly = true;
            txtBClientPhone.Size = new Size(137, 27);
            txtBClientPhone.TabIndex = 21;
            // 
            // txtBClientEmail
            // 
            txtBClientEmail.Location = new Point(125, 115);
            txtBClientEmail.Margin = new Padding(3, 4, 3, 4);
            txtBClientEmail.Name = "txtBClientEmail";
            txtBClientEmail.ReadOnly = true;
            txtBClientEmail.Size = new Size(228, 27);
            txtBClientEmail.TabIndex = 20;
            // 
            // txtBClientBirthdate
            // 
            txtBClientBirthdate.Location = new Point(125, 81);
            txtBClientBirthdate.Margin = new Padding(3, 4, 3, 4);
            txtBClientBirthdate.Name = "txtBClientBirthdate";
            txtBClientBirthdate.ReadOnly = true;
            txtBClientBirthdate.Size = new Size(137, 27);
            txtBClientBirthdate.TabIndex = 19;
            // 
            // txtBClientSex
            // 
            txtBClientSex.Location = new Point(125, 48);
            txtBClientSex.Margin = new Padding(3, 4, 3, 4);
            txtBClientSex.Name = "txtBClientSex";
            txtBClientSex.ReadOnly = true;
            txtBClientSex.Size = new Size(28, 27);
            txtBClientSex.TabIndex = 18;
            // 
            // txtBClientName
            // 
            txtBClientName.Location = new Point(125, 15);
            txtBClientName.Margin = new Padding(3, 4, 3, 4);
            txtBClientName.Name = "txtBClientName";
            txtBClientName.ReadOnly = true;
            txtBClientName.Size = new Size(137, 27);
            txtBClientName.TabIndex = 17;
            // 
            // btnSaveClient
            // 
            btnSaveClient.Location = new Point(574, 108);
            btnSaveClient.MaximumSize = new Size(120, 69);
            btnSaveClient.Name = "btnSaveClient";
            btnSaveClient.Size = new Size(120, 69);
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
            checkboxClientSubscription.Location = new Point(125, 225);
            checkboxClientSubscription.Name = "checkboxClientSubscription";
            checkboxClientSubscription.Size = new Size(18, 17);
            checkboxClientSubscription.TabIndex = 15;
            checkboxClientSubscription.UseVisualStyleBackColor = true;
            // 
            // lblClientSubscribed
            // 
            lblClientSubscribed.AutoSize = true;
            lblClientSubscribed.Location = new Point(16, 224);
            lblClientSubscribed.Name = "lblClientSubscribed";
            lblClientSubscribed.Size = new Size(98, 20);
            lblClientSubscribed.TabIndex = 14;
            lblClientSubscribed.Text = "Subscription?";
            // 
            // lblClientAddressLeft
            // 
            lblClientAddressLeft.AutoSize = true;
            lblClientAddressLeft.Location = new Point(16, 192);
            lblClientAddressLeft.Name = "lblClientAddressLeft";
            lblClientAddressLeft.Size = new Size(65, 20);
            lblClientAddressLeft.TabIndex = 12;
            lblClientAddressLeft.Text = "Address:";
            // 
            // lblClientPhonenumberLeft
            // 
            lblClientPhonenumberLeft.AutoSize = true;
            lblClientPhonenumberLeft.Location = new Point(16, 157);
            lblClientPhonenumberLeft.Name = "lblClientPhonenumberLeft";
            lblClientPhonenumberLeft.Size = new Size(108, 20);
            lblClientPhonenumberLeft.TabIndex = 10;
            lblClientPhonenumberLeft.Text = "Phone number:";
            // 
            // lblClientEmailLeft
            // 
            lblClientEmailLeft.AutoSize = true;
            lblClientEmailLeft.Location = new Point(16, 124);
            lblClientEmailLeft.Name = "lblClientEmailLeft";
            lblClientEmailLeft.Size = new Size(49, 20);
            lblClientEmailLeft.TabIndex = 8;
            lblClientEmailLeft.Text = "Email:";
            // 
            // lblClientBirthdateLeft
            // 
            lblClientBirthdateLeft.AutoSize = true;
            lblClientBirthdateLeft.Location = new Point(16, 87);
            lblClientBirthdateLeft.Name = "lblClientBirthdateLeft";
            lblClientBirthdateLeft.Size = new Size(73, 20);
            lblClientBirthdateLeft.TabIndex = 6;
            lblClientBirthdateLeft.Text = "Birthdate:";
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
            btnEditClient.Location = new Point(574, 184);
            btnEditClient.MaximumSize = new Size(120, 69);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(120, 69);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // lblClientNameLeft
            // 
            lblClientNameLeft.AutoSize = true;
            lblClientNameLeft.Location = new Point(16, 20);
            lblClientNameLeft.Name = "lblClientNameLeft";
            lblClientNameLeft.Size = new Size(91, 20);
            lblClientNameLeft.TabIndex = 0;
            lblClientNameLeft.Text = "Client name:";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(14, 816);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
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
            panel4.Location = new Point(14, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 360);
            panel4.TabIndex = 2;
            // 
            // txtBCaseName
            // 
            txtBCaseName.BorderStyle = BorderStyle.None;
            txtBCaseName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtBCaseName.Location = new Point(109, 7);
            txtBCaseName.Margin = new Padding(3, 4, 3, 4);
            txtBCaseName.Name = "txtBCaseName";
            txtBCaseName.ReadOnly = true;
            txtBCaseName.Size = new Size(646, 45);
            txtBCaseName.TabIndex = 18;
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseTitle.Location = new Point(19, 5);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(97, 46);
            lblCaseTitle.TabIndex = 1;
            lblCaseTitle.Text = "Case:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(0, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(766, 301);
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
            panel6.Location = new Point(19, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(730, 263);
            panel6.TabIndex = 0;
            // 
            // btnChangeLawyer
            // 
            btnChangeLawyer.Location = new Point(223, 5);
            btnChangeLawyer.MaximumSize = new Size(120, 69);
            btnChangeLawyer.Name = "btnChangeLawyer";
            btnChangeLawyer.Size = new Size(118, 33);
            btnChangeLawyer.TabIndex = 23;
            btnChangeLawyer.Text = "Change Lawyer";
            btnChangeLawyer.UseVisualStyleBackColor = true;
            btnChangeLawyer.Visible = false;
            btnChangeLawyer.Click += btnChangeLawyer_Click;
            // 
            // txtBCaseEndDate
            // 
            txtBCaseEndDate.Location = new Point(312, 45);
            txtBCaseEndDate.Margin = new Padding(3, 4, 3, 4);
            txtBCaseEndDate.Name = "txtBCaseEndDate";
            txtBCaseEndDate.ReadOnly = true;
            txtBCaseEndDate.Size = new Size(91, 27);
            txtBCaseEndDate.TabIndex = 22;
            // 
            // txtBCaseStartDate
            // 
            txtBCaseStartDate.Location = new Point(80, 45);
            txtBCaseStartDate.Margin = new Padding(3, 4, 3, 4);
            txtBCaseStartDate.Name = "txtBCaseStartDate";
            txtBCaseStartDate.ReadOnly = true;
            txtBCaseStartDate.Size = new Size(91, 27);
            txtBCaseStartDate.TabIndex = 21;
            // 
            // txtBLawyerOnCase
            // 
            txtBLawyerOnCase.Location = new Point(80, 7);
            txtBLawyerOnCase.Margin = new Padding(3, 4, 3, 4);
            txtBLawyerOnCase.Name = "txtBLawyerOnCase";
            txtBLawyerOnCase.ReadOnly = true;
            txtBLawyerOnCase.Size = new Size(137, 27);
            txtBLawyerOnCase.TabIndex = 20;
            // 
            // btnSaveCase
            // 
            btnSaveCase.Enabled = false;
            btnSaveCase.Location = new Point(601, 108);
            btnSaveCase.MaximumSize = new Size(120, 69);
            btnSaveCase.Name = "btnSaveCase";
            btnSaveCase.Size = new Size(120, 69);
            btnSaveCase.TabIndex = 19;
            btnSaveCase.Text = "Save";
            btnSaveCase.UseVisualStyleBackColor = true;
            btnSaveCase.Visible = false;
            btnSaveCase.Click += btnSaveCase_Click;
            // 
            // txtBCaseDescription
            // 
            txtBCaseDescription.Location = new Point(10, 140);
            txtBCaseDescription.Margin = new Padding(3, 4, 3, 4);
            txtBCaseDescription.Multiline = true;
            txtBCaseDescription.Name = "txtBCaseDescription";
            txtBCaseDescription.ReadOnly = true;
            txtBCaseDescription.Size = new Size(436, 112);
            txtBCaseDescription.TabIndex = 18;
            // 
            // lblDescriptionCase
            // 
            lblDescriptionCase.AutoSize = true;
            lblDescriptionCase.Location = new Point(10, 119);
            lblDescriptionCase.Name = "lblDescriptionCase";
            lblDescriptionCase.Size = new Size(88, 20);
            lblDescriptionCase.TabIndex = 12;
            lblDescriptionCase.Text = "Description:";
            // 
            // checkboxCasedClosed
            // 
            checkboxCasedClosed.AutoSize = true;
            checkboxCasedClosed.Enabled = false;
            checkboxCasedClosed.Location = new Point(102, 89);
            checkboxCasedClosed.Name = "checkboxCasedClosed";
            checkboxCasedClosed.Size = new Size(18, 17);
            checkboxCasedClosed.TabIndex = 10;
            checkboxCasedClosed.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeOnCaseLeft
            // 
            lblEmployeeOnCaseLeft.AutoSize = true;
            lblEmployeeOnCaseLeft.Location = new Point(10, 11);
            lblEmployeeOnCaseLeft.Name = "lblEmployeeOnCaseLeft";
            lblEmployeeOnCaseLeft.Size = new Size(58, 20);
            lblEmployeeOnCaseLeft.TabIndex = 8;
            lblEmployeeOnCaseLeft.Text = "Lawyer:";
            // 
            // lblIsFinishedLeft
            // 
            lblIsFinishedLeft.AutoSize = true;
            lblIsFinishedLeft.Location = new Point(10, 88);
            lblIsFinishedLeft.Name = "lblIsFinishedLeft";
            lblIsFinishedLeft.Size = new Size(94, 20);
            lblIsFinishedLeft.TabIndex = 6;
            lblIsFinishedLeft.Text = "Case closed?";
            // 
            // btnEditCase
            // 
            btnEditCase.Location = new Point(601, 183);
            btnEditCase.Name = "btnEditCase";
            btnEditCase.Size = new Size(120, 69);
            btnEditCase.TabIndex = 1;
            btnEditCase.Text = "Edit Case";
            btnEditCase.UseVisualStyleBackColor = true;
            btnEditCase.Click += btnEditCase_Click;
            // 
            // lblStartDateLeft
            // 
            lblStartDateLeft.AutoSize = true;
            lblStartDateLeft.Location = new Point(10, 49);
            lblStartDateLeft.Name = "lblStartDateLeft";
            lblStartDateLeft.Size = new Size(77, 20);
            lblStartDateLeft.TabIndex = 2;
            lblStartDateLeft.Text = "Start date:";
            // 
            // lblEstimatedEndDateLeft
            // 
            lblEstimatedEndDateLeft.AutoSize = true;
            lblEstimatedEndDateLeft.Location = new Point(178, 49);
            lblEstimatedEndDateLeft.Name = "lblEstimatedEndDateLeft";
            lblEstimatedEndDateLeft.Size = new Size(141, 20);
            lblEstimatedEndDateLeft.TabIndex = 1;
            lblEstimatedEndDateLeft.Text = "Estimated end date:";
            // 
            // LawyerSpecificCaseOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1582, 853);
            Controls.Add(lblServicesTitle);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(btnBack);
            Controls.Add(panel8);
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