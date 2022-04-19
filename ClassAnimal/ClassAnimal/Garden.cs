using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    internal class Garden
    {
        public double Size { get; set; }
        public string Whose { get; set; }
        public bool Planted { get; set; }
        public bool Matured { get; set; }
        public Garden()
        {
            Size = 100;
            Whose = "Mine";
            Planted = false;
            Matured = false;
        }
        public Garden(double size, string whose, bool  planted)
        {
            Size=size;
            Whose = whose;
            Planted = planted;
        }
        public bool harvest()
        {
            if (!Planted) {
                Planted = true;
                Matured = true;
            }
            return Matured;
        }
    }
    
}
