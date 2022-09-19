using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    //Klasse implementiert IGemoetry --> Alle im Interface definierten Methoden müssen vorhanden/implementiert sein
    public interface IGeometry
    {
        float Flaeche();
        float Umfang();
    }
    
    
}
