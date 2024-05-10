namespace UserInterface.Forms
{
    partial class PickALawyer
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
            dgvLawyers = new DataGridView();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiLawyerBindingSource = new BindingSource(components);
            dgvSpecialEducation = new DataGridView();
            educationNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uiEducationBindingSource = new BindingSource(components);
            lblCaseTitle = new Label();
            btnBack = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialEducation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiEducationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvLawyers
            // 
            dgvLawyers.AllowUserToAddRows = false;
            dgvLawyers.AllowUserToDeleteRows = false;
            dgvLawyers.AllowUserToResizeColumns = false;
            dgvLawyers.AllowUserToResizeRows = false;
            dgvLawyers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvLawyers.AutoGenerateColumns = false;
            dgvLawyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLawyers.Columns.AddRange(new DataGridViewColumn[] { firstnameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn });
            dgvLawyers.DataSource = uiLawyerBindingSource;
            dgvLawyers.Location = new Point(12, 33);
            dgvLawyers.MultiSelect = false;
            dgvLawyers.Name = "dgvLawyers";
            dgvLawyers.ReadOnly = true;
            dgvLawyers.RowHeadersVisible = false;
            dgvLawyers.RowTemplate.Height = 25;
            dgvLawyers.Size = new Size(242, 275);
            dgvLawyers.TabIndex = 0;
            dgvLawyers.SelectionChanged += dgvLawyers_SelectionChanged;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            firstnameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            lastnameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // uiLawyerBindingSource
            // 
            uiLawyerBindingSource.DataSource = typeof(UIModels.UiLawyer);
            // 
            // dgvSpecialEducation
            // 
            dgvSpecialEducation.AllowUserToAddRows = false;
            dgvSpecialEducation.AllowUserToDeleteRows = false;
            dgvSpecialEducation.AllowUserToResizeColumns = false;
            dgvSpecialEducation.AllowUserToResizeRows = false;
            dgvSpecialEducation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSpecialEducation.AutoGenerateColumns = false;
            dgvSpecialEducation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSpecialEducation.Columns.AddRange(new DataGridViewColumn[] { educationNameDataGridViewTextBoxColumn });
            dgvSpecialEducation.DataSource = uiEducationBindingSource;
            dgvSpecialEducation.Location = new Point(264, 33);
            dgvSpecialEducation.MultiSelect = false;
            dgvSpecialEducation.Name = "dgvSpecialEducation";
            dgvSpecialEducation.ReadOnly = true;
            dgvSpecialEducation.RowHeadersVisible = false;
            dgvSpecialEducation.RowTemplate.Height = 25;
            dgvSpecialEducation.Size = new Size(156, 275);
            dgvSpecialEducation.TabIndex = 1;
            // 
            // educationNameDataGridViewTextBoxColumn
            // 
            educationNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            educationNameDataGridViewTextBoxColumn.DataPropertyName = "EducationName";
            educationNameDataGridViewTextBoxColumn.HeaderText = "Specialization";
            educationNameDataGridViewTextBoxColumn.Name = "educationNameDataGridViewTextBoxColumn";
            educationNameDataGridViewTextBoxColumn.ReadOnly = true;
            educationNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // uiEducationBindingSource
            // 
            uiEducationBindingSource.DataSource = typeof(UIModels.UiEducation);
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseTitle.Location = new Point(12, 9);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(70, 21);
            lblCaseTitle.TabIndex = 2;
            lblCaseTitle.Text = "Lawyers:";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(12, 326);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSelect.Location = new Point(338, 326);
            btnSelect.Margin = new Padding(3, 2, 3, 2);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(82, 22);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // PickALawyer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 356);
            Controls.Add(btnSelect);
            Controls.Add(btnBack);
            Controls.Add(lblCaseTitle);
            Controls.Add(dgvSpecialEducation);
            Controls.Add(dgvLawyers);
            MinimumSize = new Size(449, 395);
            Name = "PickALawyer";
            Text = "PickALawyer";
            ((System.ComponentModel.ISupportInitialize)dgvLawyers).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiLawyerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSpecialEducation).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiEducationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLawyers;
        private BindingSource uiLawyerBindingSource;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridView dgvSpecialEducation;
        private Label lblCaseTitle;
        private DataGridViewTextBoxColumn educationNameDataGridViewTextBoxColumn;
        private BindingSource uiEducationBindingSource;
        private Button btnBack;
        private Button btnSelect;
    }
}