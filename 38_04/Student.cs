using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_04
{
    using System;

    namespace StudentDataApp
    {
        [Serializable]
        public class Student
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string Group { get; set; }
            public Gender Gender { get; set; }
            public DateTime BirthDate { get; set; }

            public override string ToString()
            {
                return $"{LastName} {FirstName} {MiddleName}, {Group}, {Gender}, {BirthDate:dd.MM.yyyy}";
            }
        }

        [Serializable]
        public enum Gender
        {
            Male,
            Female,
            Other
        }
    }
}
