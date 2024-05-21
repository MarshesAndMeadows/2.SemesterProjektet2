namespace UserInterface.Forms
{
    partial class ClientToolsPage
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
            btnRenteBeregner = new Button();
            btnBack = new Button();
            btnViewFormulas = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnProfile = new Button();
            btnViewCases = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRenteBeregner
            // 
            btnRenteBeregner.Location = new Point(3, 3);
            btnRenteBeregner.Name = "btnRenteBeregner";
            btnRenteBeregner.Size = new Size(155, 69);
            btnRenteBeregner.TabIndex = 0;
            btnRenteBeregner.Text = "Interest calculator";
            btnRenteBeregner.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 521);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewFormulas
            // 
            btnViewFormulas.Location = new Point(175, 3);
            btnViewFormulas.Name = "btnViewFormulas";
            btnViewFormulas.Size = new Size(155, 69);
            btnViewFormulas.TabIndex = 3;
            btnViewFormulas.Text = "View Formulas";
            btnViewFormulas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 553);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 333);
            panel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRenteBeregner, 0, 0);
            tableLayoutPanel1.Controls.Add(btnViewFormulas, 1, 0);
            tableLayoutPanel1.Controls.Add(btnProfile, 1, 1);
            tableLayoutPanel1.Controls.Add(btnViewCases, 0, 1);
            tableLayoutPanel1.Location = new Point(113, 77);
            tableLayoutPanel1.MaximumSize = new Size(344, 253);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(344, 253);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(175, 129);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(155, 69);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "Profile ...";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnViewCases
            // 
            btnViewCases.Location = new Point(3, 129);
            btnViewCases.Name = "btnViewCases";
            btnViewCases.Size = new Size(155, 69);
            btnViewCases.TabIndex = 4;
            btnViewCases.Text = "Insert text here";
            btnViewCases.UseVisualStyleBackColor = true;
            // 
            // ClientToolsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 577);
            Controls.Add(panel1);
            Name = "ClientToolsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tools page";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnRenteBeregner;
        private Button btnBack;
        private Button btnViewFormulas;
        private Panel panel1;
        private Button btnViewCases;
        private Button btnProfile;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
    }
}