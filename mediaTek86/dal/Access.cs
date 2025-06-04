using mediaTek86.bddManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mediaTek86.dal
{
    /// <summary>
    /// Class Access
    /// </summary>
    public class Access
    {
        private static readonly string stringConnect = "Server=localhost;Port=3008;Database=mediatek86;User Id=mediaTek86;Pwd=erwan;";

        /// <summary>
        /// retourne stringConnect
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            return stringConnect;
        }
    }
}
