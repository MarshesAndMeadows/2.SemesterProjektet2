namespace UserInterface.Forms
{
    partial class LawyerOverview
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
            btnLogout = new Button();
            btnCreateClient = new Button();
            btnCreateCase = new Button();
            btnHelpButton = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnHelpButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-8, -38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1600, 900);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(217, 847);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnCreateClient);
            panel3.Controls.Add(btnCreateCase);
            panel3.Location = new Point(17, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 762);
            panel3.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(13, 680);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(156, 70);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCreateClient
            // 
            btnCreateClient.Location = new Point(13, 96);
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.Size = new Size(156, 70);
            btnCreateClient.TabIndex = 1;
            btnCreateClient.Text = "Create Client";
            btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // btnCreateCase
            // 
            btnCreateCase.Location = new Point(13, 20);
            btnCreateCase.Name = "btnCreateCase";
            btnCreateCase.Size = new Size(156, 70);
            btnCreateCase.TabIndex = 0;
            btnCreateCase.Text = "Create Case";
            btnCreateCase.UseVisualStyleBackColor = true;
            // 
            // btnHelpButton
            // 
            btnHelpButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelpButton.Location = new Point(1528, 50);
            btnHelpButton.Name = "btnHelpButton";
            btnHelpButton.Size = new Size(50, 50);
            btnHelpButton.TabIndex = 4;
            btnHelpButton.Text = "?";
            btnHelpButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 73);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search ...";
            textBox1.Size = new Size(904, 27);
            textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(226, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1352, 762);
            dataGridView1.TabIndex = 2;
            // 
            // LawyerOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel1);
            Name = "LawyerOverview";
            Text = "LawyerOverview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCreateCase;
        private Button btnHelpButton;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnCreateClient;
        private Panel panel2;
        private Button btnLogout;
        private Panel panel3;
    }
}