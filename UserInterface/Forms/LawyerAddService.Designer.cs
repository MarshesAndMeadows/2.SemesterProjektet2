namespace UserInterface.Forms
{
    partial class LawyerAddService
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
            panelEditService = new Panel();
            txtbSelectedService = new TextBox();
            lblSelectedService = new Label();
            btnSave = new Button();
            btnBack = new Button();
            lblNote = new Label();
            txtbNote = new TextBox();
            txtbUnitCount = new TextBox();
            txtbUnitCost = new TextBox();
            lblUnitCost = new Label();
            lblUnitCount = new Label();
            checkBoxHaveUnitCost = new CheckBox();
            txtbStartPayment = new TextBox();
            lblCheckBox = new Label();
            lblStartPayment = new Label();
            cboxLawyerOnService = new ComboBox();
            lblLawyerOnService = new Label();
            lblServicePreformed = new Label();
            dtpServicePreformed = new DateTimePicker();
            label1 = new Label();
            uiServiceBindingSource = new BindingSource(components);
            paneldgv = new Panel();
            dgvServiceCatalog = new DataGridView();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startPaymentDefaultDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiServiceBindingSource1 = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            panelEditService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource).BeginInit();
            paneldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceCatalog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelEditService
            // 
            panelEditService.Controls.Add(txtbSelectedService);
            panelEditService.Controls.Add(lblSelectedService);
            panelEditService.Controls.Add(btnSave);
            panelEditService.Controls.Add(btnBack);
            panelEditService.Controls.Add(lblNote);
            panelEditService.Controls.Add(txtbNote);
            panelEditService.Controls.Add(txtbUnitCount);
            panelEditService.Controls.Add(txtbUnitCost);
            panelEditService.Controls.Add(lblUnitCost);
            panelEditService.Controls.Add(lblUnitCount);
            panelEditService.Controls.Add(checkBoxHaveUnitCost);
            panelEditService.Controls.Add(txtbStartPayment);
            panelEditService.Controls.Add(lblCheckBox);
            panelEditService.Controls.Add(lblStartPayment);
            panelEditService.Controls.Add(cboxLawyerOnService);
            panelEditService.Controls.Add(lblLawyerOnService);
            panelEditService.Controls.Add(lblServicePreformed);
            panelEditService.Controls.Add(dtpServicePreformed);
            panelEditService.Controls.Add(label1);
            panelEditService.Location = new Point(12, 12);
            panelEditService.Name = "panelEditService";
            panelEditService.Size = new Size(371, 426);
            panelEditService.TabIndex = 0;
            // 
            // txtbSelectedService
            // 
            txtbSelectedService.Location = new Point(144, 10);
            txtbSelectedService.Name = "txtbSelectedService";
            txtbSelectedService.ReadOnly = true;
            txtbSelectedService.Size = new Size(200, 23);
            txtbSelectedService.TabIndex = 18;
            // 
            // lblSelectedService
            // 
            lblSelectedService.AutoSize = true;
            lblSelectedService.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedService.Location = new Point(26, 12);
            lblSelectedService.Name = "lblSelectedService";
            lblSelectedService.Size = new Size(107, 19);
            lblSelectedService.TabIndex = 17;
            lblSelectedService.Text = "Selected service:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Location = new Point(276, 398);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(15, 398);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNote.Location = new Point(15, 184);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(36, 15);
            lblNote.TabIndex = 14;
            lblNote.Text = "Note:";
            // 
            // txtbNote
            // 
            txtbNote.Location = new Point(15, 202);
            txtbNote.Multiline = true;
            txtbNote.Name = "txtbNote";
            txtbNote.Size = new Size(344, 191);
            txtbNote.TabIndex = 13;
            // 
            // txtbUnitCount
            // 
            txtbUnitCount.Location = new Point(96, 140);
            txtbUnitCount.Name = "txtbUnitCount";
            txtbUnitCount.Size = new Size(39, 23);
            txtbUnitCount.TabIndex = 12;
            // 
            // txtbUnitCost
            // 
            txtbUnitCost.Location = new Point(259, 143);
            txtbUnitCost.Name = "txtbUnitCost";
            txtbUnitCost.Size = new Size(100, 23);
            txtbUnitCost.TabIndex = 11;
            // 
            // lblUnitCost
            // 
            lblUnitCost.AutoSize = true;
            lblUnitCost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitCost.Location = new Point(174, 147);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(78, 15);
            lblUnitCost.TabIndex = 10;
            lblUnitCost.Text = "Cost per unit:";
            // 
            // lblUnitCount
            // 
            lblUnitCount.AutoSize = true;
            lblUnitCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitCount.Location = new Point(27, 147);
            lblUnitCount.Name = "lblUnitCount";
            lblUnitCount.Size = new Size(66, 15);
            lblUnitCount.TabIndex = 9;
            lblUnitCount.Text = "Unit count:";
            // 
            // checkBoxHaveUnitCost
            // 
            checkBoxHaveUnitCost.AutoSize = true;
            checkBoxHaveUnitCost.Location = new Point(97, 120);
            checkBoxHaveUnitCost.Name = "checkBoxHaveUnitCost";
            checkBoxHaveUnitCost.Size = new Size(15, 14);
            checkBoxHaveUnitCost.TabIndex = 8;
            checkBoxHaveUnitCost.UseVisualStyleBackColor = true;
            // 
            // txtbStartPayment
            // 
            txtbStartPayment.Location = new Point(259, 115);
            txtbStartPayment.Name = "txtbStartPayment";
            txtbStartPayment.Size = new Size(100, 23);
            txtbStartPayment.TabIndex = 7;
            // 
            // lblCheckBox
            // 
            lblCheckBox.AutoSize = true;
            lblCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckBox.Location = new Point(36, 119);
            lblCheckBox.Name = "lblCheckBox";
            lblCheckBox.Size = new Size(59, 15);
            lblCheckBox.TabIndex = 6;
            lblCheckBox.Text = "Unit cost?";
            // 
            // lblStartPayment
            // 
            lblStartPayment.AutoSize = true;
            lblStartPayment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartPayment.Location = new Point(146, 119);
            lblStartPayment.Name = "lblStartPayment";
            lblStartPayment.Size = new Size(107, 15);
            lblStartPayment.TabIndex = 5;
            lblStartPayment.Text = "Starting fee / Price:";
            // 
            // cboxLawyerOnService
            // 
            cboxLawyerOnService.FormattingEnabled = true;
            cboxLawyerOnService.Location = new Point(142, 75);
            cboxLawyerOnService.Name = "cboxLawyerOnService";
            cboxLawyerOnService.Size = new Size(121, 23);
            cboxLawyerOnService.TabIndex = 4;
            // 
            // lblLawyerOnService
            // 
            lblLawyerOnService.AutoSize = true;
            lblLawyerOnService.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLawyerOnService.Location = new Point(13, 77);
            lblLawyerOnService.Name = "lblLawyerOnService";
            lblLawyerOnService.Size = new Size(120, 19);
            lblLawyerOnService.TabIndex = 3;
            lblLawyerOnService.Text = "Laywer on service:";
            // 
            // lblServicePreformed
            // 
            lblServicePreformed.AutoSize = true;
            lblServicePreformed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicePreformed.Location = new Point(13, 44);
            lblServicePreformed.Name = "lblServicePreformed";
            lblServicePreformed.Size = new Size(122, 19);
            lblServicePreformed.TabIndex = 2;
            lblServicePreformed.Text = "Service preformed:";
            // 
            // dtpServicePreformed
            // 
            dtpServicePreformed.Format = DateTimePickerFormat.Short;
            dtpServicePreformed.Location = new Point(144, 42);
            dtpServicePreformed.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpServicePreformed.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpServicePreformed.Name = "dtpServicePreformed";
            dtpServicePreformed.Size = new Size(119, 23);
            dtpServicePreformed.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            // 
            // uiServiceBindingSource
            // 
            uiServiceBindingSource.DataSource = typeof(UIModels.UiService);
            // 
            // paneldgv
            // 
            paneldgv.Controls.Add(dgvServiceCatalog);
            paneldgv.Location = new Point(389, 54);
            paneldgv.Name = "paneldgv";
            paneldgv.Size = new Size(686, 378);
            paneldgv.TabIndex = 2;
            // 
            // dgvServiceCatalog
            // 
            dgvServiceCatalog.AllowUserToAddRows = false;
            dgvServiceCatalog.AllowUserToDeleteRows = false;
            dgvServiceCatalog.AutoGenerateColumns = false;
            dgvServiceCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceCatalog.Columns.AddRange(new DataGridViewColumn[] { serviceNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, startPaymentDefaultDataGridViewTextBoxColumn });
            dgvServiceCatalog.DataSource = uiServiceBindingSource1;
            dgvServiceCatalog.Dock = DockStyle.Fill;
            dgvServiceCatalog.Location = new Point(0, 0);
            dgvServiceCatalog.MultiSelect = false;
            dgvServiceCatalog.Name = "dgvServiceCatalog";
            dgvServiceCatalog.ReadOnly = true;
            dgvServiceCatalog.RowHeadersVisible = false;
            dgvServiceCatalog.RowTemplate.Height = 25;
            dgvServiceCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceCatalog.Size = new Size(686, 378);
            dgvServiceCatalog.TabIndex = 0;
            dgvServiceCatalog.CellContentDoubleClick += dgvServiceCatalog_CellDoubleClick;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "Service";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 50;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            serviceNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startPaymentDefaultDataGridViewTextBoxColumn
            // 
            startPaymentDefaultDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            startPaymentDefaultDataGridViewTextBoxColumn.DataPropertyName = "StartPaymentDefault";
            startPaymentDefaultDataGridViewTextBoxColumn.HeaderText = "Price";
            startPaymentDefaultDataGridViewTextBoxColumn.MinimumWidth = 50;
            startPaymentDefaultDataGridViewTextBoxColumn.Name = "startPaymentDefaultDataGridViewTextBoxColumn";
            startPaymentDefaultDataGridViewTextBoxColumn.ReadOnly = true;
            startPaymentDefaultDataGridViewTextBoxColumn.Width = 50;
            // 
            // uiServiceBindingSource1
            // 
            uiServiceBindingSource1.DataSource = typeof(UIModels.UiService);
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helpIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1035, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LawyerAddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 450);
            Controls.Add(pictureBox1);
            Controls.Add(paneldgv);
            Controls.Add(panelEditService);
            Name = "LawyerAddService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerAddService";
            panelEditService.ResumeLayout(false);
            panelEditService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource).EndInit();
            paneldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServiceCatalog).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditService;
        private Panel paneldgv;
        private BindingSource uiServiceBindingSource;
        private DataGridView dgvServiceCatalog;
        private BindingSource uiServiceBindingSource1;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startPaymentDefaultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitCostDefaultDataGridViewTextBoxColumn;
        private Label label1;
        private Label lblServicePreformed;
        private DateTimePicker dtpServicePreformed;
        private Label lblCheckBox;
        private Label lblStartPayment;
        private ComboBox cboxLawyerOnService;
        private Label lblLawyerOnService;
        private Label lblUnitCost;
        private Label lblUnitCount;
        private CheckBox checkBoxHaveUnitCost;
        private TextBox txtbStartPayment;
        private Label lblNote;
        private TextBox txtbNote;
        private TextBox txtbUnitCount;
        private TextBox txtbUnitCost;
        private Button btnSave;
        private Button btnBack;
        private TextBox txtbSelectedService;
        private Label lblSelectedService;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
    }
}