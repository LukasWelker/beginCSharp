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
            
           foreach (float x in zahlen)
            {
                Console.WriteLine(x);
            }
            
            Console.ReadLine();

        }

        

    }

}

