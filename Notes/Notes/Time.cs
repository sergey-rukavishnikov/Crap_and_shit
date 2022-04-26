using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Time
    {
        public DateTime time { get; set; }
        public Time()
        {
            time = DateTime.Now;
        }
        public virtual void print()
        {
            Console.Write($"[{time.ToString()}] ");
        }
    }
}
