using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Quader : GeometrieDreiDiemensionalcs
    {
        public double Seite1 { get; set; }
        public double Seite2 { get; set; }
        public double Seite3    { get; set; }

        public Quader( double seite1, double seite2, double seite3)
        {
            Seite1 = seite1;
            Seite2 = seite2;
            Seite3 = seite3;
        }
        public override double OberFlächenInhalt()
        {
            return 4*(Seite1 * Seite2);
        }
        public override double Volumen()
        {
            return Seite1 * Seite2 * Seite3;
        }
        
}}
