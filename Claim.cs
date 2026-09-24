using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Login_App_With_Database
{
    internal class Claim
    {
        public int Id { get; set; }
        public DateTime ClaimDate;
        public string ClaimType;
        public string ClaimStatus;
        public int ClaimAmount;
        public int ClaimID;
        public int UserID;
        public string ClaimDescription;

        public Claim(DateTime ClaimDate, string ClaimDescription, string ClaimType, int UserID)
        {
            this.ClaimDate = ClaimDate;
            this.ClaimType = ClaimType;
            this.ClaimAmount = 0;
            this.ClaimStatus = "Under Review";
            this.ClaimDescription = ClaimDescription;
            this.UserID = UserID;
        }

        public Claim(int id, DateTime ClaimDate, string ClaimType, string ClaimStatus, int ClaimAmount, int UserID, string ClaimDescription)
        {
            this.Id = id;
            this.ClaimDate = ClaimDate;
            this.ClaimType = ClaimType;
            this.ClaimStatus = ClaimStatus;
            this.ClaimAmount = ClaimAmount;
            this.UserID = UserID;
            this.ClaimDescription = ClaimDescription;
        }

        public override string ToString()
        {
            string id = ClaimID.ToString();
            return "Claim ID: " + id; 
        }


    }
}
