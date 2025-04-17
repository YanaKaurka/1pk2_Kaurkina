using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp2
{
    public enum PatientCondition { Satisfactory, Moderate, Severe }
    class Program
    {
        static void Main()
        {
            // Добавление пациентов
            AdmissionDepartment.AddPatient(new Patient
            {
                LastName = "Иванов",
                Condition = PatientCondition.Moderate,
                AdmissionDate = DateTime.Today,
                Diagnosis = "Мигрень",
                Treatment = "Валерьянка"

            });

            AdmissionDepartment.AddPatient(new Patient
            {
                LastName = "Петров",
                Condition = PatientCondition.Severe,
                AdmissionDate = DateTime.Today.AddDays(-1),
                Diagnosis = "Пневмония",
                Treatment = "Антибиотики"
            });
            AdmissionDepartment.AddPatient(new Patient
            {
                LastName = "Коваленко",
                Condition = PatientCondition.Severe,
                AdmissionDate = DateTime.Today.AddDays(-1),
                Diagnosis = "Усталость",
                Treatment = "Здоровый сон"
            });

            // Вывод информации
            AdmissionDepartment.PrintAll();
            Console.WriteLine();
            AdmissionDepartment.PrintByCondition();

            // Работа с файлами
            const string file = "patients.xml";
            AdmissionDepartment.SaveToXml(file);
            AdmissionDepartment.Patients.Clear();
            AdmissionDepartment.LoadFromXml(file);
        }
    }
}