namespace Login_App_With_Database
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnAccountCreation = new Button();
            panel1 = new Panel();
            btnClear = new Button();
            btnLogin = new Button();
            pawprints2 = new PictureBox();
            btnExit = new Button();
            CompanyName = new TextBox();
            fatty = new PictureBox();
            Slogan = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            catFood = new PictureBox();
            mouse = new PictureBox();
            label2 = new Label();
            lblUserPassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pawprints2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fatty).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mouse).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.FromArgb(107, 75, 62);
            lblUserName.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.Transparent;
            lblUserName.Location = new Point(18, 34);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(75, 14);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "USER NAME:";
        
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(151, 34);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(216, 23);
            txtUserName.TabIndex = 1;
           
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // btnAccountCreation
            // 
            btnAccountCreation.BackColor = Color.FromArgb(107, 75, 62);
            btnAccountCreation.FlatStyle = FlatStyle.Popup;
            btnAccountCreation.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccountCreation.ForeColor = SystemColors.ButtonFace;
            btnAccountCreation.Location = new Point(185, 138);
            btnAccountCreation.Margin = new Padding(3, 2, 3, 2);
            btnAccountCreation.Name = "btnAccountCreation";
            btnAccountCreation.Size = new Size(82, 47);
            btnAccountCreation.TabIndex = 8;
            btnAccountCreation.Text = "CREATE AN ACCOUNT";
            btnAccountCreation.UseVisualStyleBackColor = false;
            btnAccountCreation.Click += btnAccountCreation_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(196, 158, 133);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pawprints2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(CompanyName);
            panel1.Controls.Add(fatty);
            panel1.Controls.Add(Slogan);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 427);
            panel1.TabIndex = 9;
          
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 75, 62);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(219, 239);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(148, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(107, 75, 62);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(365, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "SIGN IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pawprints2
            // 
            pawprints2.Image = (Image)resources.GetObject("pawprints2.Image");
            pawprints2.Location = new Point(545, 287);
            pawprints2.Name = "pawprints2";
            pawprints2.Size = new Size(231, 140);
            pawprints2.SizeMode = PictureBoxSizeMode.Zoom;
            pawprints2.TabIndex = 14;
            pawprints2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(107, 75, 62);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(76, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // CompanyName
            // 
            CompanyName.BackColor = Color.FromArgb(196, 158, 133);
            CompanyName.BorderStyle = BorderStyle.None;
            CompanyName.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CompanyName.ForeColor = Color.FromArgb(107, 75, 62);
            CompanyName.Location = new Point(555, 198);
            CompanyName.Multiline = true;
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(221, 95);
            CompanyName.TabIndex = 13;
            CompanyName.Text = "Nine Lives Insurance";
            CompanyName.TextAlign = HorizontalAlignment.Center;
  
            // 
            // fatty
            // 
            fatty.Image = (Image)resources.GetObject("fatty.Image");
            fatty.Location = new Point(576, 34);
            fatty.Name = "fatty";
            fatty.Size = new Size(183, 171);
            fatty.SizeMode = PictureBoxSizeMode.Zoom;
            fatty.TabIndex = 12;
            fatty.TabStop = false;
      
            // 
            // Slogan
            // 
            Slogan.BackColor = Color.FromArgb(196, 158, 133);
            Slogan.BorderStyle = BorderStyle.None;
            Slogan.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Slogan.ForeColor = Color.FromArgb(107, 75, 62);
            Slogan.Location = new Point(13, 267);
            Slogan.MaximumSize = new Size(1000, 1000);
            Slogan.MinimumSize = new Size(10, 10);
            Slogan.Multiline = true;
            Slogan.Name = "Slogan";
            Slogan.Size = new Size(536, 300);
            Slogan.TabIndex = 11;
            Slogan.Text = "Nine Lives Insurance, \"Don't Wait for the Beat to Drop to Start Planning\"";
            Slogan.TextAlign = HorizontalAlignment.Center;
       
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 214, 175);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(catFood);
            panel2.Controls.Add(mouse);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnAccountCreation);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(lblUserPassword);
            panel2.Location = new Point(58, 25);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 194);
            panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // catFood
            // 
            catFood.Image = (Image)resources.GetObject("catFood.Image");
            catFood.Location = new Point(99, 72);
            catFood.Name = "catFood";
            catFood.Size = new Size(40, 60);
            catFood.SizeMode = PictureBoxSizeMode.Zoom;
            catFood.TabIndex = 12;
            catFood.TabStop = false;
            // 
            // mouse
            // 
            mouse.Image = (Image)resources.GetObject("mouse.Image");
            mouse.Location = new Point(100, 16);
            mouse.Name = "mouse";
            mouse.Size = new Size(45, 50);
            mouse.SizeMode = PictureBoxSizeMode.Zoom;
            mouse.TabIndex = 12;
            mouse.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 75, 62);
            label2.Location = new Point(18, 154);
            label2.Name = "label2";
            label2.Size = new Size(145, 14);
            label2.TabIndex = 9;
            label2.Text = "First time user? Click here";
            // 
            // lblUserPassword
            // 
            lblUserPassword.AutoSize = true;
            lblUserPassword.BackColor = Color.FromArgb(107, 75, 62);
            lblUserPassword.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPassword.ForeColor = Color.Transparent;
            lblUserPassword.Location = new Point(21, 99);
            lblUserPassword.Name = "lblUserPassword";
            lblUserPassword.Size = new Size(72, 14);
            lblUserPassword.TabIndex = 2;
            lblUserPassword.Text = "PASSWORD:";

            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 427);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login_Form";
            Text = "Login Form";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pawprints2).EndInit();
            ((System.ComponentModel.ISupportInitialize)fatty).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)mouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Button btnAccountCreation;
        private Panel panel1;
        private Label lblUserPassword;
        private Panel panel2;
        private Label label2;
        private TextBox Slogan;
        private PictureBox mouse;
        private PictureBox catFood;
        private PictureBox fatty;
        private TextBox CompanyName;
        private PictureBox pawprints2;
        private Button btnLogin;
        private Button btnExit;
        private Button btnClear;
        private PictureBox pictureBox1;
    }
}
