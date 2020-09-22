using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medi_Help
{
    class global
    {
        public static string UserID;

        public static string rPatientName;
        public static string rReportname;
        public static string rDob;
        public static string rGender;

        public struct reportStruct
        {
            public string stReportNumber;
            public string stTest;
            public string stRequiredDate;
            public string price;
        };

        public static string[] equipmentList = new string[] { "Autoclaves", "Blood gas analyzers",
                    "Chemistry analyzers", "DNA analyzers", "Differential counters", "Gamma counters",
                    "Hematology analyzers", "Histology and cytology equipment","Hotplates","Immunoassay analyzers",
                    "Incubators","Microplate readers/washers","Microscopes","Point of care analyzers",
                    "Urinalysis analyzers"};

        public static string[] chemicaltList = new string[] { "Acetic acid",
                                                        "Ammonium reagent/Stone","Antibody test kits","Antigens",
                                                        "Antiserums","Buffers",
                                                        "Calibrators","Chloride","Diluents",
                                                         "Enzyme tracers","Ethanol",
                                                        "Extraction enzymes","Fixatives",
                                                        "Hormones",
                                                        "Immunoelectrophoresis reagents",
                                                        "Immu-sal",
                                                        "Liquid substrate con","Phenobarbital reagent",
                                                        "Phenytoin reagent","Potassium hydroxide","Rabbit serum","Shigella bacteria",
                                                        "Sodium hypochlorite",
                                                        "Stains",
                                                        "Standards","Sulfuric acid","Thimerosal","Urine analysis reagents","Wash solutions" };


        public static ArrayList reportDetailList = new ArrayList();
    }
}
