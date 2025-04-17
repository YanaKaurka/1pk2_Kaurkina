using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class AdmissionDepartment
    {
        public static List<Patient> Patients = new List<Patient>();

        public static void AddPatient(Patient patient) => Patients.Add(patient);

        public static void PrintAll()
        {
            Console.WriteLine("Все пациенты:");
            foreach (var p in Patients)
                Console.WriteLine($"Имя: {p.LastName},\n Диагноз: {p.Diagnosis},\n Состояние: {p.Condition}, \n лечение: {p.Treatment} \n");
        }

        public static void PrintByCondition()
        {
            Console.WriteLine("Пациенты по состоянию:");
            foreach (var p in Patients)
            {
                Console.ForegroundColor = p.Condition == PatientCondition.Satisfactory ? ConsoleColor.Green :
                                        p.Condition == PatientCondition.Moderate ? ConsoleColor.Yellow : ConsoleColor.Red;
                Console.WriteLine($"{p.LastName}: {p.Diagnosis}");
                Console.ResetColor();
            }
        }

        public static void SaveToXml(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Patient>));
            using var writer = new StreamWriter(fileName);
            serializer.Serialize(writer, Patients);
        }

        public static void LoadFromXml(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Patient>));
            using var reader = new StreamReader(fileName);
            Patients = (List<Patient>)serializer.Deserialize(reader);
        }
    }

}
