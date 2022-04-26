using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class Message:Time
    {
        public Message() : base()
        {
            Words = "Word";
        }
        private string _words;
        public string Words
        {
            get { return _words; }
            set
            {
                if (String.Compare(value, "0") >= 0)
                {
                    _words = value;
                }
                else
                {
                    _words = "Word";
                }
            }
        }
        
        public Message(string _Words)
        {
            Words = _Words;
        }
        public override void print()
        {
            base.print();
            Console.Write($"[Message] {Words}");
        }
    }
}
