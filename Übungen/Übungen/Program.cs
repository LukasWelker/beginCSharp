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
                Console.WriteLine(t.ToString());
                Console.WriteLine("");
            }





            Console.ReadLine();

        }

        

    }

}

