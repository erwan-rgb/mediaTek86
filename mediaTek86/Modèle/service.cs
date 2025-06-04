using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Modèle
{
    /// <summary>
    /// Service
    /// </summary>
    public class service
    {
        public int IdService { get; set; }
        public string NomService { get; set; }

        public service(int idService, string nomService)
        {
            IdService = idService;
            NomService = nomService;
        }
    }
}
