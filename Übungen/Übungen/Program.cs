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
            Random r = new Random();
            int random_zahl = r.Next(0, 100);
            Console.WriteLine("Wähle eine Zahl zwischen 0 und 100");

            int number = Convert.ToInt32(Console.ReadLine());
            {
                for (int i = 0; i < 10; i++)
                {
                    if (random_zahl < number)
                    {
                        Console.WriteLine("Die Zahl ist kleiner");
                    }

                    else if (random_zahl > number)

                    {
                        Console.WriteLine("Die Zahl ist größer");
                    }
                    else
                    {
                        Console.WriteLine("You won!");
                    }
                    number = Convert.ToInt32(Console.ReadLine());
                }

            }



            Console.WriteLine();



        }
    }
}
