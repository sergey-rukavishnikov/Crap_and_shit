using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Car:Time
    {
        public Car() : base()
        {
            Mark = "Mark";
        }
        public Car(string mark, int year)
        {
            Mark = mark;
            Year = year;
        }
        private string _mark;
        private int _year;
        public string Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (String.Compare(value, "0") >= 0)
                {
                    _mark = value;
                }
                else
                {
                    _mark = "Word";
                }
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value > 1900)
                {
                    _year = value;
                }
                else
                {
                    _year = 1900;
                }
            }
        }
    }
}
