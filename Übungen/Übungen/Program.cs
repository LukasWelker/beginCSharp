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
            for (int i = Zahl1; i >=0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

           
        }
    }
}
