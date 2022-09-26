using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Kreis : Geometrie2
    {
        public int Radius { get; set; }

        public Kreis(int radius)
        {
            Radius = radius;
        }
        public override double Umfang()
        {
            return 2*Math.PI*Radius;
        }
        public override double Flaeche()
        {
            return Math.PI*Radius*Radius;
        }
      
    }
}
