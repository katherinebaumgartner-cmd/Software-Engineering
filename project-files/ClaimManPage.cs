using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_App_With_Database
{
    public partial class ClaimManPage : Form
    {

        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        public ClaimManPage(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }
        public ClaimManPage()
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login_Form logoutClaimManPage = new();

            logoutClaimManPage.Show();
        }
        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            AdminViewUser adminViewUser = new AdminViewUser(username);
            adminViewUser.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
        private void MesgTxtBx_Click(object sender, EventArgs e)
        {
            messageForm MsgForm = new messageForm(username);
            MsgForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void viewClaimBttn_Click(object sender, EventArgs e)
        {
            ViewClaimPage Claimfrm = new(username);
            Claimfrm.Show();
            this.Close();
        }

        private void btnClaimProfile_Click(object sender, EventArgs e)
        {
            Close();
            ClaimManProfile ClaimManProfileOpen = new ClaimManProfile(username);

            ClaimManProfileOpen.Show();
        }
    }
}
