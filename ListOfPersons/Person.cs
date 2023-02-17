using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPersons
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateBirth { get; set; }

        public Person() : this(string.Empty, string.Empty, new DateTime()) { }

        public Person(string firstName, string lastName, DateTime age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = string.Empty;
            DateBirth = age;
        }

        public Person(string firstName, string lastName, DateTime age, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateBirth = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string ToFullString()
        {
            string message = $"{FirstName} {LastName}\n";
            message += $"Gender: {Gender}\nDate of birth: {DateBirth}\n";
            return message;
        }

        public void Preview()
        {
            MessageBox.Show(this.ToFullString(), "Preview");
        }
    }
}
