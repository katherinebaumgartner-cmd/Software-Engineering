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
    public partial class ViewClaimPage : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public ViewClaimPage(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
            string? firstName = objManager.getFirstName(username);
            //txtInboxName.Text = firstName;
        }

        private void ViewClaimPage_Load(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            List<Claim> claims = new List<Claim>();
            claims = objManager.LoadClaims();
            if (claims != null)
            {
                lstUsers.Items.AddRange(claims.ToArray());
            }
            else
            {
                lstUsers.Items.Add("No Claims");
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Claim claim = (Claim)lstUsers.SelectedItem;
                TypeBox.Clear();
                DateBox.Clear();
                AmountBox.Clear();
                IDBox.Clear();
                DescBox.Clear();

                if (lstUsers.SelectedIndex == -1)
                {
                    return;
                }
                TypeBox.Text = claim.ClaimType;
                ClaimIDBox.Text = claim.ClaimID.ToString();
                DateBox.Text = claim.ClaimDate.ToString();
                AmountBox.Text = claim.ClaimAmount.ToString();
                IDBox.Text = claim.UserID.ToString();
                DescBox.Text = claim.ClaimDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Close();
            string? role = objManager.getStatus(username);

            if (role == "ADMIN")
            {
                AdminHome frmAdmin = new(username);


                this.Hide();

                frmAdmin.Show();
            }
            //need to make a claim manager page

            else if (role == "CLAIM MANAGER")
            {
                ClaimManPage frmClaim = new(username);


                this.Hide();

                frmClaim.Show();
            }
            else if (role == "FINANCE MANAGER")
            {
                FinManHome frmFinMan = new FinManHome(username);


                this.Hide();

                frmFinMan.Show();
            }
            else
            {
                Welcome_Form frmWelcome = new Welcome_Form(username);



                this.Hide();

                frmWelcome.Show();
            }
        }

    }
    
}
