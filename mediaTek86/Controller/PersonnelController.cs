using mediaTek86.dal;
using mediaTek86.Modèle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Controller
{
    /// <summary>
    /// contrôle personnel
    /// </summary>
    public class PersonnelController
    {
        public List<Personnel> GetPersonnels()
        {
            return PersonnelDal.GetAllPersonnels();
        }

        public bool AjouterPersonnel(Personnel personnel)
        {
            return PersonnelDal.InsertPersonnel(personnel);
        }
    }
}
