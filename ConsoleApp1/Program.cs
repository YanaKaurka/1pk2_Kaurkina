namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public enum PatientCondition
    {
        Satisfactory, // Удовлетворительное
        Moderate,     // Средней тяжести
        Severe        // Тяжелое
    }

    class Program
    {
        static void Main()
        {

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Moderate,
                DateTime.Today,
                "Головная боль",
                "Мигрень",
                "Обезболивающее"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Severe,
                DateTime.Today,
                "Температура",
                "Пневмония",
                "Антибиотики в уколах"
            ));

            AdmissionDepartment.AddPatient(new Patient(
                PatientCondition.Satisfactory,
                DateTime.Today.AddDays(3),
                "Кашель",
                "ОРВИ лёгкая форма",
                "Таблетки: Стрепсилс"
            ));


            AdmissionDepartment.PrintAll();
            Console.WriteLine();
            AdmissionDepartment.PrintByCondition();
            Console.WriteLine();
            AdmissionDepartment.PrintByAdmissionDate(DateTime.Today.AddDays(3));
            Console.WriteLine();
            AdmissionDepartment.PrintByAdmissionDate(DateTime.Today);
            Console.WriteLine();

            AdmissionDepartment.DischargePatient(0, DateTime.Today);
            AdmissionDepartment.PrintDischarged();
        }
    }
}

