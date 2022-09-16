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
            Console.WriteLine("Wie viele Namen möchtest du zu deiner Liste hinzufügen?");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vielen Dank!");
            Console.WriteLine($"Nenne mir nun die {eingabe} , die du zu deiner Liste hinzufügen möchtest!");
           List<string> name = new List<string>();
     
            for (int i = 0; i < eingabe; i++)
            {
                name.Add(Console.ReadLine());
            }
            for     (int i = 0; i < eingabe; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.ReadLine();
        }
    }
}
