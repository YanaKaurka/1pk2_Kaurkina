using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Patient
    {
        public string LastName;
        public PatientCondition Condition;
        public DateTime AdmissionDate;
        public DateTime? DischargeDate;
        public string Complaints;
        public string Diagnosis;
        public string Treatment;
    }

}
