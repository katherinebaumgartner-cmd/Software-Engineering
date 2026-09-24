namespace Login_App_With_Database
{
    partial class ClaimManPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimManPage));
            btnClaimProfile = new Button();
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnAdminToggle = new Button();
            viewClaimBttn = new Button();
            btnViewUsers = new Button();
            panel1 = new Panel();
            MesgTxtBx = new Button();
            pictureBox2 = new PictureBox();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnClaimProfile
            // 
            btnClaimProfile.BackColor = Color.Transparent;
            btnClaimProfile.Dock = DockStyle.Top;
            btnClaimProfile.FlatStyle = FlatStyle.Flat;
            btnClaimProfile.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClaimProfile.ForeColor = Color.FromArgb(71, 50, 41);
            btnClaimProfile.Location = new Point(0, 73);
            btnClaimProfile.Margin = new Padding(6, 4, 6, 4);
            btnClaimProfile.Name = "btnClaimProfile";
            btnClaimProfile.Size = new Size(273, 73);
            btnClaimProfile.TabIndex = 4;
            btnClaimProfile.Text = "Profile";
            btnClaimProfile.UseVisualStyleBackColor = false;
            btnClaimProfile.Click += btnClaimProfile_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(196, 158, 133);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnClaimProfile);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnAdminToggle);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(6, 4, 6, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(273, 781);
            panelSidebar.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 228);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(71, 50, 41);
            btnLogout.Location = new Point(0, 698);
            btnLogout.Margin = new Padding(6, 4, 6, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(273, 83);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdminToggle
            // 
            btnAdminToggle.BackColor = Color.Transparent;
            btnAdminToggle.Dock = DockStyle.Top;
            btnAdminToggle.FlatStyle = FlatStyle.Flat;
            btnAdminToggle.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminToggle.ForeColor = Color.FromArgb(71, 50, 41);
            btnAdminToggle.Location = new Point(0, 0);
            btnAdminToggle.Margin = new Padding(6, 4, 6, 4);
            btnAdminToggle.Name = "btnAdminToggle";
            btnAdminToggle.Size = new Size(273, 73);
            btnAdminToggle.TabIndex = 0;
            btnAdminToggle.Text = "☰";
            btnAdminToggle.UseVisualStyleBackColor = false;
            btnAdminToggle.Visible = false;
            // 
            // viewClaimBttn
            // 
            viewClaimBttn.BackColor = Color.FromArgb(196, 158, 133);
            viewClaimBttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewClaimBttn.ForeColor = Color.FromArgb(71, 50, 41);
            viewClaimBttn.Location = new Point(357, 198);
            viewClaimBttn.Margin = new Padding(6, 4, 6, 4);
            viewClaimBttn.Name = "viewClaimBttn";
            viewClaimBttn.Size = new Size(604, 73);
            viewClaimBttn.TabIndex = 2;
            viewClaimBttn.Text = "View Claims";
            viewClaimBttn.UseVisualStyleBackColor = false;
            viewClaimBttn.Click += viewClaimBttn_Click;
            // 
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.FromArgb(196, 158, 133);
            btnViewUsers.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewUsers.ForeColor = Color.FromArgb(71, 50, 41);
            btnViewUsers.Location = new Point(357, 64);
            btnViewUsers.Margin = new Padding(6, 4, 6, 4);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(604, 73);
            btnViewUsers.TabIndex = 1;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = false;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 214, 175);
            panel1.Controls.Add(MesgTxtBx);
            panel1.Controls.Add(viewClaimBttn);
            panel1.Controls.Add(btnViewUsers);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1127, 781);
            panel1.TabIndex = 8;
            panel1.Click += btnClaimProfile_Click;
            panel1.Paint += panel1_Paint;
            // 
            // MesgTxtBx
            // 
            MesgTxtBx.BackColor = Color.FromArgb(196, 158, 133);
            MesgTxtBx.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MesgTxtBx.ForeColor = Color.FromArgb(71, 50, 41);
            MesgTxtBx.Location = new Point(357, 326);
            MesgTxtBx.Margin = new Padding(6, 4, 6, 4);
            MesgTxtBx.Name = "MesgTxtBx";
            MesgTxtBx.Size = new Size(604, 73);
            MesgTxtBx.TabIndex = 3;
            MesgTxtBx.Text = "Messaging";
            MesgTxtBx.UseVisualStyleBackColor = false;
            MesgTxtBx.Click += MesgTxtBx_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(199, 397);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(882, 358);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // ClaimManPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 781);
            Controls.Add(panelSidebar);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "ClaimManPage";
            Text = "Claim Management Home";
            Load += Form1_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClaimProfile;
        private Panel panelSidebar;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnAdminToggle;
        private Button viewClaimBttn;
        private Button btnViewUsers;
        private Panel panel1;
        private Button MesgTxtBx;
        private PictureBox pictureBox2;
    }
}