using mediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaTek86.Controller
{
    public class LoginController
    {
        public bool VerifierConnexion(string login, string password)
        {
            return UserDal.CheckLogin(login, password);
        }
    }
}
