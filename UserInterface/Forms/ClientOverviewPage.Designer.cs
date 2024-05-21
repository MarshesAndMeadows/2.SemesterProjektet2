namespace UserInterface.Forms
{
    partial class ClientOverviewPage
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
            panel2 = new Panel();
            panel3 = new Panel();
            btnViewFormulas = new Button();
            btnBack = new Button();
            btnToolspage = new Button();
            btnViewCases = new Button();
            btnProfilePage = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1583, 854);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1558, 829);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnViewFormulas);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(btnToolspage);
            panel3.Controls.Add(btnViewCases);
            panel3.Controls.Add(btnProfilePage);
            panel3.Location = new Point(13, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 750);
            panel3.TabIndex = 7;
            // 
            // btnViewFormulas
            // 
            btnViewFormulas.Location = new Point(26, 97);
            btnViewFormulas.Name = "btnViewFormulas";
            btnViewFormulas.Size = new Size(155, 69);
            btnViewFormulas.TabIndex = 2;
            btnViewFormulas.Text = "View formulas";
            btnViewFormulas.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 718);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Log out";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnToolspage
            // 
            btnToolspage.Location = new Point(26, 22);
            btnToolspage.Name = "btnToolspage";
            btnToolspage.Size = new Size(155, 69);
            btnToolspage.TabIndex = 3;
            btnToolspage.Text = "Go to tools page";
            btnToolspage.UseVisualStyleBackColor = true;
            btnToolspage.Click += btnToolspage_Click;
            // 
            // btnViewCases
            // 
            btnViewCases.Location = new Point(26, 247);
            btnViewCases.Name = "btnViewCases";
            btnViewCases.Size = new Size(155, 69);
            btnViewCases.TabIndex = 5;
            btnViewCases.Text = "View cases";
            btnViewCases.UseVisualStyleBackColor = true;
            btnViewCases.Click += btnViewCases_Click;
            // 
            // btnProfilePage
            // 
            btnProfilePage.Location = new Point(26, 172);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.Size = new Size(155, 69);
            btnProfilePage.TabIndex = 4;
            btnProfilePage.Text = "Go to profile";
            btnProfilePage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.helperIcon;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(1515, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(16, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome!";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logo_no_background;
            pictureBox2.Location = new Point(335, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(941, 184);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // ClientOverviewPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "ClientOverviewPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientOverviewPage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Panel panel2;
        private Button btnViewFormulas;
        private Button btnProfilePage;
        private Button btnToolspage;
        private Label lblTitle;
        private Button btnViewCases;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}