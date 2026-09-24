namespace Login_App_With_Database
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            txtAddress = new TextBox();
            AddressLabel = new Label();
            txtDOB = new TextBox();
            DOBlabel = new Label();
            txtFirstName = new TextBox();
            FullName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            EmailTxtBox = new TextBox();
            EmailLabel = new Label();
            PhoneNumLabel = new Label();
            PhoneTxtBox = new TextBox();
            PronounsLabel = new Label();
            PronounsTxt = new TextBox();
            label7 = new Label();
            PinLabel = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            txtLastName = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(238, 158);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(183, 23);
            txtAddress.TabIndex = 15;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.BackColor = Color.Transparent;
            AddressLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = Color.Black;
            AddressLabel.Location = new Point(238, 142);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(53, 14);
            AddressLabel.TabIndex = 14;
            AddressLabel.Text = "Address:";
            AddressLabel.Click += AddressLabel_Click;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(238, 199);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(181, 23);
            txtDOB.TabIndex = 13;
            // 
            // DOBlabel
            // 
            DOBlabel.AutoSize = true;
            DOBlabel.BackColor = Color.Transparent;
            DOBlabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOBlabel.ForeColor = Color.Black;
            DOBlabel.Location = new Point(238, 183);
            DOBlabel.Name = "DOBlabel";
            DOBlabel.Size = new Size(78, 14);
            DOBlabel.TabIndex = 12;
            DOBlabel.Text = "Date of Birth:";
            
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(238, 76);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 23);
            txtFirstName.TabIndex = 11;
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.BackColor = Color.Transparent;
            FullName.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.Black;
            FullName.Location = new Point(238, 60);
            FullName.Name = "FullName";
            FullName.Size = new Size(68, 14);
            FullName.TabIndex = 10;
            FullName.Text = "First Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 22);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 75, 52);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 22);
            panel2.TabIndex = 18;
            
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(107, 75, 62);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 316);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(674, 22);
            panel3.TabIndex = 18;
            
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(38, 76);
            EmailTxtBox.Margin = new Padding(3, 2, 3, 2);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(183, 23);
            EmailTxtBox.TabIndex = 20;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.Black;
            EmailLabel.Location = new Point(38, 60);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 14);
            EmailLabel.TabIndex = 21;
            EmailLabel.Text = "Email:";
            // 
            // PhoneNumLabel
            // 
            PhoneNumLabel.AutoSize = true;
            PhoneNumLabel.BackColor = Color.Transparent;
            PhoneNumLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumLabel.ForeColor = Color.Black;
            PhoneNumLabel.Location = new Point(38, 101);
            PhoneNumLabel.Name = "PhoneNumLabel";
            PhoneNumLabel.Size = new Size(89, 14);
            PhoneNumLabel.TabIndex = 22;
            PhoneNumLabel.Text = "Phone Number:";
            // 
            // PhoneTxtBox
            // 
            PhoneTxtBox.Location = new Point(38, 117);
            PhoneTxtBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTxtBox.Name = "PhoneTxtBox";
            PhoneTxtBox.Size = new Size(183, 23);
            PhoneTxtBox.TabIndex = 23;
            // 
            // PronounsLabel
            // 
            PronounsLabel.AutoSize = true;
            PronounsLabel.BackColor = Color.Transparent;
            PronounsLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PronounsLabel.ForeColor = Color.Black;
            PronounsLabel.Location = new Point(38, 142);
            PronounsLabel.Name = "PronounsLabel";
            PronounsLabel.Size = new Size(63, 14);
            PronounsLabel.TabIndex = 24;
            PronounsLabel.Text = "Pronouns:";
            // 
            // PronounsTxt
            // 
            PronounsTxt.Location = new Point(38, 158);
            PronounsTxt.Margin = new Padding(3, 2, 3, 2);
            PronounsTxt.Name = "PronounsTxt";
            PronounsTxt.Size = new Size(183, 23);
            PronounsTxt.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(23, 24);
            label7.Name = "label7";
            label7.Size = new Size(419, 25);
            label7.TabIndex = 26;
            label7.Text = "Please add/update your information below :";

            // 
            // PinLabel
            // 
            PinLabel.AutoSize = true;
            PinLabel.BackColor = Color.Transparent;
            PinLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PinLabel.ForeColor = Color.Black;
            PinLabel.Location = new Point(38, 183);
            PinLabel.Name = "PinLabel";
            PinLabel.Size = new Size(62, 14);
            PinLabel.TabIndex = 27;
            PinLabel.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 199);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 23);
            txtPassword.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
           
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-71, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 156);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 214, 175);
            button1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(188, 254);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 31;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(238, 117);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(181, 23);
            txtLastName.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(238, 101);
            label1.Name = "label1";
            label1.Size = new Size(66, 14);
            label1.TabIndex = 32;
            label1.Text = "Last Name:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 214, 175);
            btnBack.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(498, 254);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 22);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(674, 338);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(PinLabel);
            Controls.Add(label7);
            Controls.Add(PronounsTxt);
            Controls.Add(PronounsLabel);
            Controls.Add(PhoneTxtBox);
            Controls.Add(PhoneNumLabel);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTxtBox);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtAddress);
            Controls.Add(AddressLabel);
            Controls.Add(txtDOB);
            Controls.Add(DOBlabel);
            Controls.Add(txtFirstName);
            Controls.Add(FullName);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminProfile";
            Text = "Admin Profile Page";
            Load += AdminProfile_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAddress;
        private Label AddressLabel;
        private TextBox txtDOB;
        private Label DOBlabel;
        private TextBox txtFirstName;
        private Label FullName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox EmailTxtBox;
        private Label EmailLabel;
        private Label PhoneNumLabel;
        private TextBox PhoneTxtBox;
        private Label PronounsLabel;
        private TextBox PronounsTxt;
        private Label label7;
        private Label PinLabel;
        private TextBox txtPassword; 
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox txtLastName;
        private Label label1;
        private Button btnBack;
    }
}