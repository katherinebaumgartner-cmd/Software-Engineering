namespace Login_App_With_Database
{
    partial class ApproveAcct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveAcct));
            descript = new TextBox();
            AccountList = new ListBox();
            declinebttn = new Button();
            ApproveBttn = new Button();
            pictureBox1 = new PictureBox();
            backbttn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // descript
            // 
            descript.BackColor = Color.FromArgb(196, 158, 133);
            descript.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descript.Location = new Point(59, 51);
            descript.Margin = new Padding(6);
            descript.Name = "descript";
            descript.Size = new Size(968, 58);
            descript.TabIndex = 0;
            descript.Text = "Please Approve/Decline the accounts below";
            // 
            // AccountList
            // 
            AccountList.BackColor = Color.FromArgb(255, 214, 175);
            AccountList.FormattingEnabled = true;
            AccountList.Location = new Point(53, 137);
            AccountList.Margin = new Padding(6);
            AccountList.Name = "AccountList";
            AccountList.Size = new Size(1390, 356);
            AccountList.TabIndex = 1;
            // 
            // declinebttn
            // 
            declinebttn.BackColor = Color.FromArgb(107, 75, 62);
            declinebttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            declinebttn.ForeColor = Color.FromArgb(196, 158, 133);
            declinebttn.Location = new Point(958, 518);
            declinebttn.Margin = new Padding(6);
            declinebttn.Name = "declinebttn";
            declinebttn.Size = new Size(199, 106);
            declinebttn.TabIndex = 2;
            declinebttn.Text = "Decline";
            declinebttn.UseVisualStyleBackColor = false;
            declinebttn.Click += declinebttn_Click;
            // 
            // ApproveBttn
            // 
            ApproveBttn.BackColor = Color.FromArgb(107, 75, 62);
            ApproveBttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApproveBttn.ForeColor = Color.FromArgb(196, 158, 133);
            ApproveBttn.Location = new Point(1190, 518);
            ApproveBttn.Margin = new Padding(6);
            ApproveBttn.Name = "ApproveBttn";
            ApproveBttn.Size = new Size(203, 106);
            ApproveBttn.TabIndex = 3;
            ApproveBttn.Text = "Approve";
            ApproveBttn.UseVisualStyleBackColor = false;
            ApproveBttn.Click += ApproveBttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-109, 493);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(984, 512);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // backbttn
            // 
            backbttn.BackColor = Color.FromArgb(107, 75, 62);
            backbttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbttn.ForeColor = Color.FromArgb(196, 158, 133);
            backbttn.Location = new Point(1300, 885);
            backbttn.Margin = new Padding(6);
            backbttn.Name = "backbttn";
            backbttn.Size = new Size(171, 60);
            backbttn.TabIndex = 5;
            backbttn.Text = "back";
            backbttn.UseVisualStyleBackColor = false;
            backbttn.Click += backbttn_Click;
            // 
            // ApproveAcct
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(1486, 960);
            Controls.Add(backbttn);
            Controls.Add(ApproveBttn);
            Controls.Add(declinebttn);
            Controls.Add(AccountList);
            Controls.Add(descript);
            Controls.Add(pictureBox1);
            Margin = new Padding(6);
            Name = "ApproveAcct";
            Text = "Form1";
            Load += ApproveAccout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descript;
        private ListBox AccountList;
        private Button declinebttn;
        private Button ApproveBttn;
        private PictureBox pictureBox1;
        private Button backbttn;
        
           
       }
}