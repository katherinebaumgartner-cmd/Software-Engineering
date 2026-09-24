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
    public partial class ApproveAcct : Form
    {
        private string username { get; set; }
        private ourUser user { get; set; }
        private SQL_DB_Manager objManager;
        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public ApproveAcct(string username)
        {
            InitializeComponent();
            this.username = username;
            objManager = new SQL_DB_Manager(connectionstring);
            user = objManager.getUser(username);
        }

        private void ApproveBttn_Click(object sender, EventArgs e)
        {
            ourUser user = (ourUser)AccountList.SelectedItem;
            objManager.UpdateUserApprove(user);

            ApproveAccout_Load(sender, e);
        }

        private void declinebttn_Click(object sender, EventArgs e)
        {
            ourUser user = (ourUser)AccountList.SelectedItem;
            objManager.UpdateUserDelete(user);

            ApproveAccout_Load(sender, e);
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Close();
            AdminHome adminHomeAfterLogin = new AdminHome(username);

            adminHomeAfterLogin.Show();
        } 

        private void ApproveAccout_Load(object sender, EventArgs e)
        {
            AccountList.Items.Clear();
            List<ourUser> users = new List<ourUser>();
            users = objManager.LoadUnapprovedUsers();
            if (users != null)
            {
                AccountList.Items.AddRange(users.ToArray());
            }
            else
            {
                AccountList.Items.Add("No Users");
            }
        }


    }
}

