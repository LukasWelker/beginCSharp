using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    //Klasse implementiert IGemoetry --> Alle im Interface definierten Methoden müssen vorhanden/implementiert sein
    public class Rechteck : IGeometry
    {
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }
        
        //Konstruktor
        public Rechteck(int seite1, int seite2)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            
        }
        public float Flaeche()
        {
            return Seite1 * Seite2;
        }
        public float Umfang()
        {
            return 2 * (Seite1 + Seite2);
        }
    }
}
