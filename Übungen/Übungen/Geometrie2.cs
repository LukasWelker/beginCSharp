using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public abstract class Geometrie2
    {
        public abstract double Umfang();
        public abstract double Flaeche();
        public override string ToString()
        {
            return $"Mein {this.GetType().Name} hat den Umfang {Umfang()} cm und die Flaeche {Flaeche()} FE";
        }
    }
}
