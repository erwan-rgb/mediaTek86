using mediaTek86.bddManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediaTek86.dal;



namespace mediaTek86.dal
{
    /// <summary>
    /// Class DataAccess
    /// </summary>
    public class DataAccess
    {
        private readonly BddManager db;

        /// <summary>
        /// Accéder à Access
        /// </summary>
        public DataAccess()
        {
            db = BddManager.GetInstance(Access.GetConnectionString());
        }

        /// <summary>
        /// ExecuteSelect
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public List<object[]> ExecuteSelect(string query, Dictionary<string, object> parameters = null)
        {
            return db.ReqSelect(query, parameters);
        }

        /// <summary>
        /// ExecuteUpdate
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        public void ExecuteUpdate(string query, Dictionary<string, object> parameters = null)
        {
            db.ReqUpdate(query, parameters);
        }
    }
}
