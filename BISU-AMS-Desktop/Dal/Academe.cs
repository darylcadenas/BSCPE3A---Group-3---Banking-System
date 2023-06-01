using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BISU_AMS_Desktop.Core;
using System.Data;
using MySql.Data.MySqlClient;
namespace BISU_AMS_Desktop.Dal
{
    public class Academe
    {
        public static string ConnectionString()
        {
            return PublicVariables.ServerConnectionString;
        }

        public static bool GetDepartmentSucessful = false;
        public static string GetDepartmentErrorMessage;
        public static DataTable GetDepartment()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `department`", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetDepartmentSucessful = true;
                        return dt;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetDepartmentSucessful = false;
                GetDepartmentErrorMessage = ex.Message + "\nFunction : Get Department";
                return null;
            }
        }

        public static bool GetCourseSucessful = false;
        public static string GetCourseErrorMessage;
        public static DataTable GetCourse(int DepartmentId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `course` WHERE department_id = " + DepartmentId + ";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        GetCourseSucessful = true;
                        return dt;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                GetCourseSucessful = false;
                GetCourseErrorMessage = ex.Message + "\nFunction : Get Course";
                return null;
            }
        }
        //insert/update
        public static bool SaveDepartmentSucessful = false;
        public static string SaveDepartmentErrorMessage;
        public static void SaveDepartment(int DepartmentId, string DepartmentName, string departmentAbb, string mode)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    if(mode == "Add")
                        cmd = new MySqlCommand("INSERT INTO `department`(name,abbreviation,added_by) VALUES('" + DepartmentName + "','" + departmentAbb + "'," + PublicVariables.UserId + ");", con);
                    else
                        cmd = new MySqlCommand("UPDATE `department` SET name = '" +DepartmentName + "', abbreviation = '" + departmentAbb + "' WHERE id = " + DepartmentId +";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SaveDepartmentSucessful = true;
                }
            }
            catch (Exception ex) { SaveDepartmentSucessful = false; SaveDepartmentErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add/Edit Department"; }
        }
        //delete
        public static bool DeleteDepartmentSucessful = false;
        public static string DeleteDepartmentErrorMessage;
        public static void DeleteDepartment(int DepartmentId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("DELETE FROM `department` WHERE id = " + DepartmentId +";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteDepartmentSucessful = true;
                }
            }
            catch (Exception ex) { DeleteDepartmentSucessful = false; DeleteDepartmentErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Delete Department"; }
        }

        //COURSE ADDING ---->
        //insert/update
        public static bool SaveCourseSucessful = false;
        public static string SaveCourseErrorMessage;
        public static void SaveCourse(int DepartmentId,int course_id, string CourseName, string CourseAbb, string mode)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    if (mode == "Add")
                        cmd = new MySqlCommand("INSERT INTO `course`(name,abbreviation,department_id,added_by) VALUES('" + CourseName + "','" + CourseAbb + "'," + DepartmentId + "," + PublicVariables.UserId + ");", con);
                    else
                        cmd = new MySqlCommand("UPDATE `course` SET name = '" + CourseName + "', abbreviation = '" + CourseName + "' WHERE id = " + course_id + ";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    SaveCourseSucessful = true;
                }
            }
            catch (Exception ex) { SaveCourseSucessful = false; SaveCourseErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Add/Edit Course"; }
        }
        //delete
        public static bool DeleteCourseSucessful = false;
        public static string DeleteCourseErrorMessage;
        public static void DeleteCourse(int CourseId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString()))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd = new MySqlCommand("DELETE FROM `course` WHERE id = " + CourseId + ";", con);
                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new MySqlParameter("_latest_status_id", _latest_status_id));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DeleteCourseSucessful = true;
                }
            }
            catch (Exception ex) { DeleteCourseSucessful = false; DeleteCourseErrorMessage = "ERROR!\n" + ex.Message + "\nFunction : Delete Course"; }
        }
    }
}
