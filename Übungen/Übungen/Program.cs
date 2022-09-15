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
            Console.WriteLine("Hallo bitte schreibe mir einen Text mit Semikolons!");
            string text = Console.ReadLine();
            string[] split_text = text.Split(';');

            for (int i = 0; i < split_text.Length; i++)
            {
                Console.WriteLine(split_text[i]);
            }

            Console.ReadLine();
        }
    }
}
