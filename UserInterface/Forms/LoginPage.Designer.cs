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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            comboboxSelectClient = new ComboBox();
            btnResetDatabase = new Button();
            btnLogin = new Button();
            comboBox1 = new ComboBox();
            btnExit = new Button();
            uiClientBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboboxSelectClient);
            panel1.Controls.Add(btnResetDatabase);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(-7, -28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helperIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(641, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += HelpIconClicked;
            // 
            // comboboxSelectClient
            // 
            comboboxSelectClient.FormattingEnabled = true;
            comboboxSelectClient.Location = new Point(163, 111);
            comboboxSelectClient.Margin = new Padding(3, 2, 3, 2);
            comboboxSelectClient.Name = "comboboxSelectClient";
            comboboxSelectClient.Size = new Size(330, 23);
            comboboxSelectClient.TabIndex = 5;
            comboboxSelectClient.Visible = false;
            comboboxSelectClient.SelectionChangeCommitted += comboboxSelectClient_SelectionChangeCommitted;
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
            // btnLogin
            // 
            btnLogin.Location = new Point(247, 190);
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
            comboBox1.Items.AddRange(new object[] { "Lawyer", "Client" });
            comboBox1.Location = new Point(163, 62);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
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
            // uiClientBindingSource
            // 
            uiClientBindingSource.DataSource = typeof(UIModels.UiClient);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Button btnLogin;
        private ComboBox comboBox1;
        private Button btnResetDatabase;
        private ComboBox comboboxSelectClient;
        private BindingSource uiClientBindingSource;
        private PictureBox pictureBox1;
    }
}