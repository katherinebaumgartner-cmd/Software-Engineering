namespace Login_App_With_Database
{
    partial class FinManHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinManHome));
            btnClientToggle = new Button();
            panelSidebar = new Panel();
            pictureBox2 = new PictureBox();
            createact = new Button();
            btnClientProfile = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            ThridPartyBttn = new Button();
            msgbttn = new Button();
            viewClaimbttn = new Button();
            btViewUsers = new Button();
            pictureBox1 = new PictureBox();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClientToggle
            // 
            btnClientToggle.BackColor = Color.Transparent;
            btnClientToggle.Dock = DockStyle.Top;
            btnClientToggle.FlatStyle = FlatStyle.Flat;
            btnClientToggle.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientToggle.ForeColor = Color.FromArgb(71, 50, 41);
            btnClientToggle.Location = new Point(0, 0);
            btnClientToggle.Margin = new Padding(5, 4, 5, 4);
            btnClientToggle.Name = "btnClientToggle";
            btnClientToggle.Size = new Size(273, 73);
            btnClientToggle.TabIndex = 0;
            btnClientToggle.Text = "☰";
            btnClientToggle.UseVisualStyleBackColor = false;
            btnClientToggle.Visible = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(196, 158, 133);
            panelSidebar.Controls.Add(pictureBox2);
            panelSidebar.Controls.Add(createact);
            panelSidebar.Controls.Add(btnClientProfile);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnClientToggle);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(5, 4, 5, 4);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(273, 721);
            panelSidebar.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 218);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(274, 420);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // createact
            // 
            createact.BackColor = Color.Transparent;
            createact.Dock = DockStyle.Top;
            createact.FlatStyle = FlatStyle.Flat;
            createact.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createact.ForeColor = Color.FromArgb(71, 50, 41);
            createact.Location = new Point(0, 146);
            createact.Margin = new Padding(5, 4, 5, 4);
            createact.Name = "createact";
            createact.Size = new Size(273, 73);
            createact.TabIndex = 5;
            createact.UseVisualStyleBackColor = false;
            createact.Click += createact_Click;
            // 
            // btnClientProfile
            // 
            btnClientProfile.BackColor = Color.Transparent;
            btnClientProfile.Dock = DockStyle.Top;
            btnClientProfile.FlatStyle = FlatStyle.Flat;
            btnClientProfile.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientProfile.ForeColor = Color.FromArgb(71, 50, 41);
            btnClientProfile.Location = new Point(0, 73);
            btnClientProfile.Margin = new Padding(5, 4, 5, 4);
            btnClientProfile.Name = "btnClientProfile";
            btnClientProfile.Size = new Size(273, 73);
            btnClientProfile.TabIndex = 4;
            btnClientProfile.Text = "Profile";
            btnClientProfile.UseVisualStyleBackColor = false;
            btnClientProfile.Click += btnClientProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(71, 50, 41);
            btnLogout.Location = new Point(0, 638);
            btnLogout.Margin = new Padding(5, 4, 5, 4);
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
            panel1.Controls.Add(ThridPartyBttn);
            panel1.Controls.Add(msgbttn);
            panel1.Controls.Add(viewClaimbttn);
            panel1.Controls.Add(btViewUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(273, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 721);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // ThridPartyBttn
            // 
            ThridPartyBttn.BackColor = Color.FromArgb(196, 158, 133);
            ThridPartyBttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThridPartyBttn.ForeColor = Color.FromArgb(71, 50, 41);
            ThridPartyBttn.Location = new Point(125, 326);
            ThridPartyBttn.Margin = new Padding(4, 3, 4, 3);
            ThridPartyBttn.Name = "ThridPartyBttn";
            ThridPartyBttn.Size = new Size(422, 79);
            ThridPartyBttn.TabIndex = 5;
            ThridPartyBttn.Text = "Third Party Payment";
            ThridPartyBttn.UseVisualStyleBackColor = false;
            ThridPartyBttn.Click += ThridPartyBttn_Click_1;
            // 
            // msgbttn
            // 
            msgbttn.BackColor = Color.FromArgb(196, 158, 133);
            msgbttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgbttn.ForeColor = Color.FromArgb(71, 50, 41);
            msgbttn.Location = new Point(125, 218);
            msgbttn.Margin = new Padding(4, 3, 4, 3);
            msgbttn.Name = "msgbttn";
            msgbttn.Size = new Size(422, 80);
            msgbttn.TabIndex = 3;
            msgbttn.Text = "Communication";
            msgbttn.UseVisualStyleBackColor = false;
            msgbttn.Click += msgbttn_Click;
            // 
            // viewClaimbttn
            // 
            viewClaimbttn.BackColor = Color.FromArgb(196, 158, 133);
            viewClaimbttn.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewClaimbttn.ForeColor = Color.FromArgb(71, 50, 41);
            viewClaimbttn.Location = new Point(125, 114);
            viewClaimbttn.Margin = new Padding(4, 3, 4, 3);
            viewClaimbttn.Name = "viewClaimbttn";
            viewClaimbttn.Size = new Size(422, 83);
            viewClaimbttn.TabIndex = 2;
            viewClaimbttn.Text = "View Claims";
            viewClaimbttn.UseVisualStyleBackColor = false;
            viewClaimbttn.Click += viewClaimbttn_Click;
            // 
            // btViewUsers
            // 
            btViewUsers.BackColor = Color.FromArgb(196, 158, 133);
            btViewUsers.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btViewUsers.ForeColor = Color.FromArgb(71, 50, 41);
            btViewUsers.Location = new Point(125, 14);
            btViewUsers.Margin = new Padding(4, 3, 4, 3);
            btViewUsers.Name = "btViewUsers";
            btViewUsers.Size = new Size(422, 85);
            btViewUsers.TabIndex = 1;
            btViewUsers.Text = "View Users";
            btViewUsers.UseVisualStyleBackColor = false;
            btViewUsers.Click += btViewUsers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 425);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(941, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FinManHome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 721);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FinManHome";
            Text = "Finance Manager Home";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientToggle;
        private Panel panelSidebar;
        private Button btnClientProfile;
        private Button btnLogout;
        private Panel panel1;
        private Button createact;
        private PictureBox pictureBox2;
        private Button msgbttn;
        private Button viewClaimbttn;
        private Button  btViewUsers;
        private PictureBox pictureBox1;
        private Button ThridPartyBttn;
    }
}