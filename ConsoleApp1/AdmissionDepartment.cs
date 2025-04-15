using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class AdmissionDepartment
    {
        public static List<Patient> Patients = new List<Patient>();

        public static void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public static void UpdateCondition(int index, PatientCondition newCondition)
        {
            if (index >= 0 && index < Patients.Count)
                Patients[index].Condition = newCondition;
        }

        public static void DischargePatient(int index, DateTime dischargeDate)
        {
            if (index >= 0 && index < Patients.Count)
                Patients[index].DischargeDate = dischargeDate;
        }

        public static void PrintAll()
        {
            Console.WriteLine("Все пациенты:");
            foreach (var p in Patients)
                Console.WriteLine($"- {p.Diagnosis}, состояние: {p.Condition}");
        }

        public static void PrintByCondition()
        {
            Console.WriteLine("Пациенты по состоянию:");
            foreach (var p in Patients)
            {
                Console.WriteLine($"- {p.Diagnosis} ({p.Condition})");
                Console.ResetColor();
            }
        }

        public static void PrintByAdmissionDate(DateTime date)
        {
            Console.WriteLine($"Пациенты за {date:d}:");
            foreach (var p in Patients)
                if (p.AdmissionDate.Date == date.Date)
                    Console.WriteLine($"- {p.Diagnosis}");
        }

        public static void PrintDischarged()
        {
            Console.WriteLine("Выписанные:");
            foreach (var p in Patients)
                if (p.DischargeDate.HasValue)
                    Console.WriteLine($"- {p.Diagnosis}");
        }
    }
}
