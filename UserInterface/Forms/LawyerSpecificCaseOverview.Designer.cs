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
            panel1 = new Panel();
            btnHelp = new Button();
            panel2 = new Panel();
            btnEditClient = new Button();
            panel3 = new Panel();
            btnAddService = new Button();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            lblCaseTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnHelp);
            panel1.Location = new Point(-10, -39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 900);
            panel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelp.Location = new Point(1530, 51);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 50);
            btnHelp.TabIndex = 0;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(839, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 773);
            panel2.TabIndex = 1;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(580, 661);
            btnEditClient.MaximumSize = new Size(120, 70);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(120, 70);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit client info";
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(btnAddService);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(btnEditClient);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(21, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 734);
            panel3.TabIndex = 0;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(92, 538);
            btnAddService.MaximumSize = new Size(120, 70);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(120, 70);
            btnAddService.TabIndex = 1;
            btnAddService.Text = "Add service";
            btnAddService.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCaseTitle);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(22, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(811, 829);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(805, 302);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonFace;
            panel6.Location = new Point(20, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(766, 258);
            panel6.TabIndex = 0;
            // 
            // lblCaseTitle
            // 
            lblCaseTitle.AutoSize = true;
            lblCaseTitle.Location = new Point(23, 20);
            lblCaseTitle.Name = "lblCaseTitle";
            lblCaseTitle.Size = new Size(41, 20);
            lblCaseTitle.TabIndex = 1;
            lblCaseTitle.Text = "Title:";
            // 
            // LawyerSpecificCaseOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerSpecificCaseOverview";
            Text = "LawyerSpecificCaseOverview";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHelp;
        private Panel panel2;
        private Panel panel3;
        private Button btnEditClient;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnAddService;
        private DataGridView dataGridView1;
        private Label lblCaseTitle;
    }
}