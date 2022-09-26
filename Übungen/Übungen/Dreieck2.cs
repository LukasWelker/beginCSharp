using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Dreieck2 :Geometrie2
    {
        public double Hoehe { get; set; }
        public double Grundseite { get; set; }
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }
        public double Seite3 { get; set; }


        public Dreieck2(double hoehe, double grundseite, double seite1, double seite2, double seite3)
        {
            Hoehe = hoehe;
            Grundseite = grundseite;
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }

        public override double Flaeche()
        {
            return 0.5 * Hoehe * Grundseite;
        }
        public override double Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }
        
    }

    
}
