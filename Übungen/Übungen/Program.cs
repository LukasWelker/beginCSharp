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
            Console.WriteLine("Nenne mir eine Zahl bis maximal 20");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int new_sum = 0;
            for(int i = 0; i < Zahl1; i++)
            {
                new_sum = sum + i ; 
                Console.WriteLine(sum);
                Console.WriteLine(sum + "+" + i + " = " + new_sum);
                sum = new_sum;
            }

            Console.ReadLine();
        }
    }
}
