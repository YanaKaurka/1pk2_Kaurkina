using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Patient
    {
        public PatientCondition Condition; //состояние
        public DateTime AdmissionDate;//дата записи
        public DateTime? DischargeDate; //дата выписки
        public string Complaints;//жалобы
        public string Diagnosis;//диагноз
        public string Treatment;//леч.врач

        public Patient(PatientCondition condition, DateTime admissionDate,
                      string complaints, string diagnosis, string treatment)
        {
            Condition = condition;
            AdmissionDate = admissionDate;
            Complaints = complaints;
            Diagnosis = diagnosis;
            Treatment = treatment;
        }
    }
}
