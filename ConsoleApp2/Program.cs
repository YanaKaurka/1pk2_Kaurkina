using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp2
{
    /*Создать перечисление для состояния пациента (удовлетворительное
средней тяжести, тяжелое)
Создать класс пациента (состояние, дата поступления, дата выписки (на начало создания объекта пустая), жалобы, диагноз, назначенное лечение)
Создать список пациентов. Заполнить его программно через специальный метод-генератор


Создать статичный класс приёмного отделения со статичными методами для:
1. Добавления нового пациента
2. Изменения состояния пациента
3. Выписки пациента
4. Вывода всех пациентов отделения
5. Вывод пациентов отделения по тяжести состояния (с цветовой идентификацией для разных состояний)
6. Вывод пациентов, поступивших на конкретную дату
7. Вывод пациентов, выписанных из отделения
*/
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