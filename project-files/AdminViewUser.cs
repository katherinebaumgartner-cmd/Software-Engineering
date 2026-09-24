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
    public partial class AdminViewUser : Form
    {
        private string username {  get; set; }
        private SQL_DB_Manager objManager { get; set; }
        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public AdminViewUser(string username)
        {
            InitializeComponent();
            objManager = new SQL_DB_Manager(connectionstring);
            this.username = username;
        }

        private void AdminViewUser_Load(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            List<ourUser> users = new List<ourUser>();
            users = objManager.LoadDataFromDb();
            if (users != null)
            {
                lstUsers.Items.AddRange(users.ToArray());
            }
            else
            {
                lstUsers.Items.Add("No Users");
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ourUser user = (ourUser)lstUsers.SelectedItem;
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhoneNumber.Clear();
                txtPronouns.Clear();
                txtStatus.Clear();
                txtUsername.Clear();

                if (lstUsers.SelectedIndex == -1)
                {
                    return;
                }

                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtPhoneNumber.Text = user.Phone;
                txtPronouns.Text = user.Pronouns;
                txtStatus.Text = user.Status;
                txtUsername.Text = user.Username;
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
