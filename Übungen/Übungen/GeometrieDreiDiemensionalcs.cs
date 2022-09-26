using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public abstract  class GeometrieDreiDiemensionalcs
    {
        public abstract double OberFlächenInhalt();
        public abstract double Volumen();
        public override string ToString()
        {
            return $"Dein {this.GetType().Name} hat den Oberflächeninhalt {OberFlächenInhalt()} FE und das Volumen {Volumen()} VE";
        }
    }
}
