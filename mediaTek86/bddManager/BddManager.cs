using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using mediaTek86.bddManager;


namespace mediaTek86.bddManager
{
    /// <summary>
    /// BddManager
    /// </summary>
    public class BddManager
    {

        private MySqlConnection connection;

        /// <summary>
        /// Constructeur pour ouvrir la connexion
        /// </summary>
        /// <param name="stringConnect">Chaîne de connexion</param>
        public BddManager(string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
                Console.WriteLine("Connexion réussie !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur de connexion : {ex.Message}");
            }
        }

        /// <summary>
        /// Ferme la connexion proprement
        /// </summary>
        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Connexion fermée !");
            }
        }

        /// <summary>
        /// Retourne StringConnect de BddManager
        /// </summary>
        /// <param name="stringConnect"></param>
        /// <returns></returns>
        public static BddManager GetInstance(string stringConnect)
        {
            return new BddManager(stringConnect);
        }

        /// <summary>
        /// ReqUpdate
        /// </summary>
        /// <param name="stringQuery"></param>
        /// <param name="parameters"></param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand(stringQuery, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                        }
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur dans ReqUpdate : {ex.Message}");
            }
        }

        /// <summary>
        /// ReqSelect
        /// </summary>
        /// <param name="stringQuery"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<object[]> ReqSelect(string stringQuery, Dictionary<string, object> parameters = null)
        {
            List<object[]> records = new List<object[]>();

            try
            {
                using (MySqlCommand command = new MySqlCommand(stringQuery, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new MySqlParameter(param.Key, param.Value));
                        }
                    }

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int nbCols = reader.FieldCount;
                        while (reader.Read())
                        {
                            object[] row = new object[nbCols];
                            reader.GetValues(row);
                            records.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur dans ReqSelect : {ex.Message}");
            }

            return records;
        }



    }
    
}

