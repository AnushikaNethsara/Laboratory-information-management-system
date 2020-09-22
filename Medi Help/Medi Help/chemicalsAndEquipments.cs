using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class chemicalsAndEquipments
    {
        private string date;
        private string name;
        private string price;
        private string quantity;
        private string reference;
        private string user;

        public chemicalsAndEquipments(string date, string name, string price, string quantity,string user,string reference)
        {
            this.Date = date;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Reference = reference;
            this.User = user;
        }

        public string Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Reference { get => reference; set => reference = value; }
        public string User { get => user; set => user = value; }
    }
}
