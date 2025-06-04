using mediaTek86.dal;
using mediaTek86.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Controller
{
    public class AbsenceController
    {
        public List<Absence> GetAbsences()
        {
            return AbsenceDal.GetAllAbsences();
        }

        public bool AjouterAbsence(Absence absence)
        {
            return AbsenceDal.InsertAbsence(absence);
        }
    }
}
