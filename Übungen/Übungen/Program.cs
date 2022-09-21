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
            int[] zahleneinträge = new int[] { 32, 12, 34, 45 };
            int wahresergebnis = SummeAusEinträgen(zahleneinträge);
            Console.WriteLine(wahresergebnis);
            Console.ReadLine();
        }

        static int SummeAusEinträgen(int[] zahleneinträge)
        {
            int ergebnis = 0;
            foreach (int zahleneintrag in zahleneinträge)
            {
                ergebnis = zahleneintrag+ ergebnis;
                
            }
            return ergebnis;
        }
    }
 

}


