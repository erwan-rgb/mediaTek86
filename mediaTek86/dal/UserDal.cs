using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.dal
{
    public class UserDal
    {
        public static bool CheckLogin(string login, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Access.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM utilisateur WHERE login = @login AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur SQL : {ex.Message}");
                return false;
            }
        }
    }
}
