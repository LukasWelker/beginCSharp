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
            Console.WriteLine("Schreibe mir bitte einen Text");
            string text = Console.ReadLine();
            bool contains = text.Contains("abc");
            if (contains == true)
            {
                Console.WriteLine("Ist vorhanden");
            }
            else
            {
                Console.WriteLine("ist nicht vorhanden");
            }
            Console.ReadLine();
        }
    }
}
