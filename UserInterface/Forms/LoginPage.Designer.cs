﻿namespace UserInterface
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
            tableLayoutPanel2 = new TableLayoutPanel();
            comboboxSelectClient = new ComboBox();
            comboBox1 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLogin = new Button();
            btnExit = new Button();
            btnResetDatabase = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            uiClientBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiClientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-7, -28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 338);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(comboboxSelectClient, 0, 1);
            tableLayoutPanel2.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(18, 136);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Size = new Size(663, 65);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // comboboxSelectClient
            // 
            comboboxSelectClient.Anchor = AnchorStyles.Bottom;
            comboboxSelectClient.FormattingEnabled = true;
            comboboxSelectClient.Location = new Point(166, 40);
            comboboxSelectClient.Margin = new Padding(3, 2, 3, 2);
            comboboxSelectClient.Name = "comboboxSelectClient";
            comboboxSelectClient.Size = new Size(330, 23);
            comboboxSelectClient.TabIndex = 5;
            comboboxSelectClient.Text = "Select which client to log in as ...";
            comboboxSelectClient.Visible = false;
            comboboxSelectClient.SelectionChangeCommitted += comboboxSelectClient_SelectionChangeCommitted;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Lawyer", "Client" });
            comboBox1.Location = new Point(166, 2);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(330, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select user type ...";
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnExit, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLogin, 1, 0);
            tableLayoutPanel1.Controls.Add(btnResetDatabase, 2, 0);
            tableLayoutPanel1.Location = new Point(18, 227);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(663, 94);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.Location = new Point(253, 20);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.MaximumSize = new Size(157, 72);
            btnLogin.MinimumSize = new Size(157, 72);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 72);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Location = new Point(3, 40);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.MaximumSize = new Size(105, 52);
            btnExit.MinimumSize = new Size(105, 52);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 52);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnResetDatabase
            // 
            btnResetDatabase.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnResetDatabase.Location = new Point(555, 40);
            btnResetDatabase.Margin = new Padding(3, 2, 3, 2);
            btnResetDatabase.MaximumSize = new Size(105, 52);
            btnResetDatabase.MinimumSize = new Size(105, 52);
            btnResetDatabase.Name = "btnResetDatabase";
            btnResetDatabase.Size = new Size(105, 52);
            btnResetDatabase.TabIndex = 4;
            btnResetDatabase.Text = "Reset database";
            btnResetDatabase.UseVisualStyleBackColor = true;
            btnResetDatabase.Click += btnResetDatabase_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(239, 118);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 8;
            label1.Text = "Welcome to LawHouse. Please log in";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helperIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(640, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += HelpIconClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_black;
            pictureBox2.Location = new Point(0, -235);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 610);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            Text = "LawHouse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}