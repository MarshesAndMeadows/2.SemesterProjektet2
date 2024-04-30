namespace UserInterface.Forms
{
    partial class LawyerSpecificCaseOverciew
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
            panel1 = new Panel();
            btnHelpButton = new Button();
            panel2 = new Panel();
            btnEditCustomer = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            btnAddService = new Button();
            btnEditCase = new Button();
            btnBack = new Button();
            btnPrintInvoice = new Button();
            panel5 = new Panel();
            lblCaseTitle = new Label();
            panel6 = new Panel();
            lblCaseDescription = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-9, -40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 900);
            panel1.TabIndex = 0;
            // 
            // btnHelpButton
            // 
            btnHelpButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelpButton.Location = new Point(785, 3);
            btnHelpButton.Name = "btnHelpButton";
            btnHelpButton.Size = new Size(50, 50);
            btnHelpButton.TabIndex = 0;
            btnHelpButton.Text = "?";
            btnHelpButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEditCustomer);
            panel2.Controls.Add(btnHelpButton);
            panel2.Location = new Point(741, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 682);
            panel2.TabIndex = 1;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditCustomer.Location = new Point(377, 609);
            btnEditCustomer.MaximumSize = new Size(120, 70);
            btnEditCustomer.MinimumSize = new Size(120, 70);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(120, 70);
            btnEditCustomer.TabIndex = 0;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 387);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(714, 347);
            dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(21, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 349);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnPrintInvoice);
            panel4.Controls.Add(btnBack);
            panel4.Controls.Add(btnEditCase);
            panel4.Controls.Add(btnAddService);
            panel4.Location = new Point(21, 740);
            panel4.Name = "panel4";
            panel4.Size = new Size(1558, 157);
            panel4.TabIndex = 4;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(3, 4);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(120, 70);
            btnAddService.TabIndex = 0;
            btnAddService.Text = "Add a service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // btnEditCase
            // 
            btnEditCase.Location = new Point(129, 4);
            btnEditCase.Name = "btnEditCase";
            btnEditCase.Size = new Size(120, 70);
            btnEditCase.TabIndex = 1;
            btnEditCase.Text = "Edit Case";
            btnEditCase.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 119);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "button3";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.Location = new Point(255, 4);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(120, 70);
            btnPrintInvoice.TabIndex = 3;
            btnPrintInvoice.Text = "Print Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(708, 343);
            panel5.TabIndex = 0;
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Location = new Point(12, 11);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(41, 20);
            lblCaseTitle.TabIndex = 0;
            lblCaseTitle.Text = "Title:";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblCaseDescription);
            panel6.Controls.Add(lblCaseTitle);
            panel6.Location = new Point(20, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(665, 307);
            panel6.TabIndex = 1;
            // 
            // lblCaseDescription
            // 
            lblCaseDescription.AutoSize = true;
            lblCaseDescription.Location = new Point(12, 44);
            lblCaseDescription.Name = "lblCaseDescription";
            lblCaseDescription.Size = new Size(88, 20);
            lblCaseDescription.TabIndex = 1;
            lblCaseDescription.Text = "Description:";
            // 
            // LawyerSpecificCaseOverciew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerSpecificCaseOverciew";
            Text = "LawyerReviewCase";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHelpButton;
        private Panel panel2;
        private Button btnEditCustomer;
        private Panel panel4;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button btnEditCase;
        private Button btnAddService;
        private Button btnBack;
        private Button btnPrintInvoice;
        private Panel panel5;
        private Label lblCaseTitle;
        private Panel panel6;
        private Label lblCaseDescription;
    }
}