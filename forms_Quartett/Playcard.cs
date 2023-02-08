using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_Quartett
{
    internal class Playcard
    {
        public string name;
        public int ps;
        public int kmh;
        public int speed;
        public int value;
        public int weight;
        public int baujahr;

        public Playcard(string name, int ps, int kmh, int speed, int value, int weight, int baujahr)
        {
            this.name = name;
            this.ps = ps;
            this.kmh = kmh;
            this.speed = speed;
            this.value = value;
            this.weight = weight;
            this.baujahr = baujahr;
        }
    }
}
