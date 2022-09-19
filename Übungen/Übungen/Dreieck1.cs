using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    //Klasse implementiert IGemoetry --> Alle im Interface definierten Methoden müssen vorhanden/implementiert sein
    public class Dreieck1 : IGeometry
    {
        public int Seite1 { get; set; }
        public int Seite2 { get; set; }
        //Hypotenuse
        public int Seite3 { get; set; }

        //Konstruktor
        public Dreieck1(int seite1, int seite2, int seite3)
        {
            this.Seite1 = seite1;
            this.Seite2 = seite2;
            this.Seite3 = seite3;
        }




    public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }

        public float Flaeche()
        {
            return 2;
        }
    }

}
