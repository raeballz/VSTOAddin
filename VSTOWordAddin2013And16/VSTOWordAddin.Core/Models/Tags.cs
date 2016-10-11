using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTOWordAddin.Core.Models
{
    public class Tags
    {
        public const string MOBILENO = "[[PATIENTMOBILENUMBER]]";
        public const string EMAIL = "[[PATIENTEMAILADDRESS]]";
        public const string PHONENO = "[[PATIENTPHONENUMBER]]";
        public const string ADDRESS = "[[PATIENTFULLADDRESS]]"; 
        public const string POSTCODE = "[[PATIENTPOSTCODE]]";
        public const string SURNAME = "[[PATIENTSURNAME]]";
        public const string FORENAME = "[[PATIENTFIRSTNAME]]";
        public const string AGE = "[[PATIENTAGE]]";
        public const string DOB = "[[PATIENTDOB]]";
        //public const string MIDDLENAMES = "[[PATIENTMIDDLENAME]]";

        private List<string> allTags;

        public Tags()
        {
            this.AllTags = new List<string>()
            {
                MOBILENO,
                EMAIL,
                PHONENO,
                ADDRESS,
                POSTCODE,
                SURNAME,
                FORENAME,
                AGE,
                DOB
            };
        }

        public List<string> AllTags
        {
            get { return allTags; }
            set { allTags = value; }
        }
    }
}
