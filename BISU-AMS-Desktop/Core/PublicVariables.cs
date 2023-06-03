using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BISU_AMS_Desktop.Core
{
    public class PublicVariables
    {
        public static string ServerConnectionString = "Server = localhost; Database = ams; Uid = system_admin; Pwd = system_admin; Port = 3306;";

        #region User Credentials

        /// <summary>
        /// Software username : the one that pass login
        /// </summary>
        public static string UserName { get; set; }

        /// <summary>
        /// Current User Id
        /// </summary>
        public static int UserId { get; set; }

        /// <summary>
        /// Current User Password
        /// </summary>
        public static string UserPassword { get; set; }

        public static DataTable UsersData { get; set; }

        #endregion
    }
}
