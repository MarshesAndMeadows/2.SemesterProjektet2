namespace UserInterface.Forms
{
    partial class LawyerOverview
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
            panel2 = new Panel();
            panel3 = new Panel();
            btnOpenCase = new Button();
            btnLogout = new Button();
            btnCreateClient = new Button();
            btnCreateCase = new Button();
            textBox1 = new TextBox();
            dgvOverview = new DataGridView();
            caseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            caseDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            uiCaseBindingSource1 = new BindingSource(components);
            uICaseBindingSource = new BindingSource(components);
            tooltipCreateCase = new ToolTip(components);
            tooltipCreateClient = new ToolTip(components);
            tooltipLogout = new ToolTip(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uICaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dgvOverview);
            panel1.Location = new Point(-7, -28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 675);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 635);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnOpenCase);
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnCreateClient);
            panel3.Controls.Add(btnCreateCase);
            panel3.Location = new Point(15, 50);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 572);
            panel3.TabIndex = 3;
            // 
            // btnOpenCase
            // 
            btnOpenCase.Location = new Point(11, 129);
            btnOpenCase.Margin = new Padding(3, 2, 3, 2);
            btnOpenCase.Name = "btnOpenCase";
            btnOpenCase.Size = new Size(136, 64);
            btnOpenCase.TabIndex = 3;
            btnOpenCase.Text = "Select";
            btnOpenCase.UseVisualStyleBackColor = true;
            btnOpenCase.Click += btnOpenCase_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(11, 510);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(136, 52);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            tooltipLogout.SetToolTip(btnLogout, "Log out and return to the log in page");
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new Point(11, 72);
            btnCreateClient.Margin = new Padding(3, 2, 3, 2);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(136, 52);
            btnCreateClient.TabIndex = 1;
            btnCreateClient.Text = "Create Client";
            tooltipCreateClient.SetToolTip(btnCreateClient, "Click here to create a new Client!");
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // btnCreateCase
            // 
            btnCreateCase.Location = new Point(11, 15);
            btnCreateCase.Margin = new Padding(3, 2, 3, 2);
            btnCreateCase.Name = "btnCreateCase";
            btnCreateCase.Size = new Size(136, 52);
            btnCreateCase.TabIndex = 0;
            btnCreateCase.Text = "Create Case";
            tooltipCreateCase.SetToolTip(btnCreateCase, "Click here to create a new case");
            btnCreateCase.UseVisualStyleBackColor = true;
            btnCreateCase.Click += btnCreateCase_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for a case ...";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 3;
            // 
            // dgvOverview
            // 
            dgvOverview.AllowUserToAddRows = false;
            dgvOverview.AllowUserToDeleteRows = false;
            dgvOverview.AllowUserToResizeColumns = false;
            dgvOverview.AllowUserToResizeRows = false;
            dgvOverview.AutoGenerateColumns = false;
            dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverview.Columns.AddRange(new DataGridViewColumn[] { caseNameDataGridViewTextBoxColumn, caseDescriptionDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvOverview.DataSource = uiCaseBindingSource1;
            dgvOverview.Location = new Point(198, 103);
            dgvOverview.Margin = new Padding(3, 2, 3, 2);
            dgvOverview.MultiSelect = false;
            dgvOverview.Name = "dgvOverview";
            dgvOverview.ReadOnly = true;
            dgvOverview.RowHeadersWidth = 51;
            dgvOverview.RowTemplate.Height = 29;
            dgvOverview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOverview.Size = new Size(1183, 557);
            dgvOverview.TabIndex = 2;
            dgvOverview.CellContentDoubleClick += dgvOverview_CellContentDoubleClick;
            // 
            // caseNameDataGridViewTextBoxColumn
            // 
            caseNameDataGridViewTextBoxColumn.DataPropertyName = "CaseName";
            caseNameDataGridViewTextBoxColumn.HeaderText = "CaseName";
            caseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseNameDataGridViewTextBoxColumn.Name = "caseNameDataGridViewTextBoxColumn";
            caseNameDataGridViewTextBoxColumn.ReadOnly = true;
            caseNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // caseDescriptionDataGridViewTextBoxColumn
            // 
            caseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.HeaderText = "CaseDescription";
            caseDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            caseDescriptionDataGridViewTextBoxColumn.Name = "caseDescriptionDataGridViewTextBoxColumn";
            caseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            caseDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "EstimatedEndDate";
            dataGridViewTextBoxColumn1.HeaderText = "EstimatedEndDate";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "StartDate";
            dataGridViewTextBoxColumn2.HeaderText = "StartDate";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "CaseClosed";
            dataGridViewCheckBoxColumn1.HeaderText = "CaseClosed";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Employee";
            dataGridViewTextBoxColumn3.HeaderText = "Employee";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Client";
            dataGridViewTextBoxColumn4.HeaderText = "Client";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // uiCaseBindingSource1
            // 
            uiCaseBindingSource1.DataSource = typeof(UIModels.UiCase);
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helpIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1339, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LawyerOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 640);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LawyerOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerOverview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiCaseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uICaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCreateCase;
        private TextBox textBox1;
        private DataGridView dgvOverview;
        private Button btnCreateClient;
        private Panel panel2;
        private Button btnLogout;
        private Panel panel3;
        private ToolTip tooltipCreateCase;
        private ToolTip tooltipCreateClient;
        private ToolTip tooltipLogout;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimatedEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn caseClosedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private BindingSource uICaseBindingSource;
        private Button btnOpenCase;
        private BindingSource uiCaseBindingSource1;
        private DataGridViewTextBoxColumn caseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn caseDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PictureBox pictureBox1;
    }
}