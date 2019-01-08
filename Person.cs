using System;

namespace App1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private DateTime _birthdate;

        private DateTime Birthdate
        {
            get => _birthdate;
            set => _birthdate = new DateTime(value.Year, _birthdate.Month, _birthdate.Day);
        }

        protected Person()
        {
            Name = "John";
            Surname = "Doe";
            Birthdate = DateTime.UnixEpoch;
        }

        protected Person(string name, string surname, DateTime birthdate)
        {
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine($"{Name} {Surname} was born on {Birthdate.Day}/{Birthdate.Month}/{Birthdate.Year}");
        }

        public int GetAge()
        {
            var now = DateTime.Now;
            int hadNoBirthday;
            if (now.Month >= Birthdate.Month && now.Day >= Birthdate.Day) hadNoBirthday = 0;
            else hadNoBirthday = 1;
            return now.Year - Birthdate.Year - hadNoBirthday;
        }
    }
}