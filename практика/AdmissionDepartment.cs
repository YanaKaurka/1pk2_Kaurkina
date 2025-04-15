using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика
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
                Console.WriteLine($"Диагноз: {p.Diagnosis}, состояние: {p.Condition}");
        }

        public static void PrintByCondition()
        {
            Console.WriteLine("Пациенты по состоянию:");
            foreach (var p in Patients)
            {
                Console.WriteLine($"Диагноз: {p.Diagnosis} ({p.Condition})");
                Console.ResetColor();
            }
        }

        public static void PrintByAdmissionDate(DateTime date)
        {
            Console.WriteLine($"Пациенты за {date:d}:");
            foreach (var p in Patients)
                if (p.AdmissionDate.Date == date.Date)
                    Console.WriteLine($"Дианоз: {p.Diagnosis}");
        }

        public static void PrintDischarged()
        {
            Console.WriteLine("Выписанные:");
            foreach (var p in Patients)
                if (p.DischargeDate.HasValue)
                    Console.WriteLine($"Диагноз: {p.Diagnosis}");
        }
        public static void PrintByCondition()
        {
            Console.WriteLine("Пациенты по состоянию:");
            foreach (var p in Patients)
            {
                Console.ForegroundColor = p.Condition switch
                {
                    PatientCondition.Satisfactory => ConsoleColor.Green,
                    PatientCondition.Moderate => ConsoleColor.Yellow,
                    _ => ConsoleColor.Red
                };
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

    class Program
    {
        static void Main()
        {
            // Добавляем 3 тестовых пациента
            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Moderate,
                DateTime.Today,
                "Головная боль",
                "Мигрень",
                "Обезболивающее"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Severe,
                DateTime.Today.AddDays(-1),
                "Температура",
                "Пневмония",
                "Антибиотики"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Satisfactory,
                DateTime.Today,
                "Кашель",
                "ОРВИ",
                "Сироп"
            ));

            // Тестируем методы
            AdmissionDepartment.PrintAll();
            Console.WriteLine();
            AdmissionDepartment.PrintByCondition();
            Console.WriteLine();
            AdmissionDepartment.PrintByAdmissionDate(DateTime.Today);
            Console.WriteLine();

            AdmissionDepartment.DischargePatient(0, DateTime.Today);
            AdmissionDepartment.PrintDischarged();
        }
    }
}

}
