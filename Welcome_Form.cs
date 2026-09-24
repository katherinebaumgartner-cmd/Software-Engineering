using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class Welcome_Form : Form
    {
        private string username { get; set; }
        public Welcome_Form(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnClientProfile_Click(object sender, EventArgs e)
        {
            Close();
            ClientProfile clientProfilePageOpen = new ClientProfile(username);

            clientProfilePageOpen.Show();
        }

        private void btnApplyClaim_Click(object sender, EventArgs e)
        {
            Close();
            ClaimApplicationForm applyClaimOpen = new(username);

            applyClaimOpen.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login_Form logoutLoginOpen = new();

            logoutLoginOpen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCommunication_Click(object sender, EventArgs e)
        {
            Close();
            messageForm adminMessagePageOpen = new messageForm(username);

            adminMessagePageOpen.Show();
        }

        private void btnViewClaims_Click(object sender, EventArgs e)
        {
            ViewClaimPage Claimfrm = new(username);
            Claimfrm.Show();
            this.Close();

        }

        private void paymentBttn_Click(object sender, EventArgs e)
        {
            ThirdParty payForm = new();
            payForm.Show();
            this.Close();
        }
    }
}
