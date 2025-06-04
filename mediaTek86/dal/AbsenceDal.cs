using mediaTek86.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.dal
{
    public class AbsenceDal
    {
        public static bool AjouterAbsence(int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Access.GetConnectionString()))
                {
                    conn.Open();
                    string query = "INSERT INTO absence (idPersonnel, dateDebut, dateFin, motif) VALUES (@idPersonnel, @dateDebut, @dateFin, @motif)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPersonnel", idPersonnel);
                        cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
                        cmd.Parameters.AddWithValue("@dateFin", dateFin);
                        cmd.Parameters.AddWithValue("@motif", motif);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur SQL : {ex.Message}");
                return false;
            }
        }

        public static List<Absence> GetAllAbsences()
        {
            throw new NotImplementedException();
        }

        public static bool InsertAbsence(Absence absence)
        {
            throw new NotImplementedException();
        }
    }
}
