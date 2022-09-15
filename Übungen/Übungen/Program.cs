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
            Console.WriteLine("Nenne mir die Namen der Azubis!");
            string AzubiNamen = Console.ReadLine();
            string[] split_AzubiNamen = AzubiNamen.Split(',');
            Console.WriteLine("Nach welchem Buchstaben möchtest du suchen?");
            string Buchstabe = Console.ReadLine();
            for(int i = 0; i < split_AzubiNamen.Length; i++)
            {
                if (split_AzubiNamen[i].Contains(Buchstabe))
                {
                    Console.WriteLine(split_AzubiNamen[i]);
                }
                
            }
           

           Console.ReadLine();
        }
    }
}
