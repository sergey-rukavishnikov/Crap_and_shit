using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Records
    {
        private static int currentID;

        protected int ID { get; set; }
        protected DateTime Record_Date { get; set; }


        public Records()
        {
            ID = 0;
            Record_Date = DateTime.MinValue;
        }

        public Records(DateTime _date)
        {
            this.ID = GetNextID();
            this.Record_Date = _date;
        }

        static Records() => currentID = 0;

        protected int GetNextID() => ++currentID;

        public void Print ()
        {
            Console.WriteLine(ID + " " + Record_Date);
        }

    }
}
