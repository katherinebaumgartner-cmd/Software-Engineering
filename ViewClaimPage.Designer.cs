namespace Login_App_With_Database
{
    partial class ViewClaimPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewClaimPage));
            lstUsers = new ListBox();
            DescBox = new RichTextBox();
            lbl1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TypeBox = new TextBox();
            IDBox = new TextBox();
            AmountBox = new TextBox();
            DateBox = new TextBox();
            label5 = new Label();
            ClaimIDBox = new TextBox();
            pictureBox1 = new PictureBox();
            backbttn = new Button();
            descript = new TextBox();
            pawprints2 = new PictureBox();
            txtInboxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pawprints2).BeginInit();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.BackColor = Color.FromArgb(255, 214, 175);
            lstUsers.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(12, 107);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(276, 463);
            lstUsers.TabIndex = 1;
            lstUsers.SelectedIndexChanged += lstUsers_SelectedIndexChanged;
            // 
            // DescBox
            // 
            DescBox.BackColor = Color.FromArgb(255, 214, 175);
            DescBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            DescBox.Location = new Point(547, 70);
            DescBox.Margin = new Padding(5);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(273, 27);
            DescBox.TabIndex = 2;
            DescBox.Text = "";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            lbl1.Location = new Point(312, 443);
            lbl1.Margin = new Padding(5, 0, 5, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(192, 27);
            lbl1.TabIndex = 3;
            lbl1.Text = "Claim Description:";
            // 
            // label1
            // 
            label1.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            label1.Location = new Point(379, 70);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 4;
            label1.Text = "Claim Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            label2.Location = new Point(377, 147);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 27);
            label2.TabIndex = 5;
            label2.Text = "Claim Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            label3.Location = new Point(343, 229);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 27);
            label3.TabIndex = 6;
            label3.Text = "Claim Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            label4.Location = new Point(419, 309);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 27);
            label4.TabIndex = 7;
            label4.Text = "User ID:";
            // 
            // TypeBox
            // 
            TypeBox.BackColor = Color.FromArgb(255, 214, 175);
            TypeBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            TypeBox.Location = new Point(547, 440);
            TypeBox.Margin = new Padding(5);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(273, 34);
            TypeBox.TabIndex = 8;
            // 
            // IDBox
            // 
            IDBox.BackColor = Color.FromArgb(255, 214, 175);
            IDBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            IDBox.Location = new Point(547, 304);
            IDBox.Margin = new Padding(5);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(273, 34);
            IDBox.TabIndex = 9;
            // 
            // AmountBox
            // 
            AmountBox.BackColor = Color.FromArgb(255, 214, 175);
            AmountBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            AmountBox.Location = new Point(547, 229);
            AmountBox.Margin = new Padding(5);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(273, 34);
            AmountBox.TabIndex = 10;
            // 
            // DateBox
            // 
            DateBox.BackColor = Color.FromArgb(255, 214, 175);
            DateBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            DateBox.Location = new Point(547, 147);
            DateBox.Margin = new Padding(5);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(273, 34);
            DateBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            label5.Location = new Point(405, 384);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 12;
            label5.Text = "Claim ID:";
            // 
            // ClaimIDBox
            // 
            ClaimIDBox.BackColor = Color.FromArgb(255, 214, 175);
            ClaimIDBox.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            ClaimIDBox.Location = new Point(547, 373);
            ClaimIDBox.Margin = new Padding(5);
            ClaimIDBox.Name = "ClaimIDBox";
            ClaimIDBox.Size = new Size(273, 34);
            ClaimIDBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(830, -44);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 614);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // backbttn
            // 
            backbttn.BackColor = Color.FromArgb(107, 75, 62);
            backbttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbttn.ForeColor = Color.FromArgb(196, 158, 133);
            backbttn.Location = new Point(943, 510);
            backbttn.Margin = new Padding(6);
            backbttn.Name = "backbttn";
            backbttn.Size = new Size(171, 60);
            backbttn.TabIndex = 31;
            backbttn.Text = "back";
            backbttn.UseVisualStyleBackColor = false;
            backbttn.Click += backbttn_Click;
            // 
            // descript
            // 
            descript.BackColor = Color.FromArgb(196, 158, 133);
            descript.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descript.Location = new Point(15, 25);
            descript.Margin = new Padding(6);
            descript.Name = "descript";
            descript.Size = new Size(329, 58);
            descript.TabIndex = 32;
            descript.Text = "View Claims";
            // 
            // pawprints2
            // 
            pawprints2.Image = (Image)resources.GetObject("pawprints2.Image");
            pawprints2.Location = new Point(204, 373);
            pawprints2.Margin = new Padding(6);
            pawprints2.Name = "pawprints2";
            pawprints2.Size = new Size(523, 310);
            pawprints2.SizeMode = PictureBoxSizeMode.Zoom;
            pawprints2.TabIndex = 33;
            pawprints2.TabStop = false;
            // 
            // txtInboxName
            // 
            txtInboxName.BackColor = Color.FromArgb(255, 214, 175);
            txtInboxName.Font = new Font("Bahnschrift", 8.25F, FontStyle.Bold);
            txtInboxName.Location = new Point(915, 14);
            txtInboxName.Margin = new Padding(5);
            txtInboxName.Name = "txtInboxName";
            txtInboxName.Size = new Size(210, 34);
            txtInboxName.TabIndex = 34;
            // 
            // ViewClaimPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(1139, 606);
            Controls.Add(txtInboxName);
            Controls.Add(descript);
            Controls.Add(backbttn);
            Controls.Add(ClaimIDBox);
            Controls.Add(label5);
            Controls.Add(DateBox);
            Controls.Add(AmountBox);
            Controls.Add(IDBox);
            Controls.Add(TypeBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Controls.Add(DescBox);
            Controls.Add(lstUsers);
            Controls.Add(pictureBox1);
            Controls.Add(pawprints2);
            Margin = new Padding(5);
            Name = "ViewClaimPage";
            Text = "View Claims";
            Load += ViewClaimPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pawprints2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstUsers;
        private RichTextBox DescBox;
        private Label lbl1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TypeBox;
        private TextBox IDBox;
        private TextBox AmountBox;
        private TextBox DateBox;
        private Label label5;
        private TextBox ClaimIDBox;
        private PictureBox pictureBox1;
        private Button backbttn;
        private TextBox descript;
        private PictureBox pawprints2;
        private TextBox txtInboxName;
    }
}