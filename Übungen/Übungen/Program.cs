using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("Gebe mir Zhal 1");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe mir eine Zahl2");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int ergebnis = AddierteZahlen(zahl1, zahl2);
            Console.WriteLine(ergebnis);
            Console.ReadLine();
            
        }

        static int AddierteZahlen(int zahl1, int zahl2)
        {
            int sum = zahl1 + zahl2;
            return sum;
        }
    }
   

}


