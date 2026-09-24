using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_App_With_Database
{
    public class SQL_DB_Manager
    {
        private string connectionString;

        public SQL_DB_Manager(string connection)
        {
            connectionString = connection;
        }

        //Account Creation Function
        public void InsertDataToDb(List<ourUser> users)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    foreach (var user in users)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO ourUser (Email, Username, Password, Status) " +
                            "VALUES (@Email, @Username, @Password, @Status)", cn))
                        {
                            cmd.Parameters.AddWithValue("@Email", user.Email);
                            cmd.Parameters.AddWithValue("@Username", user.Username);
                            cmd.Parameters.AddWithValue("@Password", user.Password);
                            cmd.Parameters.AddWithValue("@Status", user.Status);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        //Function Used for Profile Page to Update User Database Info
        public void UpdateUser(ourUser user)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    //All the info used on the profile page
                        using (SqlCommand cmd = new SqlCommand(
                            "UPDATE ourUser SET " +
                            "email = @Email, " +
                            "password = @Password, " +
                            "firstName = @FirstName, " +
                            "lastName = @LastName, " +
                            "dob = @DOB, " +
                            "phone = @Phone, " +
                            "address = @Address, " +
                            "pronouns = @Pronouns " +
                            "WHERE username = @Username", cn))
                        {
                            cmd.Parameters.AddWithValue("@Email", user.Email);
                            cmd.Parameters.AddWithValue("@Password", user.Password);
                            cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                            cmd.Parameters.AddWithValue("@LastName", user.LastName);
                            cmd.Parameters.AddWithValue("@DOB", user.DOB);
                            cmd.Parameters.AddWithValue("@Phone", user.Phone);
                            cmd.Parameters.AddWithValue("@Address", user.Address);
                            cmd.Parameters.AddWithValue("@Pronouns", user.Pronouns);
                            cmd.Parameters.AddWithValue("@Username", user.Username);

                            cmd.ExecuteNonQuery();
                        }
                    }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        public void UpdateUserApprove(ourUser user)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    //All the info used on the profile page
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE ourUser SET Approved = 1 WHERE username = @Username", cn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Username", user.Username);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        public void UpdateUserDelete(ourUser user)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();
                    //All the info used on the profile page
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM ourUser WHERE username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@Username", user.Username);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        //Status (Role) Function to Open the right Type of User Page using the username
        public String? getStatus(string userName)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT Status FROM ourUser WHERE Username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@username", userName);

                        dr = cmd.ExecuteReader();

                        dr.Read();

                        return dr.GetString(0).TrimEnd();

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
        }

        public String? getFirstName(string userName)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT FirstName FROM ourUser WHERE Username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@username", userName);

                        dr = cmd.ExecuteReader();

                        dr.Read();

                        return dr.GetString(0).TrimEnd();

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
        }

        public String? getName(int id)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT FirstName FROM ourUser WHERE UserID = @UserID", cn))
                    {

                        cmd.Parameters.AddWithValue("@UserID", id);

                        dr = cmd.ExecuteReader();

                        dr.Read();

                        return dr.GetString(0).TrimEnd();

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
        }

        //function to get ALL the user information in an ourUser object in order to use it in other classes - specifically designed to be used in profile pages
        public ourUser? getUser(string userName)
        {
            try
            {
                SqlDataReader dr;
                ourUser user = null;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT * FROM ourUser WHERE Username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@username", userName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user = new ourUser(
                                    reader["Email"].ToString(),
                                    reader["Username"].ToString(),
                                    reader["Password"].ToString(),
                                    reader["Status"].ToString(),
                                    reader["Phone"].ToString(),
                                    reader["Address"].ToString(),
                                    reader["Pronouns"].ToString(),
                                    DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("DOB"))),
                                    reader["FirstName"].ToString(),
                                    reader["LastName"].ToString()
                                );
                            }
                        }

                    }
                }

                return user;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
        }

        //function to make sure the password is correct during login
        public String? getAuthorizedPassword(string userName)
        {

            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT Password FROM ourUser WHERE Username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@username", userName);

                        //cmd.ExecuteNonQuery();

                        dr = cmd.ExecuteReader();

                        dr.Read();

                        return dr.GetString(0).TrimEnd();

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }

        }

        //Function to create a list of users to be stored
        public List<ourUser> LoadDataFromDb()
        {
            List<ourUser> users = new List<ourUser>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ourUser", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ourUser user = new ourUser(
                                reader["Email"].ToString(),
                                reader["Username"].ToString(),
                                reader["Password"].ToString(),
                                reader["Status"].ToString(),
                                reader["Phone"].ToString(),
                                reader["Address"].ToString(),
                                reader["Pronouns"].ToString(),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("DOB"))),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString()
                            );

                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Load Error: " + err.Message);
            }

            return users;
        }

        public List<ourUser> LoadUnapprovedUsers()
        {
            List<ourUser> users = new List<ourUser>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ourUser WHERE Approved = 0", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            ourUser user = new ourUser(
                                reader["Email"].ToString(),
                                reader["Username"].ToString(),
                                reader["Password"].ToString(),
                                reader["Status"].ToString(),
                                reader["Phone"].ToString(),
                                reader["Address"].ToString(),
                                reader["Pronouns"].ToString(),
                                DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("DOB"))),
                                reader["FirstName"].ToString(),
                                reader["LastName"].ToString()
                            );

                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Load Error: " + err.Message);
            }

            return users;
        }

        internal List<Claim> LoadClaims()
        {
            List<Claim> claims = new List<Claim>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT ClaimID, ClaimDate, ClaimType, ClaimStatus, ClaimAmount, UserID, ClaimDescription FROM Claim", cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Claim claim = new Claim(
                                reader.GetInt32(0),
                                reader.GetDateTime(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                Convert.ToInt32(reader.GetDecimal(4)),
                                reader.GetInt32(5),
                                reader.GetString(6)
                                

                            );

                            claims.Add(claim);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Load Error: " + err.Message);
            }

            return claims;
        }
        internal void insertClaim(Claim c)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Claim (ClaimDate, ClaimType, ClaimAmount, ClaimDescription, ClaimStatus, UserID) " +
                        "VALUES (@ClaimDate, @ClaimType, @ClaimAmount, @ClaimDescription, @ClaimStatus, @UserID)", cn))
                    {
                        cmd.Parameters.AddWithValue("@ClaimDate", c.ClaimDate);
                        cmd.Parameters.AddWithValue("@ClaimType", c.ClaimType);
                        cmd.Parameters.AddWithValue("@ClaimAmount", c.ClaimAmount);
                        cmd.Parameters.AddWithValue("@ClaimDescription", c.ClaimDescription);
                        cmd.Parameters.AddWithValue("@ClaimStatus", c.ClaimStatus);
                        cmd.Parameters.AddWithValue("@UserID", c.UserID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        public int getUserID(string userName)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT UserID FROM ourUser WHERE Username = @username", cn))
                    {

                        cmd.Parameters.AddWithValue("@username", userName);

                        dr = cmd.ExecuteReader();

                        dr.Read();

                        return dr.GetInt32(0);

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return -1;
            }

        }

        internal List<Message> LoadMessages(int UserID)
        {
            List<Message> msgs = new List<Message>();

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Message WHERE reciever = @reciever", cn))
                    {
                        cmd.Parameters.AddWithValue("@reciever", UserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {


                            while (reader.Read())
                            {
                                Message msg = new Message(
                                    reader.GetInt32(0),
                                    reader.GetInt32(1),
                                    reader.GetString(2)
                                );

                                msgs.Add(msg);
                            }
                        }
                    }
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Load Error: " + err.Message);
            }

            return msgs;
        }

        internal void insertMessage(Message msg)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Message (reciever, sender, message) " +
                        "VALUES (@reciever, @sender, @message)", cn))
                    {
                        cmd.Parameters.AddWithValue("@reciever", msg.to);
                        cmd.Parameters.AddWithValue("@sender", msg.from);
                        cmd.Parameters.AddWithValue("@message", msg.message);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert Error: " + err.Message);
            }
        }

        public int getIDByName(string firstName)
        {
            try
            {
                SqlDataReader dr;

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                            "SELECT UserID FROM ourUser WHERE firstName = @FirstName", cn))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", firstName);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            return Convert.ToInt32(result);
                        else
                            return -1;

                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning!");

                return -1;
            }

        }


    }
}
