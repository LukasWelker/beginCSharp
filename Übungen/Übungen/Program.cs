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
            Console.ReadLine();
        }
    }
}
