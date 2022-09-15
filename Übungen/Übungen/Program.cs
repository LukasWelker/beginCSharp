using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welche zwei Zahlen möchtest du addieren?. Wähle jetzt deine erste Zahl.");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Das ist deine erste Zahl. Was ist deine 2.Zahl");
            int Zahl2 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(Zahl1 + Zahl2);
            Console.ReadLine();


        }
    }
}
