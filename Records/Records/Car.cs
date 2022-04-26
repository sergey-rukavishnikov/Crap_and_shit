using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    internal class Car : Records
    {
        static string Type;

        public string Car_Name { get; set; }
        public int Car_Year { get; set; }

        public Car(DateTime _date, string _car_name, int _car_year)
        {
            this.ID = GetNextID();
            this.Record_Date = _date;
            this.Car_Name = _car_name;
            this.Car_Year = _car_year;
        }
        static Car() => Type = "Car";

        public override string ToString()
        {
            return ID + ". " + Record_Date + " " + Car_Name + ", " + Car_Year;
        }
    }
}
