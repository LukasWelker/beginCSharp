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
            Console.WriteLine("Wir bauen nun einen Taschenrechner gib mir nun deine erste Zahlen an");

            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vielen Dank, jetzt fehlt nur noch die zweite");
            double zahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Danke!");
            Console.WriteLine("Jetzt fehlr nur noch welche Recheoperation durchgeführt werden soll!");
            string rechenoperation = Console.ReadLine();
            double result  = 0;  
            switch (rechenoperation)
            {
                case "+":
                    result = zahl1 + zahl2;
                    break;
                case "-":
                   result = zahl1 - zahl2;
                    break;
                case "/":
                     result = zahl1 / zahl2;
                    break;
                case "*":
                    result = zahl1 * zahl2;
                    break;

            }

            Console.WriteLine(zahl1 + rechenoperation + zahl2 + "=" + result);

            Console.ReadLine();
        }
    }
}
