using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class report
    {

        private string patientNic;
        private string reportNumber;
        private string reportName;
        private string finishedDate;
        private string requiredDate;

        public report(string patientNic, string reportNumber,  string reportName, string requiredDate)
        {
            this.PatientNic = patientNic;
            this.ReportNumber = reportNumber;
            this.ReportName = reportName;
            this.RequiredDate = requiredDate;
        }

        public string PatientNic { get => patientNic; set => patientNic = value; }
        public string ReportNumber { get => reportNumber; set => reportNumber = value; }
        public string ReportName { get => reportName; set => reportName = value; }
        public string FinishedDate { get => finishedDate; set => finishedDate = value; }
        public string RequiredDate { get => requiredDate; set => requiredDate = value; }
    }
}
