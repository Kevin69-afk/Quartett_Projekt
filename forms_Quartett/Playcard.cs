using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_Quartett
{
    internal class Playcard
    {//Eigenschaften der Karten 
        public string name;
        public int ps;
        public int kmh;
        public int speed;
        public int value;
        public int weight;
        public int baujahr;
        public int cardIndex;

        public Playcard(string name, int ps, int kmh, int speed, int value, int weight, int baujahr, int cardIndex) // Erstellung des Konstruktors
        {
            this.name = name;
            this.ps = ps;
            this.kmh = kmh;
            this.speed = speed;
            this.value = value;
            this.weight = weight;
            this.baujahr = baujahr;
            this.cardIndex = cardIndex;
        }
    }
}
