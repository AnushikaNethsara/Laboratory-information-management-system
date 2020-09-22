using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class bill
    {
        private string billNo;
        private string timeDate;
        private string requiredDate;
        private string description;
        private double total;
        private string Enic;
        private string patientnic;
        private string patientName;
        private string patientAddress;
        private string patientGender;
        private string patientDob;
        private int patientContact;



        public bill(string billNo, string timeDate, string requiredDate, string Enic, string patientnic, double total, string description)
        {
            this.BillNo = billNo;
            this.TimeDate = timeDate;
            this.RequiredDate = requiredDate;
            this.Enic1 = Enic;
            this.Patientnic = patientnic;
            this.total = total;
            this.description = description;

        }

        public bill(string patientnic, string patientName,string patientDob, string patientGender,string patientAddress, int patientContact)
        {
            this.Patientnic = patientnic;
            this.PatientName = patientName;
            this.patientDob = patientDob;
            this.PatientGender = patientGender;
            this.patientAddress = patientAddress;
            this.PatientContact = patientContact;
        }

        public string BillNo { get => billNo; set => billNo = value; }
        public string TimeDate { get => timeDate; set => timeDate = value; }
        public string RequiredDate { get => requiredDate; set => requiredDate = value; }
        public string Description { get => description; set => description = value; }
        public double Total { get => total; set => total = value; }
        public string Enic1 { get => Enic; set => Enic = value; }
        public string Patientnic { get => patientnic; set => patientnic = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientAddress { get => patientAddress; set => patientAddress = value; }
        public string PatientGender { get => patientGender; set => patientGender = value; }
        public string PatientDob { get => patientDob; set => patientDob = value; }
        public int PatientContact { get => patientContact; set => patientContact = value; }

    }
}
