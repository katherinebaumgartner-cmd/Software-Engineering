using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using Microsoft.Data.SqlClient;  //this using directive is for access to the sqlServer

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_App_With_Database
{
   
    public partial class Login_Form : Form
    {
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";

        public Login_Form()
        {
            InitializeComponent();
            objManager = new SQL_DB_Manager(connectionstring);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;
            string username = txtUserName.Text;

            try
            {

                // find the valid password for a given user from the database and compare it with the one entered by the user
                if (enteredPassword == objManager.getAuthorizedPassword(username))
                {
                    string? role = objManager.getStatus(txtUserName.Text);
                    if (role != null)
                    {
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
                    else
                {
                    MessageBox.Show("Sorry. Invalid User Name and/or Password. Try again.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");
            }
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }


        private void btnAccountCreation_Click(object sender, EventArgs e)
        {
            AccountCreationForm accountCreation = new();
            this.Hide();
            accountCreation.Show();
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

        }

    }
}
