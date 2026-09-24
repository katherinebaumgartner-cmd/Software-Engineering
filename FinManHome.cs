using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class FinManHome : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        public FinManHome(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public FinManHome()
        {
        }

        private void btnClientProfile_Click(object sender, EventArgs e)
        {

            Close();
            FinanceManagerProfilePage FinManProfileProfileOpen = new FinanceManagerProfilePage(username);

            FinManProfileProfileOpen.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login_Form logoutFinManLogin = new();

            logoutFinManLogin.Show();
        }

        private void backBttn_Click(object sender, EventArgs e)
        {

        }

        private void ThridPartyBttn_Click(object sender, EventArgs e)
        {

        }
        private void msgbttn_Click(object sender, EventArgs e)
        {
            messageForm MsgForm = new messageForm(username);
            MsgForm.Show();
            this.Close();
        }

        private void createact_Click(object sender, EventArgs e)
        {

        }

        private void viewClaimbttn_Click(object sender, EventArgs e)
        {
            ViewClaimPage Claimfrm = new(username);
            Claimfrm.Show();
            this.Close();
        }

        private void btViewUsers_Click(object sender, EventArgs e)
        {
            AdminViewUser adminViewUser = new AdminViewUser(username);
            adminViewUser.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThridPartyBttn_Click_1(object sender, EventArgs e)
        {
            ThirdParty openThirdParty = new ThirdParty();
            openThirdParty.Show();
            this.Hide();
        }
    }
}
