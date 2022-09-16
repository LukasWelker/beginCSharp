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
            //Array hat Platz für 5 Werte
            int[] zahlen = new int[5];

            //Array [26/ 8 /12 / 3 / 6]
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6};

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Gebe mir eine Zahle für das Array");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }
          

            Console.ReadLine();
        }
    }
}
