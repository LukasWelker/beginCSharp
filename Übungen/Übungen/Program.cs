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

            Console.WriteLine("Wir Spielen ein Fizz-Buzz-Spiel zwischen den Zahlen 1 bis 100!");
            for (int i = 0; i < 101; i--)
            {
                if (i % 3==0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                 else if (i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else 
                { 
                        
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadLine();
        }
    }
}
