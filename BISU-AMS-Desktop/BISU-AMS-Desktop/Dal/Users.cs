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
    }
}
