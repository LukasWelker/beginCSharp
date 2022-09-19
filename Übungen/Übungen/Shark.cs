using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Shark : Tierarten
    {
        //Konstruktor
        public Shark(string name, int age, double heigt, int lifespan, double weight, bool fiel)
        {
            Name = name;
            Age = age;
            Height = heigt;
            Lifespan = lifespan;
            Weight = weight;
            Fiel = fiel;

        }
        //Override verwendet, dass jedes Tier seine eigenen Eigenschaften besitzen kann.
        public override void Geräusche()
        {
            Console.WriteLine("Der Hai summt monoton in hohen Frequenzen.");
        }
        public override void Essen()
        {
            Console.WriteLine("Der Hai isst alles was im Meer so schwimmt außer Quallen.");
        }
        public override void Trinken()
        {
            Console.WriteLine("Der Hai trinkt nicht er nimmt das Wasser über seine Körperoberfläche auf");
        }
    }
}
