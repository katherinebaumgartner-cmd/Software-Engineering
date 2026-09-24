using System;
using System.Collections.Generic;
using System.Text;

namespace Login_App_With_Database
{
    internal class Message
    {
        public int to { get; set; }
        public int from { get; set; }
        public string message { get; set; }

        const string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\labuser\source\repos\SE361_GitHub_Demo_Login_App\UsersDatabase.mdf";
        public Message(int to, int from, string message)
        {
            this.to = to;
            this.from = from;
            this.message = message;
        }

        public string getName()
        {
            SQL_DB_Manager objManager = new SQL_DB_Manager(connectionstring);

            return objManager.getName(from);
        }

        public override string ToString()
        {
            return "Message From: " + getName();
        }
    }
}
