using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_App_With_Database
{
    public class ourUser
    {

        //automatic properties
        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public string Status { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateOnly DOB { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Pronouns { get; set; }


        //cosntructor
        //All Attributes
        public ourUser(string email, string username, string password, string status, string phone, string address, string pronouns, DateOnly DOB, string firstname, string lastname)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Status = status;
            this.Phone = phone;
            this.Address = address;
            this.Pronouns = pronouns;
            this.DOB = DOB;
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        
        //Profile Page Attributes
        public ourUser(string email, string username, string password, string phone, string address, string pronouns, DateOnly DOB, string firstname, string lastname)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Phone = phone;
            this.Address = address;
            this.Pronouns = pronouns;
            this.DOB = DOB;
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        //Account Creation Info
        public ourUser(string email, string username, string password, string status)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Status = status;
        }

        public override string ToString()
        {
            return string.Format("Username: {0}, First Name: {1}, Last Name: {2}, Role: {3}", Username, FirstName, LastName, Status);
        }

        

    }
}
