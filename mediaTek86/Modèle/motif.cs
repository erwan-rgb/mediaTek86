using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Modèle
{
    /// <summary>
    /// Motif
    /// </summary>
    public class motif
    {
        public int IdMotif { get; set; }
        public string Description { get; set; }

        public motif(int idMotif, string description)
        {
            IdMotif = idMotif;
            Description = description;
        }
    }
}
