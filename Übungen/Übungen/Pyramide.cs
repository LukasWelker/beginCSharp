using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Pyramide : GeometrieDreiDiemensionalcs
    {
        public double Hoehe { get; set; }
        public double SeitenLänge { get; set; }
        public double HoeheDreieck { get; set; }
        

        public Pyramide(double hoehe, double seitenlänge, double hoeheDreieck)
        {
            Hoehe = hoehe;
            SeitenLänge = seitenlänge;
            HoeheDreieck = hoeheDreieck;
        }
        public override double OberFlächenInhalt()
        {
            return SeitenLänge * SeitenLänge + 2*(SeitenLänge * HoeheDreieck);
        }
        public override double Volumen()
        {
            return 0.3333333333 * Hoehe * SeitenLänge * SeitenLänge;
        }
        
    }
}
