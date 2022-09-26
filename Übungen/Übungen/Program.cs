using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kreis k = new Kreis(4);

            Rechteck2 r = new Rechteck2(5, 4);

            Quadrat q = new Quadrat(4, 4);
            Dreieck2 dr = new Dreieck2(4, 2, 3, 3, 2);

            Quader qu = new Quader(4, 5, 4);
            Pyramide p = new Pyramide(6, 5, 4.5);

            List <Geometrie2> geometries2 = new List<Geometrie2>() { r, q, k, dr};
           

            List<GeometrieDreiDiemensionalcs> geometriesDreiDimensional = new List<GeometrieDreiDiemensionalcs>() { qu, p};
            

            foreach (Geometrie2 g in geometries2)
            {
                Console.WriteLine(g.ToString()); 
            }
            Console.WriteLine(" ");
            foreach (GeometrieDreiDiemensionalcs g in geometriesDreiDimensional)
            {
                Console.WriteLine(g.ToString());
            }
            Console.ReadLine();
        }
    }


}





 



