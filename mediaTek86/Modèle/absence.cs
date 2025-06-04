using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Modèle
{
    public class absence
    {
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }

        public absence(int idAbsence, int idPersonnel, DateTime dateDebut, DateTime dateFin, string motif)
        {
            IdAbsence = idAbsence;
            IdPersonnel = idPersonnel;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Motif = motif;
        }
    }
}
