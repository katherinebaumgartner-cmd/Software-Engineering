using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login_App_With_Database
{
    public partial class FinManProfile : Form
    {
        private string _username;
        public FinManProfile()
        {
            InitializeComponent();
        }
        public FinManProfile(string username)
        {
            InitializeComponent();
            _username = username;
        }


        private void backbttn_Click(object sender, EventArgs e)
        {
            Close();
            FinManHome FinManHomeAfterLogin = new FinManHome(_username);

            FinManHomeAfterLogin.Show();

        }
        
    }
}
