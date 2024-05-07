namespace UserInterface.Forms
{
    partial class LawyerCreateClient
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
            lblClientInfo = new Label();
            panel2 = new Panel();
            btnContinue = new Button();
            lblChoosenLawyer = new Label();
            lblLawyerChosen = new Label();
            birthdayPicker = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtSex = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            tblLayoutPanel = new TableLayoutPanel();
            dgvGetAllLawyers = new DataGridView();
            dgvGetSpecificLawyerEducation = new DataGridView();
            btnBack = new Button();
            btnCreateClient = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tblLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGetAllLawyers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGetSpecificLawyerEducation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblClientInfo);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(18, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 300);
            panel1.TabIndex = 0;
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientInfo.Location = new Point(3, 9);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(238, 37);
            lblClientInfo.TabIndex = 0;
            lblClientInfo.Text = "Client information:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnContinue);
            panel2.Controls.Add(lblChoosenLawyer);
            panel2.Controls.Add(lblLawyerChosen);
            panel2.Controls.Add(birthdayPicker);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtSex);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 46);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 252);
            panel2.TabIndex = 1;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.GreenYellow;
            btnContinue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinue.Location = new Point(329, 192);
            btnContinue.Margin = new Padding(3, 2, 3, 2);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(105, 52);
            btnContinue.TabIndex = 8;
            btnContinue.Text = "Choose Lawyer";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Visible = false;
            // 
            // lblChoosenLawyer
            // 
            lblChoosenLawyer.AutoSize = true;
            lblChoosenLawyer.Location = new Point(329, 39);
            lblChoosenLawyer.Name = "lblChoosenLawyer";
            lblChoosenLawyer.Size = new Size(175, 15);
            lblChoosenLawyer.TabIndex = 9;
            lblChoosenLawyer.Text = "Her vises advokat man har valgt";
            // 
            // lblLawyerChosen
            // 
            lblLawyerChosen.AutoSize = true;
            lblLawyerChosen.Location = new Point(329, 7);
            lblLawyerChosen.Name = "lblLawyerChosen";
            lblLawyerChosen.Size = new Size(244, 15);
            lblLawyerChosen.TabIndex = 8;
            lblLawyerChosen.Text = "Tekst der indikere  at man skal vælge advokat";
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(74, 112);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(200, 23);
            birthdayPicker.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(73, 221);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(73, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSex
            // 
            txtSex.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSex.Location = new Point(73, 74);
            txtSex.Name = "txtSex";
            txtSex.PlaceholderText = " [M]ale or [F]emale";
            txtSex.Size = new Size(111, 23);
            txtSex.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(73, 39);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(73, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 229);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 192);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 5;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 155);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 118);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 81);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 2;
            label4.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 1;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "First name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(680, 62);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 300);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 2;
            label1.Text = "Choose lawyer:";
            // 
            // panel4
            // 
            panel4.Controls.Add(tblLayoutPanel);
            panel4.Location = new Point(3, 46);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(651, 252);
            panel4.TabIndex = 1;
            // 
            // tblLayoutPanel
            // 
            tblLayoutPanel.ColumnCount = 2;
            tblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayoutPanel.Controls.Add(dgvGetAllLawyers, 0, 0);
            tblLayoutPanel.Controls.Add(dgvGetSpecificLawyerEducation, 1, 0);
            tblLayoutPanel.Dock = DockStyle.Fill;
            tblLayoutPanel.Location = new Point(0, 0);
            tblLayoutPanel.Name = "tblLayoutPanel";
            tblLayoutPanel.RowCount = 1;
            tblLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayoutPanel.Size = new Size(651, 252);
            tblLayoutPanel.TabIndex = 0;
            // 
            // dgvGetAllLawyers
            // 
            dgvGetAllLawyers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGetAllLawyers.Dock = DockStyle.Fill;
            dgvGetAllLawyers.Location = new Point(3, 3);
            dgvGetAllLawyers.Name = "dgvGetAllLawyers";
            dgvGetAllLawyers.RowTemplate.Height = 25;
            dgvGetAllLawyers.Size = new Size(319, 246);
            dgvGetAllLawyers.TabIndex = 0;
            // 
            // dgvGetSpecificLawyerEducation
            // 
            dgvGetSpecificLawyerEducation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGetSpecificLawyerEducation.Dock = DockStyle.Fill;
            dgvGetSpecificLawyerEducation.Location = new Point(328, 3);
            dgvGetSpecificLawyerEducation.Name = "dgvGetSpecificLawyerEducation";
            dgvGetSpecificLawyerEducation.RowTemplate.Height = 25;
            dgvGetSpecificLawyerEducation.Size = new Size(320, 246);
            dgvGetSpecificLawyerEducation.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(18, 638);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new Point(18, 376);
            btnCreateClient.Margin = new Padding(3, 2, 3, 2);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(105, 52);
            btnCreateClient.TabIndex = 7;
            btnCreateClient.Text = "Create client";
            btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // LawyerCreateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 666);
            Controls.Add(btnCreateClient);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LawyerCreateClient";
            Text = "LawyerCreateClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            tblLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGetAllLawyers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGetSpecificLawyerEducation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblClientInfo;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private TextBox txtFirstName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtSex;
        private TextBox txtLastName;
        private TableLayoutPanel tblLayoutPanel;
        private DataGridView dgvGetAllLawyers;
        private DataGridView dgvGetSpecificLawyerEducation;
        private DateTimePicker birthdayPicker;
        private Label lblChoosenLawyer;
        private Label lblLawyerChosen;
        private Button btnCreateClient;
        private Button btnContinue;
    }
}