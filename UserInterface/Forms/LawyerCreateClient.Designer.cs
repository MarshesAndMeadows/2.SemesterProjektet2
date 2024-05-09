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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblClientInfo = new Label();
            panel2 = new Panel();
            checkBoxNo = new CheckBox();
            checkBoxYes = new CheckBox();
            lblSubscrubed = new Label();
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
            btnCreateClient = new Button();
            btnBack = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblClientInfo);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(18, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 400);
            panel1.TabIndex = 0;
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientInfo.Location = new Point(3, 2);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(238, 37);
            lblClientInfo.TabIndex = 0;
            lblClientInfo.Text = "Client information:";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBoxNo);
            panel2.Controls.Add(checkBoxYes);
            panel2.Controls.Add(lblSubscrubed);
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
            panel2.Location = new Point(3, 61);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 339);
            panel2.TabIndex = 1;
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(157, 305);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(42, 19);
            checkBoxNo.TabIndex = 12;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxYes
            // 
            checkBoxYes.AutoSize = true;
            checkBoxYes.Location = new Point(99, 305);
            checkBoxYes.Name = "checkBoxYes";
            checkBoxYes.Size = new Size(43, 19);
            checkBoxYes.TabIndex = 11;
            checkBoxYes.Text = "Yes";
            checkBoxYes.UseVisualStyleBackColor = true;
            // 
            // lblSubscrubed
            // 
            lblSubscrubed.AutoSize = true;
            lblSubscrubed.Location = new Point(8, 309);
            lblSubscrubed.Name = "lblSubscrubed";
            lblSubscrubed.Size = new Size(68, 15);
            lblSubscrubed.TabIndex = 9;
            lblSubscrubed.Text = "Subscribed:";
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(99, 138);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(200, 23);
            birthdayPicker.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(99, 261);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(99, 220);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtSex
            // 
            txtSex.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSex.Location = new Point(99, 97);
            txtSex.Name = "txtSex";
            txtSex.PlaceholderText = " [M]ale or [F]emale";
            txtSex.Size = new Size(111, 23);
            txtSex.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(99, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(99, 15);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 268);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 227);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 5;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 186);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 4;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 145);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Birthday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 104);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 2;
            label4.Text = "Sex:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 63);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 1;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 22);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "First name:";
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new Point(21, 475);
            btnCreateClient.Margin = new Padding(3, 2, 3, 2);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(105, 52);
            btnCreateClient.TabIndex = 7;
            btnCreateClient.Text = "Create client";
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Visible = false;
            btnCreateClient.Click += btnCreateClient_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 603);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LawyerCreateClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 644);
            Controls.Add(btnCreateClient);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "LawyerCreateClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LawyerCreateClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblClientInfo;
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
        private DateTimePicker birthdayPicker;
        private Button btnCreateClient;
        private Label lblSubscrubed;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxYes;
        private ErrorProvider errorProvider1;
    }
}