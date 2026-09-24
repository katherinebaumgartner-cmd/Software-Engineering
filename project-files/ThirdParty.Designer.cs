namespace Login_App_With_Database
{
    partial class ThirdParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdParty));
            panel2 = new Panel();
            panel1 = new Panel();
            descrpt = new Label();
            roleSelectPayment = new DomainUpDown();
            LbPaymentmethd = new Label();
            lblAmt = new Label();
            textBox1 = new TextBox();
            sendpayment = new Button();
            backbttn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 75, 52);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 22);
            panel2.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 75, 62);
            panel1.Location = new Point(0, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 22);
            panel1.TabIndex = 53;
            // 
            // descrpt
            // 
            descrpt.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descrpt.Location = new Point(67, 24);
            descrpt.Name = "descrpt";
            descrpt.Size = new Size(642, 52);
            descrpt.TabIndex = 54;
            descrpt.Text = "Please choose the method of payment you would like to use to pay for these claims";
            descrpt.TextAlign = ContentAlignment.TopCenter;
            descrpt.UseCompatibleTextRendering = true;
            descrpt.UseMnemonic = false;
            // 
            // roleSelectPayment
            // 
            roleSelectPayment.Items.Add("CLIENT");
            roleSelectPayment.Items.Add("ADMIN");
            roleSelectPayment.Items.Add("FINANCE MANAGER");
            roleSelectPayment.Items.Add("CLAIM MANAGER");
            roleSelectPayment.Location = new Point(228, 125);
            roleSelectPayment.Name = "roleSelectPayment";
            roleSelectPayment.Size = new Size(231, 23);
            roleSelectPayment.TabIndex = 55;
            // 
            // LbPaymentmethd
            // 
            LbPaymentmethd.BackColor = Color.FromArgb(107, 75, 62);
            LbPaymentmethd.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPaymentmethd.ForeColor = SystemColors.Control;
            LbPaymentmethd.Location = new Point(104, 125);
            LbPaymentmethd.Name = "LbPaymentmethd";
            LbPaymentmethd.Size = new Size(118, 21);
            LbPaymentmethd.TabIndex = 56;
            LbPaymentmethd.Text = "PAYMENT METHOD:";
            LbPaymentmethd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAmt
            // 
            lblAmt.BackColor = Color.FromArgb(107, 75, 62);
            lblAmt.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmt.ForeColor = SystemColors.Control;
            lblAmt.Location = new Point(104, 194);
            lblAmt.Name = "lblAmt";
            lblAmt.Size = new Size(118, 23);
            lblAmt.TabIndex = 57;
            lblAmt.Text = "AMOUNT:";
            lblAmt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 195);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 58;
            // 
            // sendpayment
            // 
            sendpayment.BackColor = Color.FromArgb(107, 75, 62);
            sendpayment.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendpayment.ForeColor = Color.FromArgb(196, 158, 133);
            sendpayment.Location = new Point(367, 237);
            sendpayment.Name = "sendpayment";
            sendpayment.Size = new Size(92, 28);
            sendpayment.TabIndex = 59;
            sendpayment.Text = "Submit";
            sendpayment.UseVisualStyleBackColor = false;
            sendpayment.Click += sendpayment_Click;
            // 
            // backbttn
            // 
            backbttn.BackColor = Color.FromArgb(107, 75, 62);
            backbttn.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbttn.ForeColor = Color.FromArgb(196, 158, 133);
            backbttn.Location = new Point(680, 396);
            backbttn.Name = "backbttn";
            backbttn.Size = new Size(92, 28);
            backbttn.TabIndex = 60;
            backbttn.Text = "back";
            backbttn.UseVisualStyleBackColor = false;
            backbttn.Click += backbttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(482, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-70, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(647, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // ThirdParty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(800, 450);
            Controls.Add(backbttn);
            Controls.Add(sendpayment);
            Controls.Add(textBox1);
            Controls.Add(lblAmt);
            Controls.Add(LbPaymentmethd);
            Controls.Add(roleSelectPayment);
            Controls.Add(descrpt);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "ThirdParty";
            Text = "ThirdParty";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label descrpt;
        private DomainUpDown roleSelectPayment;
        private Label LbPaymentmethd;
        private Label lblAmt;
        private TextBox textBox1;
        private Button sendpayment;
        private Button backbttn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}