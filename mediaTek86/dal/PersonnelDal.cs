using mediaTek86.Modèle;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.dal
{
    public class PersonnelDal
    {
        public static List<Personnel> GetAllPersonnels()
        {
            List<Personnel> listePersonnel = new List<Personnel>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Access.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT * FROM personnel";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listePersonnel.Add(new Personnel
                            {
                                IdPersonnel = reader.GetInt32("idPersonnel"),
                                Nom = reader.GetString("nom"),
                                Prenom = reader.GetString("prenom")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur SQL : {ex.Message}");
            }

            return listePersonnel;
        }

        public static bool InsertPersonnel(Personnel personnel)
        {
            throw new NotImplementedException();
        }
    }
}
