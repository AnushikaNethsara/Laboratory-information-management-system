using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class employee
    {
        private string eNic;
        private string name;
        private string email;
        private string employeeType;
        private string dob;
        private int phone;
        private string userName;
        private string password;
        private byte[] photo;

        public employee(string eNic, string name, string dob,string email, int phone, string employeeType,  string userName, string password, byte[] photo)
        {
            this.ENic = eNic;
            this.Name = name;
            this.Dob = dob;
            this.Email = email;
            this.phone = phone;
            this.EmployeeType = employeeType;
            this.UserName = userName;
            this.Password = password;
            this.Photo = photo;
        }

        public string ENic { get => eNic; set => eNic = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
        public string Dob { get => dob; set => dob = value; }
        public int Phone { get => phone; set => phone = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public byte[] Photo { get => photo; set => photo = value; }
    }
}
