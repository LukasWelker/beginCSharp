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

            Console.WriteLine("Wie viele Einträge möchtest du in deinem Array eintragen?");
            int user_entries = Convert.ToInt32(Console.ReadLine());
            int[] zahlen = new int[user_entries];

            //Startvariable/Laufzeit/Zählvariable
            for (int i = 0; i < user_entries; i++)
            {
                Console.WriteLine("Gebe mir die erste Zahl deines Arrays an!");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }


            //Variante 1: Läufst arraay durch, hast eine Hilfsvariable int max = 0; Bei jedem durchlauf wird max überprüftob größer als aktulle zahl
            int max = 0;
            int min = zahlen[0];
            double sum = 0;
            for(int i = 0; i< zahlen.Length; i++)
            {
                if(max < zahlen[i])
                {
                    max = zahlen[i];
                }
                if (min > zahlen[i]) 
                {
                    min = zahlen[i];
                }
                sum = sum + zahlen[i];
            }
            double avg = sum / zahlen.Length;
            Console.WriteLine(avg);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
