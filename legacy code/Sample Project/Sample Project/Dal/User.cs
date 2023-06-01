using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample_Project.Core;
using MySql.Data.MySqlClient;
using System.Data;
namespace Sample_Project.Dal
{
    public class User
    {
        public static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }
        public static string GetUserDataError = string.Empty;
        public static bool GetUserDataSuccessful = false;
        public static DataTable GetLogin(string Username, string Password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `username` = '" + Username + "' && `password` = PASSWORD('" + Password + "');", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetUserDataSuccessful = true;
                        return dt;
                    }
                    else
                     return null;
                    
                }
            }
            catch (Exception ex)
            {
                GetUserDataSuccessful = false;
                GetUserDataError = ex.Message + "\n Function:  Login";
                return null;
            }
        }

        public static string GetListError = string.Empty;
        public static bool GetListSuccessful = false;
        public static DataTable GetList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users`", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    GetListSuccessful = true;
                        return dt;

                }
            }
            catch (Exception ex)
            {
                GetListSuccessful = false;
                GetListError = ex.Message + "\n Function:  Login";
                return null;
            }
        }

        //add
        public static bool AddUserSuccessful = false;
        public static string AddUserErrorMessage;
        public static void AddUser(string username, string password, string fullname)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    //MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(username,`password`,fullname) VALUES('" + username + "','" + password + "','" + fullname +"');", con);
                    MySqlCommand cmd = new MySqlCommand("sp_users_add", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("_username", username));
                    cmd.Parameters.Add(new MySqlParameter("_password", password));
                    cmd.Parameters.Add(new MySqlParameter("_fullname", fullname));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AddUserSuccessful = true;
                }
            }
            catch (Exception ex) { AddUserSuccessful = false; AddUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add User"; }
        }

        //edit
        public static bool EditUserSuccessful = false;
        public static string EditUserrErrorMessage;
        public static void EditUser(string username, string password, string fullname, string userId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `users`SET username = '" + username + "', password = '" + password + "',fullname = '" + fullname + "' WHERE id = " + userId + ";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_po_no", pr_no));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    EditUserSuccessful = true;
                }
            }
            catch (Exception ex) { EditUserSuccessful = false; EditUserrErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Edit User"; }
        }
        //delete
        public static bool DeleteUserSuccessful = false;
        public static string DeleteUserErrorMessage;
        public static void DeleteUser(string userId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = " + userId + ";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_po_no", pr_no));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteUserSuccessful = true;
                }
            }
            catch (Exception ex) { DeleteUserSuccessful = false; DeleteUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Delete User"; }
        }
    }
}
