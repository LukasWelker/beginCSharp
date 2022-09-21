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
            string zahltext1 = "34";
            string zahltext2 = "45";
            int ergebins = AddierteZahlen(zahltext1, zahltext2);
            Console.WriteLine(ergebins);
            Console.ReadLine();
        }

        static int AddierteZahlen(string zahltext1, string zahltext2)
        {
           int zahl1 = Convert.ToInt32(zahltext1);
           int zahl2 = Convert.ToInt32(zahltext2);
            int sum = zahl1 + zahl2;
            return sum;
            
        }
    }
   

}


