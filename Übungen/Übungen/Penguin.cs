using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Penguin : Tierarten
    {
        public Penguin(string name, int age, double heigt, int lifespan, double weight, bool fiel)
        {
            Name = name;
            Age = age;
            Height = heigt;
            Lifespan = lifespan;
            Weight = weight;
            Fiel = fiel;
        }
        public override void Geräusche()
        {
            Console.WriteLine("Der Pinguin macht *quiek*.");
        }
        public override void Essen()
        {
            Console.WriteLine("Der Pinguin isst gerne Fisch.");
        }
        public override void Trinken()
        {
            Console.WriteLine("Die Pinguine trinken auf zwei verschiedene Art und Weisen Einerseits trinken sie Meerwasser " +
                "und andererseits trinken sie geschmolzenen Schnee oder trinken auch direkt Süßwasser.");
        }
    }
}
