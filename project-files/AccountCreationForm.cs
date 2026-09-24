using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class AccountCreationForm : Form
    {
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";

        public AccountCreationForm()
        {
            InitializeComponent();
            objManager = new SQL_DB_Manager(connectionstring);
        }

        //function to use all user input info to create a new account
        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string roles = roleSelect.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(email) |
                    string.IsNullOrWhiteSpace(username) |
                    string.IsNullOrWhiteSpace(password) |
                    string.IsNullOrWhiteSpace(roles))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                ourUser newUser = new ourUser(email, username, password, roles);

                List<ourUser> tempList = new List<ourUser> { newUser };

                objManager.InsertDataToDb(tempList);

                MessageBox.Show("Account created successfully!");

                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                roleSelect.SelectedIndex = -1;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Login_Form loginAfterCreation = new();

            loginAfterCreation.Show();
        }

        
    }
}
