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
            lblCaseName = new Label();
            lblCaseTitle = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            pnlCaseDescription = new Panel();
            lblCaseDescription = new Label();
            txtBLawyerOnCase = new TextBox();
            lblDescriptionCase = new Label();
            checkboxCasedClosed = new CheckBox();
            lblEmployeeOnCaseLeft = new Label();
            lblIsFinishedLeft = new Label();
            lblStartDateLeft = new Label();
            lblEstimatedEndDateLeft = new Label();
            btnBack = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            pnlCaseDescription.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(lblCaseName);
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 360);
            panel4.TabIndex = 3;
            // 
            // lblCaseName
            // 
            lblCaseName.AutoSize = true;
            lblCaseName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaseName.Location = new Point(122, 5);
            lblCaseName.Name = "lblCaseName";
            lblCaseName.Size = new Size(174, 46);
            lblCaseName.TabIndex = 2;
            lblCaseName.Text = "caseName";
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
            panel6.Controls.Add(dateTimePicker2);
            panel6.Controls.Add(dateTimePicker1);
            panel6.Controls.Add(pnlCaseDescription);
            panel6.Controls.Add(txtBLawyerOnCase);
            panel6.Controls.Add(lblDescriptionCase);
            panel6.Controls.Add(checkboxCasedClosed);
            panel6.Controls.Add(lblEmployeeOnCaseLeft);
            panel6.Controls.Add(lblIsFinishedLeft);
            panel6.Controls.Add(lblStartDateLeft);
            panel6.Controls.Add(lblEstimatedEndDateLeft);
            panel6.Location = new Point(19, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(730, 263);
            panel6.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(477, 58);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(477, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // pnlCaseDescription
            // 
            pnlCaseDescription.AutoSize = true;
            pnlCaseDescription.BorderStyle = BorderStyle.FixedSingle;
            pnlCaseDescription.Controls.Add(lblCaseDescription);
            pnlCaseDescription.Location = new Point(3, 142);
            pnlCaseDescription.Name = "pnlCaseDescription";
            pnlCaseDescription.Size = new Size(724, 118);
            pnlCaseDescription.TabIndex = 23;
            // 
            // lblCaseDescription
            // 
            lblCaseDescription.AutoSize = true;
            lblCaseDescription.Location = new Point(3, 0);
            lblCaseDescription.MaximumSize = new Size(585, 110);
            lblCaseDescription.Name = "lblCaseDescription";
            lblCaseDescription.Size = new Size(50, 20);
            lblCaseDescription.TabIndex = 0;
            lblCaseDescription.Text = "label1";
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
            // lblDescriptionCase
            // 
            lblDescriptionCase.AutoSize = true;
            lblDescriptionCase.Location = new Point(10, 119);
            lblDescriptionCase.Name = "lblDescriptionCase";
            lblDescriptionCase.Size = new Size(128, 20);
            lblDescriptionCase.TabIndex = 12;
            lblDescriptionCase.Text = "Note from lawyer:";
            // 
            // checkboxCasedClosed
            // 
            checkboxCasedClosed.AutoSize = true;
            checkboxCasedClosed.Enabled = false;
            checkboxCasedClosed.Location = new Point(110, 91);
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
            // lblStartDateLeft
            // 
            lblStartDateLeft.AutoSize = true;
            lblStartDateLeft.Location = new Point(394, 16);
            lblStartDateLeft.Name = "lblStartDateLeft";
            lblStartDateLeft.Size = new Size(77, 20);
            lblStartDateLeft.TabIndex = 2;
            lblStartDateLeft.Text = "Start date:";
            // 
            // lblEstimatedEndDateLeft
            // 
            lblEstimatedEndDateLeft.AutoSize = true;
            lblEstimatedEndDateLeft.Location = new Point(330, 63);
            lblEstimatedEndDateLeft.Name = "lblEstimatedEndDateLeft";
            lblEstimatedEndDateLeft.Size = new Size(141, 20);
            lblEstimatedEndDateLeft.TabIndex = 1;
            lblEstimatedEndDateLeft.Text = "Estimated end date:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 647);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerSpecificCases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 688);
            Controls.Add(btnBack);
            Controls.Add(panel4);
            Name = "CustomerSpecificCases";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerSpecificCases";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnlCaseDescription.ResumeLayout(false);
            pnlCaseDescription.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label lblCaseTitle;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtBLawyerOnCase;
        private Label lblDescriptionCase;
        private CheckBox checkboxCasedClosed;
        private Label lblEmployeeOnCaseLeft;
        private Label lblIsFinishedLeft;
        private Label lblStartDateLeft;
        private Label lblEstimatedEndDateLeft;
        private Button btnBack;
        private Label lblCaseName;
        private Panel pnlCaseDescription;
        private Label lblCaseDescription;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}