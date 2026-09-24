namespace Login_App_With_Database
{
    partial class Welcome_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Form));
            btnEXIT = new Button();
            button1 = new Button();
            pnlContent = new Panel();
            BACKBTTN = new Button();
            btnCommunication = new Button();
            btnViewClaims = new Button();
            btnApplyClaim = new Button();
            pictureBox1 = new PictureBox();
            panelSidebar = new Panel();
            pictureBox2 = new PictureBox();
            btnClientProfile = new Button();
            btnLogout = new Button();
            btnClientToggle = new Button();
            paymentBttn = new Button();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEXIT
            // 
            btnEXIT.Location = new Point(299, 173);
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(75, 23);
            btnEXIT.TabIndex = 0;
            btnEXIT.Text = "EXIT";
            btnEXIT.UseVisualStyleBackColor = true;
            btnEXIT.Click += btnEXIT_Click;
            // 
            // button1
            // 
            button1.Location = new Point(102, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Panos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.FromArgb(255, 214, 175);
            pnlContent.Controls.Add(paymentBttn);
            pnlContent.Controls.Add(BACKBTTN);
            pnlContent.Controls.Add(btnCommunication);
            pnlContent.Controls.Add(btnViewClaims);
            pnlContent.Controls.Add(btnApplyClaim);
            pnlContent.Controls.Add(pictureBox1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(147, 0);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(527, 348);
            pnlContent.TabIndex = 8;
            // 
            // BACKBTTN
            // 
            BACKBTTN.BackColor = Color.FromArgb(255, 214, 175);
            BACKBTTN.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BACKBTTN.ForeColor = Color.FromArgb(71, 50, 41);
            BACKBTTN.Location = new Point(424, 335);
            BACKBTTN.Name = "BACKBTTN";
            BACKBTTN.Size = new Size(75, 23);
            BACKBTTN.TabIndex = 4;
            BACKBTTN.Text = "back";
            BACKBTTN.UseVisualStyleBackColor = false;
            // 
            // btnCommunication
            // 
            btnCommunication.BackColor = Color.FromArgb(196, 158, 133);
            btnCommunication.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCommunication.ForeColor = Color.FromArgb(71, 50, 41);
            btnCommunication.Location = new Point(101, 97);
            btnCommunication.Margin = new Padding(3, 2, 3, 2);
            btnCommunication.Name = "btnCommunication";
            btnCommunication.Size = new Size(325, 36);
            btnCommunication.TabIndex = 2;
            btnCommunication.Text = "Messaging";
            btnCommunication.UseVisualStyleBackColor = false;
            btnCommunication.Click += btnCommunication_Click;
            // 
            // btnViewClaims
            // 
            btnViewClaims.BackColor = Color.FromArgb(196, 158, 133);
            btnViewClaims.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewClaims.ForeColor = Color.FromArgb(71, 50, 41);
            btnViewClaims.Location = new Point(101, 58);
            btnViewClaims.Margin = new Padding(3, 2, 3, 2);
            btnViewClaims.Name = "btnViewClaims";
            btnViewClaims.Size = new Size(325, 35);
            btnViewClaims.TabIndex = 1;
            btnViewClaims.Text = "View Claims";
            btnViewClaims.UseVisualStyleBackColor = false;
            btnViewClaims.Click += btnViewClaims_Click;
            // 
            // btnApplyClaim
            // 
            btnApplyClaim.BackColor = Color.FromArgb(196, 158, 133);
            btnApplyClaim.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyClaim.ForeColor = Color.FromArgb(71, 50, 41);
            btnApplyClaim.Location = new Point(101, 11);
            btnApplyClaim.Margin = new Padding(3, 2, 3, 2);
            btnApplyClaim.Name = "btnApplyClaim";
            btnApplyClaim.Size = new Size(325, 34);
            btnApplyClaim.TabIndex = 0;
            btnApplyClaim.Text = "Apply Claims";
            btnApplyClaim.UseVisualStyleBackColor = false;
            btnApplyClaim.Click += btnApplyClaim_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(520, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(196, 158, 133);
            panelSidebar.BackgroundImageLayout = ImageLayout.None;
            panelSidebar.Controls.Add(pictureBox2);
            panelSidebar.Controls.Add(btnClientProfile);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnClientToggle);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(147, 348);
            panelSidebar.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnClientProfile
            // 
            btnClientProfile.BackColor = Color.Transparent;
            btnClientProfile.Dock = DockStyle.Top;
            btnClientProfile.FlatStyle = FlatStyle.Flat;
            btnClientProfile.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientProfile.ForeColor = Color.FromArgb(71, 50, 41);
            btnClientProfile.Location = new Point(0, 34);
            btnClientProfile.Margin = new Padding(3, 2, 3, 2);
            btnClientProfile.Name = "btnClientProfile";
            btnClientProfile.Size = new Size(147, 34);
            btnClientProfile.TabIndex = 4;
            btnClientProfile.Text = "Profile";
            btnClientProfile.UseVisualStyleBackColor = false;
            btnClientProfile.Click += btnClientProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(107, 75, 62);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(71, 50, 41);
            btnLogout.Location = new Point(0, 309);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(147, 39);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClientToggle
            // 
            btnClientToggle.BackColor = Color.Transparent;
            btnClientToggle.Dock = DockStyle.Top;
            btnClientToggle.FlatStyle = FlatStyle.Flat;
            btnClientToggle.ForeColor = Color.FromArgb(71, 50, 41);
            btnClientToggle.Location = new Point(0, 0);
            btnClientToggle.Margin = new Padding(3, 2, 3, 2);
            btnClientToggle.Name = "btnClientToggle";
            btnClientToggle.Size = new Size(147, 34);
            btnClientToggle.TabIndex = 0;
            btnClientToggle.Text = "☰";
            btnClientToggle.UseVisualStyleBackColor = false;
            btnClientToggle.Visible = false;
            // 
            // paymentBttn
            // 
            paymentBttn.BackColor = Color.FromArgb(196, 158, 133);
            paymentBttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paymentBttn.ForeColor = Color.FromArgb(71, 50, 41);
            paymentBttn.Location = new Point(101, 148);
            paymentBttn.Margin = new Padding(3, 2, 3, 2);
            paymentBttn.Name = "paymentBttn";
            paymentBttn.Size = new Size(325, 36);
            paymentBttn.TabIndex = 5;
            paymentBttn.Text = "Make Payment";
            paymentBttn.UseVisualStyleBackColor = false;
            paymentBttn.Click += paymentBttn_Click;
            // 
            // Welcome_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 348);
            Controls.Add(pnlContent);
            Controls.Add(panelSidebar);
            Controls.Add(button1);
            Controls.Add(btnEXIT);
            Name = "Welcome_Form";
            Text = "Client Home";
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEXIT;
        private Button button1;
        private Panel pnlContent;
        private Panel panelSidebar;
        private Button btnClientProfile;
        private Button btnLogout;
        private Button btnClientToggle;
        private Button btnApplyClaim;
        private Button btnCommunication;
        private Button btnViewClaims;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BACKBTTN;
        private Button paymentBttn;
    }
}