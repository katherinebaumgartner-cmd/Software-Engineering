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
    public partial class messageForm : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public messageForm(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
            string? firstName = objManager.getFirstName(username);
            txtInboxName.Text = firstName;
        }

        //send button
        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = txtTo.Text;
            int to = objManager.getIDByName(firstname);
            int from = objManager.getUserID(username);
            string message = txtBody.Text;

            Message msg = new Message(to, from, message);
            objManager.insertMessage(msg);

            txtBody.Clear();
            txtTo.Clear();

        }

        private void messageForm_Load(object sender, EventArgs e)
        {
            lstMessages.Items.Clear();
            List<Message> msgs = new List<Message>();
            int id = objManager.getUserID(username);
            msgs = objManager.LoadMessages(id);
            if (msgs != null)
            {
                lstMessages.Items.AddRange(msgs.ToArray());
            }
            else
            {
                lstMessages.Items.Add("No Messages");
            }
        }

        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Message msg = (Message)lstMessages.SelectedItem;
                txtFrom.Clear();
                txtMessage.Clear();

                if (lstMessages.SelectedIndex == -1)
                {
                    return;
                }

                txtFrom.Text = msg.getName();
                txtMessage.Text = msg.message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
        //static string connectionString = "C:\\Users\\labuser\\source\\repos\\SE361_GitHub_Demo_Login_App\\UsersDatabase.mdf";
        //static SqlConnection db = new SqlConnection("C: \Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf");




    }
}
