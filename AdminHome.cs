using Login_App_With_Database;
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
    public partial class AdminHome : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        public AdminHome(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public AdminHome()
        {
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            Close();
            AdminProfile adminProfilePageOpen = new AdminProfile(username);

            adminProfilePageOpen.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login_Form logoutAdminLogin = new();

            logoutAdminLogin.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void Msg_Click(object sender, EventArgs e)
        {

            Close();
            messageForm adminMessagePageOpen = new messageForm(username);

            adminMessagePageOpen.Show();

        }


        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            AdminViewUser adminViewUser = new AdminViewUser(username);
            adminViewUser.Show();
            this.Hide();
        }



        private void ViewClaimBttn_Click(object sender, EventArgs e)
        {
            ViewClaimPage Claimfrm = new ViewClaimPage(username);
            Claimfrm.Show();
            this.Close();
        }

        

        private void btnApprove_Click(object sender, EventArgs e)
        {
            ApproveAcct Acctaprv = new ApproveAcct(username);
            Acctaprv.Show();
            this.Close();
        }
    }
}



   
