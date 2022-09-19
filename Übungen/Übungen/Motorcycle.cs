using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Motorcycle :Vehicle
    {
    public Motorcycle(int typeId, string make, string model, string typename, int ccm, string color, int tyres)
        {
            //Übergabeparameter
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typename;
            CCM = ccm;
            Color = color;
            Tyres = tyres;
        }
    }
}
