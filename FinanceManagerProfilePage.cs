using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class FinanceManagerProfilePage : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public FinanceManagerProfilePage(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
        }

        private void FinanceManagerProfilePage_Load(object sender, EventArgs e)
        {
            EmailTxtBox.Text = user.Email;
            txtDOB.Text = user.DOB.ToString();
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            PronounsTxt.Text = user.Pronouns;
            PhoneTxtBox.Text = user.Phone;
            txtAddress.Text = user.Address;
            txtPassword.Text = user.Password;
        }

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
            FinanceManagerProfilePage_Load(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            FinManHome FinHomeAfterLogin = new FinManHome(username);

            FinHomeAfterLogin.Show();
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
