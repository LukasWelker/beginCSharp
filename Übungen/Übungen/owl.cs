using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class owl : Tierarten
    {
        //Konstruktor
        public owl(string name, int age, double heigt, int lifespan, double weight, bool fiel)
        {
            Name = name;
            Age = age;
            Height = heigt;
            Lifespan = lifespan;
            Weight = weight;
            Fiel = fiel;
        }
        //Override überschreibt die abstract Methode
        public override void Geräusche()
        {
            Console.WriteLine("Die Eule macht GURRRGURR");
        }
        public override void Essen()
        {
            Console.WriteLine("Die Eule isst gerne Mäuse. ");
        }
        public override void Trinken()
        {
            Console.WriteLine("Die Eule trinkt, wie wir Menschen Süßwasser");
        }
    }

}
