using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BISU_AMS_Desktop.Core;
using System.Data;
using MySql.Data.MySqlClient;
namespace BISU_AMS_Desktop.Dal
{
    public class Students
    {
        public static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }
        public static bool GetStudentsSucessful = false;
        public static string GetStudentsErrorMessage;
        public static DataTable GetStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `students`", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetStudentsSucessful = true;
                        return dt;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetStudentsSucessful = false;
                GetStudentsErrorMessage = ex.Message + "\nFunction : Get Students";
                return null;
            }
        }
    }
}
