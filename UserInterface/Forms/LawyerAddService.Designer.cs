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
            btnAddService = new Button();
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
            uiLawyerBindingSource = new BindingSource(components);
            lblLawyerOnService = new Label();
            lblServicePreformed = new Label();
            dtpServicePreformed = new DateTimePicker();
            label1 = new Label();
            uiServiceBindingSource = new BindingSource(components);
            paneldgv = new Panel();
            dgvServiceCatalog = new DataGridView();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiServiceBindingSource1 = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            panelEditService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource).BeginInit();
            paneldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiceCatalog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelEditService
            // 
            panelEditService.Controls.Add(txtbSelectedService);
            panelEditService.Controls.Add(lblSelectedService);
            panelEditService.Controls.Add(btnAddService);
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
            panelEditService.Location = new Point(14, 16);
            panelEditService.Margin = new Padding(3, 4, 3, 4);
            panelEditService.Name = "panelEditService";
            panelEditService.Size = new Size(424, 568);
            panelEditService.TabIndex = 0;
            // 
            // txtbSelectedService
            // 
            txtbSelectedService.Location = new Point(165, 13);
            txtbSelectedService.Margin = new Padding(3, 4, 3, 4);
            txtbSelectedService.Name = "txtbSelectedService";
            txtbSelectedService.ReadOnly = true;
            txtbSelectedService.Size = new Size(228, 27);
            txtbSelectedService.TabIndex = 18;
            // 
            // lblSelectedService
            // 
            lblSelectedService.AutoSize = true;
            lblSelectedService.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectedService.Location = new Point(30, 16);
            lblSelectedService.Name = "lblSelectedService";
            lblSelectedService.Size = new Size(134, 23);
            lblSelectedService.TabIndex = 17;
            lblSelectedService.Text = "Selected service:";
            // 
            // btnAddService
            // 
            btnAddService.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddService.Enabled = false;
            btnAddService.Location = new Point(315, 531);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(94, 29);
            btnAddService.TabIndex = 16;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnSaveAsync_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(17, 531);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNote.Location = new Point(17, 245);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(45, 20);
            lblNote.TabIndex = 14;
            lblNote.Text = "Note:";
            // 
            // txtbNote
            // 
            txtbNote.Location = new Point(17, 269);
            txtbNote.Margin = new Padding(3, 4, 3, 4);
            txtbNote.Multiline = true;
            txtbNote.Name = "txtbNote";
            txtbNote.Size = new Size(393, 253);
            txtbNote.TabIndex = 13;
            // 
            // txtbUnitCount
            // 
            txtbUnitCount.Location = new Point(110, 187);
            txtbUnitCount.Margin = new Padding(3, 4, 3, 4);
            txtbUnitCount.Name = "txtbUnitCount";
            txtbUnitCount.Size = new Size(44, 27);
            txtbUnitCount.TabIndex = 12;
            // 
            // txtbUnitCost
            // 
            txtbUnitCost.Location = new Point(281, 193);
            txtbUnitCost.Margin = new Padding(3, 4, 3, 4);
            txtbUnitCost.Name = "txtbUnitCost";
            txtbUnitCost.Size = new Size(114, 27);
            txtbUnitCost.TabIndex = 11;
            // 
            // lblUnitCost
            // 
            lblUnitCost.AutoSize = true;
            lblUnitCost.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitCost.Location = new Point(186, 196);
            lblUnitCost.Name = "lblUnitCost";
            lblUnitCost.Size = new Size(96, 20);
            lblUnitCost.TabIndex = 10;
            lblUnitCost.Text = "Cost per unit:";
            // 
            // lblUnitCount
            // 
            lblUnitCount.AutoSize = true;
            lblUnitCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnitCount.Location = new Point(31, 196);
            lblUnitCount.Name = "lblUnitCount";
            lblUnitCount.Size = new Size(80, 20);
            lblUnitCount.TabIndex = 9;
            lblUnitCount.Text = "Unit count:";
            // 
            // checkBoxHaveUnitCost
            // 
            checkBoxHaveUnitCost.AutoSize = true;
            checkBoxHaveUnitCost.Enabled = false;
            checkBoxHaveUnitCost.Location = new Point(110, 159);
            checkBoxHaveUnitCost.Margin = new Padding(3, 4, 3, 4);
            checkBoxHaveUnitCost.Name = "checkBoxHaveUnitCost";
            checkBoxHaveUnitCost.Size = new Size(18, 17);
            checkBoxHaveUnitCost.TabIndex = 8;
            checkBoxHaveUnitCost.UseVisualStyleBackColor = true;
            // 
            // txtbStartPayment
            // 
            txtbStartPayment.Location = new Point(281, 155);
            txtbStartPayment.Margin = new Padding(3, 4, 3, 4);
            txtbStartPayment.Name = "txtbStartPayment";
            txtbStartPayment.Size = new Size(114, 27);
            txtbStartPayment.TabIndex = 7;
            // 
            // lblCheckBox
            // 
            lblCheckBox.AutoSize = true;
            lblCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCheckBox.Location = new Point(6, 157);
            lblCheckBox.Name = "lblCheckBox";
            lblCheckBox.Size = new Size(115, 20);
            lblCheckBox.TabIndex = 6;
            lblCheckBox.Text = "Single payment:";
            // 
            // lblStartPayment
            // 
            lblStartPayment.AutoSize = true;
            lblStartPayment.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartPayment.Location = new Point(147, 159);
            lblStartPayment.Name = "lblStartPayment";
            lblStartPayment.Size = new Size(135, 20);
            lblStartPayment.TabIndex = 5;
            lblStartPayment.Text = "Starting fee / Price:";
            // 
            // cboxLawyerOnService
            // 
            cboxLawyerOnService.DataSource = uiLawyerBindingSource;
            cboxLawyerOnService.FormattingEnabled = true;
            cboxLawyerOnService.Location = new Point(162, 100);
            cboxLawyerOnService.Margin = new Padding(3, 4, 3, 4);
            cboxLawyerOnService.Name = "cboxLawyerOnService";
            cboxLawyerOnService.Size = new Size(138, 28);
            cboxLawyerOnService.TabIndex = 4;
            cboxLawyerOnService.SelectedIndexChanged += cboxLawyerOnService_SelectedIndexChanged;
            cboxLawyerOnService.MouseClick += cboxLawyerOnServiceAsync_MouseClick;
            // 
            // uiLawyerBindingSource
            // 
            uiLawyerBindingSource.DataSource = typeof(UIModels.UiLawyer);
            // 
            // lblLawyerOnService
            // 
            lblLawyerOnService.AutoSize = true;
            lblLawyerOnService.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLawyerOnService.Location = new Point(15, 103);
            lblLawyerOnService.Name = "lblLawyerOnService";
            lblLawyerOnService.Size = new Size(147, 23);
            lblLawyerOnService.TabIndex = 3;
            lblLawyerOnService.Text = "Laywer on service:";
            // 
            // lblServicePreformed
            // 
            lblServicePreformed.AutoSize = true;
            lblServicePreformed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblServicePreformed.Location = new Point(10, 58);
            lblServicePreformed.Name = "lblServicePreformed";
            lblServicePreformed.Size = new Size(152, 23);
            lblServicePreformed.TabIndex = 2;
            lblServicePreformed.Text = "Service preformed:";
            // 
            // dtpServicePreformed
            // 
            dtpServicePreformed.Format = DateTimePickerFormat.Short;
            dtpServicePreformed.Location = new Point(165, 56);
            dtpServicePreformed.Margin = new Padding(3, 4, 3, 4);
            dtpServicePreformed.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            dtpServicePreformed.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dtpServicePreformed.Name = "dtpServicePreformed";
            dtpServicePreformed.Size = new Size(135, 27);
            dtpServicePreformed.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 59);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // uiServiceBindingSource
            // 
            uiServiceBindingSource.DataSource = typeof(UIModels.UiService);
            // 
            // paneldgv
            // 
            paneldgv.Controls.Add(dgvServiceCatalog);
            paneldgv.Location = new Point(445, 72);
            paneldgv.Margin = new Padding(3, 4, 3, 4);
            paneldgv.Name = "paneldgv";
            paneldgv.Size = new Size(784, 504);
            paneldgv.TabIndex = 2;
            // 
            // dgvServiceCatalog
            // 
            dgvServiceCatalog.AllowUserToAddRows = false;
            dgvServiceCatalog.AllowUserToDeleteRows = false;
            dgvServiceCatalog.AllowUserToResizeColumns = false;
            dgvServiceCatalog.AllowUserToResizeRows = false;
            dgvServiceCatalog.AutoGenerateColumns = false;
            dgvServiceCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceCatalog.Columns.AddRange(new DataGridViewColumn[] { serviceNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgvServiceCatalog.DataSource = uiServiceBindingSource1;
            dgvServiceCatalog.Dock = DockStyle.Fill;
            dgvServiceCatalog.Location = new Point(0, 0);
            dgvServiceCatalog.Margin = new Padding(3, 4, 3, 4);
            dgvServiceCatalog.MultiSelect = false;
            dgvServiceCatalog.Name = "dgvServiceCatalog";
            dgvServiceCatalog.ReadOnly = true;
            dgvServiceCatalog.RowHeadersVisible = false;
            dgvServiceCatalog.RowHeadersWidth = 51;
            dgvServiceCatalog.RowTemplate.Height = 25;
            dgvServiceCatalog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceCatalog.Size = new Size(784, 504);
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
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uiServiceBindingSource1
            // 
            uiServiceBindingSource1.DataSource = typeof(UIModels.UiService);
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LawyerAddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 600);
            Controls.Add(paneldgv);
            Controls.Add(panelEditService);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LawyerAddService";
            Text = "LawyerAddService";
            panelEditService.ResumeLayout(false);
            panelEditService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource).EndInit();
            paneldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServiceCatalog).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditService;
        private Panel paneldgv;
        private BindingSource uiServiceBindingSource;
        private DataGridView dgvServiceCatalog;
        private BindingSource uiServiceBindingSource1;
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
        private Button btnAddService;
        private Button btnBack;
        private TextBox txtbSelectedService;
        private Label lblSelectedService;
        private BindingSource uiLawyerBindingSource;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ErrorProvider errorProvider1;
    }
}