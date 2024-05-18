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
            pictureBox = new PictureBox();
            btnResetDatabase = new Button();
            comboBox2 = new ComboBox();
            btnLogin = new Button();
            comboBox1 = new ComboBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(btnResetDatabase);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-7, -28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.ErrorImage = null;
            pictureBox.Image = Properties.Resources.helperIcon;
            pictureBox.InitialImage = null;
            pictureBox.Location = new Point(639, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(40, 40);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 9;
            pictureBox.TabStop = false;
            pictureBox.Tag = "";
            pictureBox.Click += HelpIconClick;
            // 
            // btnResetDatabase
            // 
            btnResetDatabase.Location = new Point(576, 268);
            btnResetDatabase.Margin = new Padding(3, 2, 3, 2);
            btnResetDatabase.Name = "btnResetDatabase";
            btnResetDatabase.Size = new Size(105, 52);
            btnResetDatabase.TabIndex = 4;
            btnResetDatabase.Text = "Reset database";
            btnResetDatabase.UseVisualStyleBackColor = true;
            btnResetDatabase.Click += btnResetDatabase_ClickAsync;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Frederik (bærbar)", "Frederik (stationær)", "Kasper", "Michael (bærbar)", "Michael (stationær)", "Matias (bærbar)", "Matias (stationær)" });
            comboBox2.Location = new Point(546, 104);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 3;
            comboBox2.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(248, 126);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 72);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lawyer", "Customer" });
            comboBox1.Location = new Point(163, 62);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 23);
            comboBox1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(18, 268);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 52);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 302);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnResetDatabase;
        private PictureBox pictureBox;
    }
}