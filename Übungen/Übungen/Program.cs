using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo User wie viele Einträge möchtest du in dein INT-Array machen");
            int Einträge = Convert.ToInt32(Console.ReadLine());
            float[] zahlen = new float [Einträge];
            int i = 0;
            Console.WriteLine("Vielen Dank für die Angabe, ihr Array wurde erstellt");
            
            for (i = 0; i < Einträge; i++)
            {
                Console.WriteLine("Geben sie nun bitte die Fließkommazahlen, die sie hinzufügen möchten");
                zahlen[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Möchten sie nun ihre Einträge in Form einer Liste aufgezählt bekommen (y/n)");
            string answer = Console.ReadLine(); 
            if (answer == "y")
            {
                for (i = 0; i < Einträge; i++)
                {
                    Console.WriteLine(zahlen[i]);
                }

            }
            else
            {
                Console.WriteLine("Pech gehabt");
                for(i = 0; i < Einträge; i++)
                {
                    Console.WriteLine(zahlen[i]);
                }

            }

            Console.ReadLine();

        }

        

    }

}

