using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Rechteck2 :Geometrie2
    {
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }

        public Rechteck2(double seite1, double seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
        }

        public override double Flaeche()
        {
            return Seite1 * Seite2;
        }
        public  override double Umfang()
        {
            return 2 * (Seite2 + Seite1);
        }
        
    }
    
}
