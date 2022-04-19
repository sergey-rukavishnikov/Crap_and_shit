using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    internal class Human
    {

        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                if (String.Compare(value, "0") >= 0)
                    _FirstName = value;
                else
                    _FirstName = "FirstName";
            }
        }
        private string _FirstName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                if (String.Compare(value, "0")! < 0)
                    _LastName = value;
                else _LastName = "LastName";
            }
        }
        private String _LastName;

        
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1900 && value < 2018)
                    _year = value;
                else
                    _year = 1900;
            }

        }
        private int _year;

        public int Month
        {
            private get
            {
                return _Month;
            }
            set
            {
                if (value > 1 && value < 12)
                    _Month = value;
                else _Month = 1;
            }

        }
        private int _Month;
        public int Day
        {
            private get
            {
                return _Day;
            }
            set
            {
                if (value > 1 && value < 31)
                    _Day = value;
                else _Day = 1;
            }

        }
        private int _Day;

 
        public Human()
        {
            FirstName = "FirstName";
            LastName = "LastName";
            Year = 1900;
            Month = 1;
            Day = 1;
           
        }
        public Human(string firstName, string lastName, int yaer, int month, int day)
        {
            FirstName = firstName;
            LastName = lastName;
     
            Year = yaer;
            Month = month;
            Day = day;
          
        }

        public string GetFullName()
        {
            return $"FirstName LastName";
        }
        public int GetAge()
        {
            DateTime dateTime = DateTime.Now;
            int curyear = (int)dateTime.Year;
            int curmonth = (int)dateTime.Month;
            int curday = (int)dateTime.Day;

            if (curday > Day)
                curmonth++;
            if (curmonth > Month)
                curyear++;

            return curyear - Year;

        }
    }
}
