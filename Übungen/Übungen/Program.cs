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

            string zahl = Console.ReadLine();

           

            switch (zahl)
            {
                case "1":
                    Console.WriteLine("Die Zahl ist 1");
                    break;
                case "2":
                    Console.WriteLine("Die Zahl ist 2");
                    break ;
                case "5": Console.WriteLine("Die Zahl ist 5");
                    break;
                default:
                    Console.WriteLine("Kein Fall tritt ein");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
