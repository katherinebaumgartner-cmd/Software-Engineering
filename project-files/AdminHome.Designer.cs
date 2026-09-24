namespace Login_App_With_Database
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnAdminProfile = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            MesgTxtBx = new Button();
            ViewClaimBttn = new Button();
            btnViewUsers = new Button();
            pictureBox2 = new PictureBox();
            btnApprove = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(196, 158, 133);
            panelSidebar.Controls.Add(btnApprove);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Controls.Add(btnAdminProfile);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(6, 4, 6, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(273, 742);
            panelSidebar.TabIndex = 5;
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
            // btnAdminProfile
            // 
            btnAdminProfile.BackColor = Color.Transparent;
            btnAdminProfile.Dock = DockStyle.Top;
            btnAdminProfile.FlatStyle = FlatStyle.Flat;
            btnAdminProfile.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminProfile.ForeColor = Color.FromArgb(71, 50, 41);
            btnAdminProfile.Location = new Point(0, 0);
            btnAdminProfile.Margin = new Padding(6, 4, 6, 4);
            btnAdminProfile.Name = "btnAdminProfile";
            btnAdminProfile.Size = new Size(273, 73);
            btnAdminProfile.TabIndex = 4;
            btnAdminProfile.Text = "Profile";
            btnAdminProfile.UseVisualStyleBackColor = false;
            btnAdminProfile.Click += btnAdminProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(71, 50, 41);
            btnLogout.Location = new Point(0, 659);
            btnLogout.Margin = new Padding(6, 4, 6, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(273, 83);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 214, 175);
            panel1.Controls.Add(MesgTxtBx);
            panel1.Controls.Add(ViewClaimBttn);
            panel1.Controls.Add(btnViewUsers);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(273, 0);
            panel1.Margin = new Padding(6, 4, 6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 742);
            panel1.TabIndex = 6;
            // 
            // MesgTxtBx
            // 
            MesgTxtBx.BackColor = Color.FromArgb(196, 158, 133);
            MesgTxtBx.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MesgTxtBx.ForeColor = Color.FromArgb(71, 50, 41);
            MesgTxtBx.Location = new Point(189, 365);
            MesgTxtBx.Margin = new Padding(6, 4, 6, 4);
            MesgTxtBx.Name = "MesgTxtBx";
            MesgTxtBx.Size = new Size(604, 73);
            MesgTxtBx.TabIndex = 3;
            MesgTxtBx.Text = "Messaging";
            MesgTxtBx.UseVisualStyleBackColor = false;
            MesgTxtBx.Click += Msg_Click;
            // 
            // ViewClaimBttn
            // 
            ViewClaimBttn.BackColor = Color.FromArgb(196, 158, 133);
            ViewClaimBttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewClaimBttn.ForeColor = Color.FromArgb(71, 50, 41);
            ViewClaimBttn.Location = new Point(189, 228);
            ViewClaimBttn.Margin = new Padding(6, 4, 6, 4);
            ViewClaimBttn.Name = "ViewClaimBttn";
            ViewClaimBttn.Size = new Size(604, 73);
            ViewClaimBttn.TabIndex = 2;
            ViewClaimBttn.Text = "View Claims";
            ViewClaimBttn.UseVisualStyleBackColor = false;
            ViewClaimBttn.Click += ViewClaimBttn_Click;
            // 
            // btnViewUsers
            // 
            btnViewUsers.BackColor = Color.FromArgb(196, 158, 133);
            btnViewUsers.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewUsers.ForeColor = Color.FromArgb(71, 50, 41);
            btnViewUsers.Location = new Point(189, 83);
            btnViewUsers.Margin = new Padding(6, 4, 6, 4);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(604, 73);
            btnViewUsers.TabIndex = 1;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = false;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 429);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(882, 358);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Transparent;
            btnApprove.Dock = DockStyle.Top;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = Color.FromArgb(71, 50, 41);
            btnApprove.Location = new Point(0, 73);
            btnApprove.Margin = new Padding(6, 4, 6, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(273, 73);
            btnApprove.TabIndex = 8;
            btnApprove.Text = "Approve Accounts";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 742);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Margin = new Padding(6, 4, 6, 4);
            Name = "AdminHome";
            Text = "Admin Home";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSidebar;
        private Button btnAdminProfile;
        private Button btnLogout;
        private Panel panel1;
        private Button MesgTxtBx;
        private Button ViewClaimBttn;
        private Button btnViewUsers;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnApprove;
    }
}