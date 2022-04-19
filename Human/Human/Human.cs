using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Human
    {
        public Human (string _name, string _surname, string _fullName ,int _year, int _month, int _day)
        {
            Name = _name;
            Surname = _surname;
            FullName = _name + " " + _surname;
            Year = _year;
            Month = _month;
            Day = _day;
            Age = 
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public int Age { get; set; }

        public string FullName { get; set; }

        public void SetName (string Name)
        {
            if (Name == null)
                Name = "Чел";
        }

        public void SetSurname(string Surname)
        {
            if (Surname == null)
                Surname = "овек";
        }

        public void SetYear (int Year)
        {
            if (Year < 1900)
                Year = 1900;
            if (Year > 2018)
                Year = 2018;
        }

        public void SetMonth(int Month)
        {
            if (Month < 1)
                Month = 1;
            if (Month > 12)
                Month = 12;
        }

        public void SetDay(int Day)
        {
            if (Day < 1)
                Day = 1;
            if (Day > 31)
                Day = 31;
        }



    }
}
