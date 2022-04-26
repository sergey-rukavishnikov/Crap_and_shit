using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    internal class Message : Records
    {
        static string Type;
        public string Text { get; set; }

        public Message(DateTime _date, string _text)
        {
            ID = GetNextID();
            Record_Date = _date;
            Text = _text;
        }
        static Message() => Type = "Message";

        public override string ToString()
        {
            return ID + ". " + Record_Date + " " + Text;
        }
    }
}
