namespace UserInterface
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            btnLogin = new Button();
            comboBox1 = new ComboBox();
            btnExit = new Button();
            btnResetDatabase = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnResetDatabase);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-8, -37);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Frederik (bærbar)", "Frederik (stationær)", "Kasper", "Michael (bærbar)", "Michael (stationær)", "Matias (bærbar)", "Matias (stationær)" });
            comboBox2.Location = new Point(627, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(283, 168);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(179, 96);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lawyer", "Customer" });
            comboBox1.Location = new Point(186, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(376, 28);
            comboBox1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(20, 358);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 70);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnResetDatabase
            // 
            btnResetDatabase.Location = new Point(658, 358);
            btnResetDatabase.Name = "btnResetDatabase";
            btnResetDatabase.Size = new Size(120, 70);
            btnResetDatabase.TabIndex = 4;
            btnResetDatabase.Text = "Reset database";
            btnResetDatabase.UseVisualStyleBackColor = true;
            btnResetDatabase.Click += btnResetDatabase_ClickAsync;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnResetDatabase;
    }
}