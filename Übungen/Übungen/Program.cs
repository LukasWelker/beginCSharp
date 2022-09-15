using System;
using System.Collections.Generic;
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
            string entry = Console.ReadLine(); 
            string replaced_entry = entry.PadLeft(20, 'y');
            Console.WriteLine(replaced_entry);


            
            Console.ReadLine();




        }
    }
}
