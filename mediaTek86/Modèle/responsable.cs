using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Modèle
{
    public class responsable
    {
        public int IdResponsable { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdService { get; set; }

        public responsable(int idResponsable, string nom, string prenom, int idService)
        {
            IdResponsable = idResponsable;
            Nom = nom;
            Prenom = prenom;
            IdService = idService;
        }
    }
}
