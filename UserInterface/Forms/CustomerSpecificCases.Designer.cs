namespace UserInterface.Forms
{
    partial class CustomerSpecificCases
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
            panel4 = new Panel();
            txtBCaseName = new TextBox();
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
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
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(txtBCaseName);
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(10, 9);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(673, 270);
            panel4.TabIndex = 3;
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
            btnSaveCase.Enabled = false;
            btnSaveCase.Location = new Point(526, 81);
            btnSaveCase.Margin = new Padding(3, 2, 3, 2);
            btnSaveCase.MaximumSize = new Size(105, 52);
            btnSaveCase.Name = "btnSaveCase";
            btnSaveCase.Size = new Size(105, 52);
            btnSaveCase.TabIndex = 19;
            btnSaveCase.Text = "Save";
            btnSaveCase.UseVisualStyleBackColor = true;
            btnSaveCase.Visible = false;
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
            // CustomerSpecificCases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 516);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerSpecificCases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerSpecificCases";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private TextBox txtBCaseName;
        private Label lblCaseTitle;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtBCaseEndDate;
        private TextBox txtBCaseStartDate;
        private TextBox txtBLawyerOnCase;
        private Button btnSaveCase;
        private TextBox txtBCaseDescription;
        private Label lblDescriptionCase;
        private CheckBox checkboxCasedClosed;
        private Label lblEmployeeOnCaseLeft;
        private Label lblIsFinishedLeft;
        private Button btnEditCase;
        private Label lblStartDateLeft;
        private Label lblEstimatedEndDateLeft;
    }
}