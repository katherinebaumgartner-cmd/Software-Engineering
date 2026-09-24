using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class AdminProfile : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public AdminProfile(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            AdminHome adminHomeAfterLogin = new AdminHome(username);

            adminHomeAfterLogin.Show();
        }

        //function to take all of users changed info and overwrite it in the database
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            EmailTxtBox.Text = user.Email;
            txtDOB.Text = user.DOB.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            PronounsTxt.Text = user.Pronouns;
            PhoneTxtBox.Text = user.Phone;
            txtAddress.Text = user.Address;
            txtPassword.Text = user.Password;
            //continue with the rest of textbox on client profile page 
        }

        //save button function
        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailTxtBox.Text;
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string phonenum = PhoneTxtBox.Text;
            string pronouns = PronounsTxt.Text;
            string date = txtDOB.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;

            //string date to dateTime
            DateTime DT = DateTime.Parse(date);
            DateOnly DOB = DateOnly.FromDateTime(DT);
            ourUser temp = new ourUser(email, username, password, phonenum, address, pronouns, DOB, firstname, lastname);

            objManager.UpdateUser(temp);

            user = objManager.getUser(username);
            AdminProfile_Load(sender, e);

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
