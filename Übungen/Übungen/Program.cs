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


            Console.WriteLine("Wähle deine erste Zahl");

            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vielen Dank, nun fehlt noch die zweite Zahl!");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("jetzt fehlt noch der Rechenoperator!");
            string operators = Console.ReadLine();
            int result = 0;
            switch (operators)
            {
                case "+":
                    result = Add(zahl1, zahl2);
                    break; 
                case "-":
                    result = subtrahieren(zahl1, zahl2);
                    break;
                case "/":
                    result = division(zahl1, zahl2);
                    break;
                case "*":
                    result = multiply(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Parameter gibt es nicht!");
                    break;


            }
            Console.WriteLine($"Dein Ergebnis ist {result}");
            Console.ReadLine();    
            
        }
        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }
        static int multiply(int z1, int z2)
        {
            int summe = z1 * z2;
            return summe;
        }
        static int division(int z1, int z2)
        {
            int summe = z1 / z2;
            return summe;
        }
        static int subtrahieren(int z1, int z2)
        {
            int summe = z1 - z2;
            return summe;

        }
        
    }

}
