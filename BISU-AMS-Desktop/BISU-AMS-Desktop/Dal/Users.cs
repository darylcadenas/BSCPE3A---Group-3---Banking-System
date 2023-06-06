using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BISU_AMS_Desktop.Core;
using System.Data;
using MySql.Data.MySqlClient;
namespace BISU_AMS_Desktop.Dal
{
    public class Users
    {
        public static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        //LOGGING IN
        public static bool GetLoginSucessful = false;
        public static string GetLoginErrorMessage;
        public static DataTable GetLogin(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = '" + username + "' AND  password = PASSWORD('" + password + "');", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetLoginSucessful = true;
                        return dt;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetLoginSucessful = false;
                GetLoginErrorMessage = ex.Message + "\nFunction : Get Login";
                return null;
            }
        }

        //GETTING USER LIST
        public static bool GetUserSucessful = false;
        public static string GetUserErrorMessage;
        public static DataTable GetUser()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, username, fullname, users.privileges FROM users;", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetUserSucessful = true;
                        return dt;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetUserSucessful = false;
                GetUserErrorMessage = ex.Message + "\nFunction : Get User";
                return null;
            }
        }

        //SAVING USER
        public static bool SaveUserSucessful = false;
        public static string SaveUserErrorMessage;
        public static void SaveUser(string username, string password, string fullName, string privileges, string mode)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    if (mode == "Add")
                        cmd = new MySqlCommand("INSERT INTO `users`(username, password, fullname, users.privileges) VALUES('" + username + "', PASSWORD('" + password + "'),'" + fullName + "','" + privileges + "');", con);
                    else
                        cmd = new MySqlCommand("UPDATE `users` SET password = PASSWORD('" + password + "'), users.privileges = '" + privileges + "' WHERE username = '" + username + "' AND fullname = '" + fullName + "';", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SaveUserSucessful = true;
                }
            }
            catch (Exception ex) { SaveUserSucessful = false; SaveUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add/Edit Users"; }
        }

        //DELETING USER
        public static bool DeleteUserSucessful = false;
        public static string DeleteUserErrorMessage;
        public static void DeleteUser(string username, string fullname)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("DELETE FROM `users` WHERE username = '" + username + "' AND fullname = '" + fullname + "';", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteUserSucessful = true;
                }
            }
            catch (Exception ex) { DeleteUserSucessful = false; DeleteUserErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Delete User"; }
        }
    }
}
