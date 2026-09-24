namespace Login_App_With_Database
{
    partial class ClaimApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimApplicationForm));
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ClaimType = new DomainUpDown();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnFileClaim = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 75, 62);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1285, 46);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 75, 62);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 672);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 50);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(71, 50, 41);
            label1.Location = new Point(523, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 48);
            label1.TabIndex = 21;
            label1.Text = "FILE A CLAIM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(71, 50, 41);
            label2.Location = new Point(114, 235);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(366, 29);
            label2.TabIndex = 22;
            label2.Text = "What type of claim are you filing?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(71, 50, 41);
            label3.Location = new Point(114, 346);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(238, 29);
            label3.TabIndex = 23;
            label3.Text = "Describe the incident";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(71, 50, 41);
            label4.Location = new Point(114, 474);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(334, 29);
            label4.TabIndex = 24;
            label4.Text = "When did the incident happen?";
            // 
            // ClaimType
            // 
            ClaimType.ForeColor = Color.FromArgb(71, 50, 41);
            ClaimType.Items.Add("Auto");
            ClaimType.Items.Add("Life");
            ClaimType.Items.Add("Pet");
            ClaimType.Items.Add("Other");
            ClaimType.Location = new Point(489, 232);
            ClaimType.Margin = new Padding(5, 5, 5, 5);
            ClaimType.Name = "ClaimType";
            ClaimType.Size = new Size(218, 39);
            ClaimType.TabIndex = 25;
            ClaimType.Text = "Claim Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(374, 339);
            textBox1.Margin = new Padding(5, 5, 5, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 39);
            textBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(196, 158, 133);
            button1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(71, 50, 41);
            button1.Location = new Point(1076, 613);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(208, 50);
            button1.TabIndex = 28;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(806, 6);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 696);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnFileClaim
            // 
            btnFileClaim.BackColor = Color.FromArgb(196, 158, 133);
            btnFileClaim.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFileClaim.ForeColor = Color.FromArgb(71, 50, 41);
            btnFileClaim.Location = new Point(442, 611);
            btnFileClaim.Margin = new Padding(5, 6, 5, 6);
            btnFileClaim.Name = "btnFileClaim";
            btnFileClaim.Size = new Size(208, 50);
            btnFileClaim.TabIndex = 30;
            btnFileClaim.Text = "File Claim";
            btnFileClaim.UseVisualStyleBackColor = false;
            btnFileClaim.Click += btnFileClaim_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 474);
            textBox2.Margin = new Padding(5, 5, 5, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 39);
            textBox2.TabIndex = 27;
            // 
            // ClaimApplicationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(1285, 722);
            Controls.Add(btnFileClaim);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ClaimType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ClaimApplicationForm";
            Text = "Claim application";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DomainUpDown ClaimType;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnFileClaim;
        private TextBox textBox2;
    }
}