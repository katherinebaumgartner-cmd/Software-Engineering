using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Login_App_With_Database
{
    partial class messageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageForm));
            panel1 = new Panel();
            backbttn = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            txtBody = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtTo = new TextBox();
            button1 = new Button();
            lstMessages = new ListBox();
            lblFrom = new Label();
            lblMessage = new Label();
            txtMessage = new RichTextBox();
            txtFrom = new TextBox();
            btnBack = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            txtInboxName = new TextBox();
            pawprints2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pawprints2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 50, 41);
            panel1.Controls.Add(backbttn);
            panel1.Location = new Point(0, 913);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 49);
            panel1.TabIndex = 0;
            // 
            // backbttn
            // 
            backbttn.BackColor = Color.FromArgb(255, 214, 175);
            backbttn.Location = new Point(1324, -6);
            backbttn.Margin = new Padding(6);
            backbttn.Name = "backbttn";
            backbttn.Size = new Size(139, 49);
            backbttn.TabIndex = 4;
            backbttn.Text = "Back";
            backbttn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(71, 50, 41);
            panel2.Location = new Point(6, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1480, 51);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 214, 175);
            textBox1.Font = new System.Drawing.Font("Bahnschrift", 15F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(71, 50, 41);
            textBox1.Location = new Point(15, 63);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 56);
            textBox1.TabIndex = 2;
            textBox1.Text = " Message Board";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtBody
            // 
            txtBody.BackColor = Color.FromArgb(255, 214, 175);
            txtBody.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            txtBody.Location = new Point(28, 207);
            txtBody.Margin = new Padding(6);
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(835, 158);
            txtBody.TabIndex = 3;
            txtBody.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            label1.Location = new Point(28, 158);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 33);
            label1.TabIndex = 5;
            label1.Text = "New Message:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 390);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(196, 158, 133);
            label4.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            label4.Location = new Point(219, 155);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 33);
            label4.TabIndex = 9;
            label4.Text = "To:";
            // 
            // txtTo
            // 
            txtTo.BackColor = Color.FromArgb(255, 214, 175);
            txtTo.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            txtTo.Location = new Point(278, 155);
            txtTo.Margin = new Padding(6);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(270, 40);
            txtTo.TabIndex = 10;
            txtTo.TextChanged += txtTo_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(107, 75, 62);
            button1.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(196, 158, 133);
            button1.Location = new Point(560, 150);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 11;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lstMessages
            // 
            lstMessages.BackColor = Color.FromArgb(255, 214, 175);
            lstMessages.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            lstMessages.FormattingEnabled = true;
            lstMessages.Location = new Point(28, 464);
            lstMessages.Margin = new Padding(4);
            lstMessages.Name = "lstMessages";
            lstMessages.Size = new Size(835, 169);
            lstMessages.TabIndex = 13;
            lstMessages.SelectedIndexChanged += lstMessages_SelectedIndexChanged;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            lblFrom.Location = new Point(28, 652);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(86, 33);
            lblFrom.TabIndex = 14;
            lblFrom.Text = "From:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            lblMessage.Location = new Point(28, 711);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(126, 33);
            lblMessage.TabIndex = 16;
            lblMessage.Text = "Message:";
            lblMessage.Click += lblMessage_Click;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(255, 214, 175);
            txtMessage.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            txtMessage.Location = new Point(162, 711);
            txtMessage.Margin = new Padding(4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(701, 156);
            txtMessage.TabIndex = 17;
            txtMessage.Text = "";
            // 
            // txtFrom
            // 
            txtFrom.BackColor = Color.FromArgb(255, 214, 175);
            txtFrom.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            txtFrom.Location = new Point(122, 649);
            txtFrom.Margin = new Padding(4);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(307, 40);
            txtFrom.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.AutoEllipsis = true;
            btnBack.BackColor = Color.FromArgb(107, 75, 62);
            btnBack.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(196, 158, 133);
            btnBack.Location = new Point(1258, 810);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(201, 74);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Bahnschrift", 10F, FontStyle.Bold);
            label5.Location = new Point(28, 412);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 33);
            label5.TabIndex = 20;
            label5.Text = "Old Messages:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(988, 63);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(463, 820);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // txtInboxName
            // 
            txtInboxName.BackColor = Color.FromArgb(255, 214, 175);
            txtInboxName.Location = new Point(988, 63);
            txtInboxName.Margin = new Padding(6);
            txtInboxName.Name = "txtInboxName";
            txtInboxName.Size = new Size(476, 39);
            txtInboxName.TabIndex = 12;
            // 
            // pawprints2
            // 
            pawprints2.Image = (System.Drawing.Image)resources.GetObject("pawprints2.Image");
            pawprints2.Location = new Point(28, 131);
            pawprints2.Margin = new Padding(6);
            pawprints2.Name = "pawprints2";
            pawprints2.Size = new Size(937, 922);
            pawprints2.SizeMode = PictureBoxSizeMode.Zoom;
            pawprints2.TabIndex = 34;
            pawprints2.TabStop = false;
            // 
            // messageForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(196, 158, 133);
            ClientSize = new Size(1474, 899);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(txtFrom);
            Controls.Add(txtMessage);
            Controls.Add(lblMessage);
            Controls.Add(lblFrom);
            Controls.Add(lstMessages);
            Controls.Add(txtInboxName);
            Controls.Add(button1);
            Controls.Add(txtTo);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBody);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pawprints2);
            Margin = new Padding(6);
            Name = "messageForm";
            Text = "messageForm";
            Load += messageForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pawprints2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private RichTextBox txtBody;
        private Button backbttn;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtTo;
        private Button button1;
        private ListBox lstMessages;
        private Label lblFrom;
        private Label lblMessage;
        private RichTextBox txtMessage;
        private TextBox txtFrom;
        private Button btnBack;
        private Label label5;
        private PictureBox pictureBox2;
        private TextBox txtInboxName;
        private PictureBox pawprints2;
    }
}