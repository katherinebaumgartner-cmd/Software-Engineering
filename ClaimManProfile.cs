using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class ClaimManProfile : Form
    {
        
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public ClaimManProfile(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Close();
            ClaimManPage ClaimManPageAfterLogin = new ClaimManPage(username);

            ClaimManPageAfterLogin.Show();
        }

        private void FinanceManagerProfilePage_Load(object sender, EventArgs e)
        {
            clientEmailtxt.Text = user.Email;
            txtClientDOB.Text = user.DOB.ToString();
            txtClientFirst.Text = user.FirstName;
            txtClientLast.Text = user.LastName;
            txtClientPronouns.Text = user.Pronouns;
            clientPhoneNumtxt.Text = user.Phone;
            txtClientAddress.Text = user.Address;
            txtClientPassword.Text = user.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = clientEmailtxt.Text;
            string firstname = txtClientFirst.Text;
            string lastname = txtClientLast.Text;
            string phonenum = clientPhoneNumtxt.Text;
            string pronouns = txtClientPronouns.Text;
            string date = txtClientDOB.Text;
            string address = txtClientAddress.Text;
            string password = txtClientPassword.Text;

            //string date to dateTime
            DateTime DT = DateTime.Parse(date);
            DateOnly DOB = DateOnly.FromDateTime(DT);
            ourUser temp = new ourUser(email, username, password, phonenum, address, pronouns, DOB, firstname, lastname);

            objManager.UpdateUser(temp);

            user = objManager.getUser(username);
            FinanceManagerProfilePage_Load(sender, e);
        }

        private void ClaimManProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
