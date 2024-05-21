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
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            btnViewCases = new Button();
            btnProfilePage = new Button();
            btnBack = new Button();
            btnToolspage = new Button();
            btnViewFormulas = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 263);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(btnViewCases);
            panel2.Controls.Add(btnProfilePage);
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnToolspage);
            panel2.Controls.Add(btnViewFormulas);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 240);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(278, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 41);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Welcome!";
            // 
            // btnViewCases
            // 
            btnViewCases.Location = new Point(8, 129);
            btnViewCases.Name = "btnViewCases";
            btnViewCases.Size = new Size(155, 69);
            btnViewCases.TabIndex = 5;
            btnViewCases.Text = "View cases";
            btnViewCases.UseVisualStyleBackColor = true;
            btnViewCases.Click += btnViewCases_Click;
            // 
            // btnProfilePage
            // 
            btnProfilePage.Location = new Point(166, 129);
            btnProfilePage.Name = "btnProfilePage";
            btnProfilePage.Size = new Size(155, 69);
            btnProfilePage.TabIndex = 4;
            btnProfilePage.Text = "Go to profile";
            btnProfilePage.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(117, 204);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Log out";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnToolspage
            // 
            btnToolspage.Location = new Point(8, 54);
            btnToolspage.Name = "btnToolspage";
            btnToolspage.Size = new Size(155, 69);
            btnToolspage.TabIndex = 3;
            btnToolspage.Text = "Go to tools page";
            btnToolspage.UseVisualStyleBackColor = true;
            btnToolspage.Click += btnToolspage_Click;
            // 
            // btnViewFormulas
            // 
            btnViewFormulas.Location = new Point(166, 54);
            btnViewFormulas.Name = "btnViewFormulas";
            btnViewFormulas.Size = new Size(155, 69);
            btnViewFormulas.TabIndex = 2;
            btnViewFormulas.Text = "View formulas";
            btnViewFormulas.UseVisualStyleBackColor = true;
            // 
            // ClientOverviewPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 263);
            Controls.Add(panel1);
            Name = "ClientOverviewPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientOverviewPage";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}