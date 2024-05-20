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
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 360);
            panel4.TabIndex = 3;
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
            // CustomerSpecificCases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 688);
            Controls.Add(panel4);
            Name = "CustomerSpecificCases";
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