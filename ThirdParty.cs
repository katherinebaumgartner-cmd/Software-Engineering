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
    public partial class ThirdParty : Form
    {
        private string _username;
        public ThirdParty()
        {
            InitializeComponent();
        }
      
        public ThirdParty(string username, string role)
        {
            InitializeComponent();
            _username = username;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            Close();
            FinManHome clientHomeAfterLogin = new FinManHome(_username);

            clientHomeAfterLogin.Show();
        }

        private void sendpayment_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
            
        }
    }
}
