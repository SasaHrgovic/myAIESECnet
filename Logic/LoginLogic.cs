using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginLogic
    {
        private void SetToSession()
        {
            Session.userId = 1;
            Session.committeeId = 1;
            Session.roleId = 2;
        }

        public bool Login(string email, string password)
        {
            SetToSession();
            return true;
        }
    }
}
