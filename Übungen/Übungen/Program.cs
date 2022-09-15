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
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.ReadLine();
        }
    }
}
