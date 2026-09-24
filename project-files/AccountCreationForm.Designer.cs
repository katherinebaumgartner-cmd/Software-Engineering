namespace Login_App_With_Database
{
    partial class AccountCreationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountCreationForm));
            welcomeLabel = new Label();
            intructionsTxt = new Label();
            lblEmailCreation = new Label();
            lblUsernameCreation = new Label();
            lblPasswordCreation = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCreateAnAccount = new Button();
            lblSelectRole = new Label();
            roleSelect = new DomainUpDown();
            btnBack = new Button();
            fattypose = new PictureBox();
            fattyquote = new TextBox();
            pawPrints = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fattypose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pawPrints).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.FromArgb(107, 75, 62);
            welcomeLabel.Location = new Point(180, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(317, 19);
            welcomeLabel.TabIndex = 11;
            welcomeLabel.Text = "Welcome to the Insurance Claim Software!";
            // 
            // intructionsTxt
            // 
            intructionsTxt.AutoSize = true;
            intructionsTxt.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            intructionsTxt.ForeColor = Color.FromArgb(107, 75, 62);
            intructionsTxt.Location = new Point(151, 38);
            intructionsTxt.Name = "intructionsTxt";
            intructionsTxt.Size = new Size(374, 19);
            intructionsTxt.TabIndex = 10;
            intructionsTxt.Text = "Enter your information below to create an account";
            // 
            // lblEmailCreation
            // 
            lblEmailCreation.AutoSize = true;
            lblEmailCreation.BackColor = Color.FromArgb(107, 75, 62);
            lblEmailCreation.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailCreation.ForeColor = SystemColors.Control;
            lblEmailCreation.Location = new Point(107, 101);
            lblEmailCreation.Name = "lblEmailCreation";
            lblEmailCreation.Size = new Size(83, 14);
            lblEmailCreation.TabIndex = 9;
            lblEmailCreation.Text = "ENTER EMAIL:";
            //lblEmailCreation.Click += lblEmailCreation_Click;
            // 
            // lblUsernameCreation
            // 
            lblUsernameCreation.AutoSize = true;
            lblUsernameCreation.BackColor = Color.FromArgb(107, 75, 62);
            lblUsernameCreation.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsernameCreation.ForeColor = SystemColors.Control;
            lblUsernameCreation.Location = new Point(98, 163);
            lblUsernameCreation.Name = "lblUsernameCreation";
            lblUsernameCreation.Size = new Size(118, 14);
            lblUsernameCreation.TabIndex = 8;
            lblUsernameCreation.Text = "CREATE USERNAME:";
            // 
            // lblPasswordCreation
            // 
            lblPasswordCreation.AutoSize = true;
            lblPasswordCreation.BackColor = Color.FromArgb(107, 75, 62);
            lblPasswordCreation.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordCreation.ForeColor = SystemColors.Control;
            lblPasswordCreation.Location = new Point(98, 242);
            lblPasswordCreation.Name = "lblPasswordCreation";
            lblPasswordCreation.Size = new Size(118, 14);
            lblPasswordCreation.TabIndex = 7;
            lblPasswordCreation.Text = "CREATE PASSWORD:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(236, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 6;
            //txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(236, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 23);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(236, 239);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 23);
            txtPassword.TabIndex = 4;
            //txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnCreateAnAccount
            // 
            btnCreateAnAccount.BackColor = Color.FromArgb(255, 214, 175);
            btnCreateAnAccount.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAnAccount.ForeColor = Color.FromArgb(107, 75, 62);
            btnCreateAnAccount.Location = new Point(323, 409);
            btnCreateAnAccount.Name = "btnCreateAnAccount";
            btnCreateAnAccount.Size = new Size(115, 43);
            btnCreateAnAccount.TabIndex = 3;
            btnCreateAnAccount.Text = "CREATE YOUR ACCOUNT";
            btnCreateAnAccount.UseVisualStyleBackColor = false;
            btnCreateAnAccount.Click += btnCreateAnAccount_Click;
            // 
            // lblSelectRole
            // 
            lblSelectRole.AutoSize = true;
            lblSelectRole.BackColor = Color.FromArgb(107, 75, 62);
            lblSelectRole.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectRole.ForeColor = SystemColors.Control;
            lblSelectRole.Location = new Point(107, 329);
            lblSelectRole.Name = "lblSelectRole";
            lblSelectRole.Size = new Size(114, 14);
            lblSelectRole.TabIndex = 2;
            lblSelectRole.Text = "SELECT YOUR ROLE";
            // 
            // roleSelect
            // 
            roleSelect.Items.Add("CLIENT");
            roleSelect.Items.Add("ADMIN");
            roleSelect.Items.Add("FINANCE MANAGER");
            roleSelect.Items.Add("CLAIM MANAGER");
            roleSelect.Location = new Point(236, 327);
            roleSelect.Name = "roleSelect";
            roleSelect.Size = new Size(231, 23);
            roleSelect.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 214, 175);
            btnBack.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(107, 75, 62);
            btnBack.Location = new Point(194, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 43);
            btnBack.TabIndex = 0;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // fattypose
            // 
            fattypose.BackgroundImageLayout = ImageLayout.None;
            fattypose.Image = (Image)resources.GetObject("fattypose.Image");
            fattypose.Location = new Point(533, 67);
            fattypose.Name = "fattypose";
            fattypose.Size = new Size(239, 99);
            fattypose.SizeMode = PictureBoxSizeMode.Zoom;
            fattypose.TabIndex = 12;
            fattypose.TabStop = false;
            // 
            // fattyquote
            // 
            fattyquote.BackColor = Color.FromArgb(196, 158, 133);
            fattyquote.BorderStyle = BorderStyle.None;
            fattyquote.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            fattyquote.ForeColor = Color.FromArgb(107, 75, 62);
            fattyquote.Location = new Point(522, 163);
            fattyquote.Multiline = true;
            fattyquote.Name = "fattyquote";
            fattyquote.Size = new Size(250, 189);
            fattyquote.TabIndex = 13;
            fattyquote.Text = "\"Apply for entry. We’ll let you know if you’re cool enough to sit at the boombox.\" - Felix";
            fattyquote.TextAlign = HorizontalAlignment.Center;
            fattyquote.UseWaitCursor = true;
            // 
            // pawPrints
            // 
            pawPrints.BackgroundImageLayout = ImageLayout.None;
            pawPrints.Image = (Image)resources.GetObject("pawPrints.Image");
            pawPrints.Location = new Point(522, 303);
            pawPrints.Name = "pawPrints";
            pawPrints.Size = new Size(239, 134);
            pawPrints.SizeMode = PictureBoxSizeMode.Zoom;
            pawPrints.TabIndex = 15;
            pawPrints.TabStop = false;
            //pawPrints.Click += pictureBox3_Click;
            // 
            // AccountCreationForm
            // 
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(811, 464);
            Controls.Add(pawPrints);
            Controls.Add(fattyquote);
            Controls.Add(btnCreateAnAccount);
            Controls.Add(fattypose);
            Controls.Add(btnBack);
            Controls.Add(roleSelect);
            Controls.Add(lblSelectRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(lblPasswordCreation);
            Controls.Add(lblUsernameCreation);
            Controls.Add(lblEmailCreation);
            Controls.Add(intructionsTxt);
            Controls.Add(welcomeLabel);
            DoubleBuffered = true;
            Name = "AccountCreationForm";
            Text = "Account Creation";
            ((System.ComponentModel.ISupportInitialize)fattypose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pawPrints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label welcomeLabel;
        private Label intructionsTxt;
        private Label lblEmailCreation;
        private Label lblUsernameCreation;
        private Label lblPasswordCreation;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnCreateAnAccount;
        private Label lblSelectRole;
        private DomainUpDown roleSelect;
        private Button btnBack;
        private PictureBox fattypose;
        private TextBox fattyquote;
        private PictureBox pawPrints;
    }
}