using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dreieck1 d = new Dreieck1(2,4, 10);
        

            //datentyp und Name

            Circle c = new Circle(5);
            

            Rechteck r = new Rechteck(10,20);
          
          

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);

            foreach (IGeometry g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} hat eine Fläche von {g.Flaeche()} und den Umfang von {g.Umfang()}");
            }
            List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle(523, "BMW", "GXSR 2000", "3.0", 3000, "Blau",2));
            fahrzeuge.Add(new Cars(123, "VW ", "Golf 5", "2.0 TDI", 1900, "Rot", 4));

            foreach (Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }
            Console.WriteLine("");

            List<Tierarten> tierarten = new List<Tierarten>();
            tierarten.Add(new Penguin("Lilo", 12, 56, 18, 18, true));
            tierarten.Add(new Shark("Nami", 78,200, 280, 237, false));
            tierarten.Add(new owl("Lola", 6, 66, 54, 9, true));

            foreach (Tierarten t in tierarten)
            {
                t.Trinken();
                t.Essen();
                t.Geräusche();
                t.Printinfo();
                Console.WriteLine("");
            }





            Console.ReadLine();

        }

        

    }

}

