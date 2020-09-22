using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class login
    {
        private string userName;
        private string password;
        

        public login(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
