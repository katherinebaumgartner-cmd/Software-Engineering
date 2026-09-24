using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class ClaimApplicationForm : Form
    {
        private string username { get; set; }
        private SQL_DB_Manager objManager;

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public ClaimApplicationForm(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
        }

        private void btnFileClaim_Click(object sender, EventArgs e)
        {
            string type = ClaimType.Text;
            string date = textBox2.Text;
            string desc = textBox1.Text;
            int ID = objManager.getUserID(username);

            DateTime incident = DateTime.Parse(date);

            Claim claim = new Claim(incident, type, desc, ID);
            objManager.insertClaim(claim);

            textBox1.Clear();
            textBox2.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Welcome_Form welcomeAfterClaim = new(username);

            welcomeAfterClaim.Show();
        }
    }
}
