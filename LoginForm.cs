using Login_App_With_Database;
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


/*
 AUTHOR: Panos Linos
 DATE: 1-30-2025
 APPLICATION NAME: LoginForm
 DESCRIPTION: A simple windows app demo with a Login and a Welcome Form using a sqlServer database backend with valid users credential.
 NOTE:
 There is a tutorial in Appendix B from our C# textbook that shows how to create a SQL Server database.
 Also the Tutorial 4 on page 371,  explains how to grab records from a table in the database and display it to a GUI Form
*/


namespace LoginForm
{
    public partial class LoginForm : Form
    {
        //declare a Welcome Form variable
        Welcome_Form frmWelcome;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                string enteredPassword = txtPassword.Text;

                try
                {
                    // find the valid password for a given user from the database and compare it with the one entered by the user
                    if (enteredPassword == getAuthorizedPassword(txtUserName.Text))
                    {
                        frmWelcome = new WelcomeForm(); //create an new instance of the Welcome Form

                        MessageBox.Show("Welcome to the Database Management System!", "Successful Login!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        frmWelcome.Show();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempt to Login cancelled!", "Application Status");
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private String getAuthorizedPassword(string userName)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                   C:\Users\labuser\Desktop\SE361\SPRING 2025\IN CLASS TUTORIALS\LoginForm\LoginForm\UsersDB.mdf";

                cmd.Connection = cn;

                cmd.CommandText = "SELECT userPassword FROM ValidUsers WHERE userName = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }
    }
}
