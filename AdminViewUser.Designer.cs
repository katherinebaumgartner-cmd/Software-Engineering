namespace Login_App_With_Database
{
    partial class AdminViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewUser));
            lstUsers = new ListBox();
            lblUsername = new Label();
            lblPhoneNumber = new Label();
            lblStatus = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblPronouns = new Label();
            txtStatus = new TextBox();
            txtPronouns = new TextBox();
            txtUsername = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            backbttn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.BackColor = Color.FromArgb(255, 214, 175);
            lstUsers.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            lstUsers.ForeColor = SystemColors.WindowText;
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(50, 26);
            lstUsers.Margin = new Padding(4, 4, 4, 4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(1024, 274);
            lstUsers.TabIndex = 0;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(33, 337);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 29);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(445, 385);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(176, 29);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(445, 336);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 29);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Role:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(35, 538);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(135, 29);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(33, 472);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(137, 29);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // lblPronouns
            // 
            lblPronouns.AutoSize = true;
            lblPronouns.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPronouns.Location = new Point(33, 405);
            lblPronouns.Margin = new Padding(4, 0, 4, 0);
            lblPronouns.Name = "lblPronouns";
            lblPronouns.Size = new Size(119, 29);
            lblPronouns.TabIndex = 6;
            lblPronouns.Text = "Pronouns:";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(255, 214, 175);
            txtStatus.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtStatus.Location = new Point(551, 331);
            txtStatus.Margin = new Padding(4, 4, 4, 4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(271, 34);
            txtStatus.TabIndex = 7;
            // 
            // txtPronouns
            // 
            txtPronouns.BackColor = Color.FromArgb(255, 214, 175);
            txtPronouns.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtPronouns.Location = new Point(170, 405);
            txtPronouns.Margin = new Padding(4, 4, 4, 4);
            txtPronouns.Name = "txtPronouns";
            txtPronouns.Size = new Size(234, 34);
            txtPronouns.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(255, 214, 175);
            txtUsername.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtUsername.Location = new Point(170, 337);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(234, 34);
            txtUsername.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(255, 214, 175);
            txtFirstName.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(170, 472);
            txtFirstName.Margin = new Padding(4, 4, 4, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(234, 34);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(255, 214, 175);
            txtLastName.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtLastName.Location = new Point(170, 538);
            txtLastName.Margin = new Padding(4, 4, 4, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(234, 34);
            txtLastName.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.FromArgb(255, 214, 175);
            txtPhoneNumber.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(629, 385);
            txtPhoneNumber.Margin = new Padding(4, 4, 4, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(193, 34);
            txtPhoneNumber.TabIndex = 12;
            // 
            // backbttn
            // 
            backbttn.BackColor = Color.FromArgb(107, 75, 62);
            backbttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbttn.ForeColor = Color.FromArgb(196, 158, 133);
            backbttn.Location = new Point(992, 567);
            backbttn.Margin = new Padding(6, 6, 6, 6);
            backbttn.Name = "backbttn";
            backbttn.Size = new Size(149, 47);
            backbttn.TabIndex = 13;
            backbttn.Text = "Back";
            backbttn.UseVisualStyleBackColor = false;
            backbttn.Click += backbttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(462, 336);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(941, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AdminViewUser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(1153, 621);
            Controls.Add(backbttn);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtUsername);
            Controls.Add(txtPronouns);
            Controls.Add(txtStatus);
            Controls.Add(lblPronouns);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblStatus);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblUsername);
            Controls.Add(lstUsers);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdminViewUser";
            Text = "AdminViewUser";
            Load += AdminViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstUsers;
        private Label lblUsername;
        private Label lblPhoneNumber;
        private Label lblStatus;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblPronouns;
        private TextBox txtStatus;
        private TextBox txtPronouns;
        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private Button backbttn;
        private PictureBox pictureBox1;
    }
}