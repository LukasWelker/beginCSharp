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
            Console.WriteLine("Hallo bitte schreibe mir einen Text!");
            string text = Console.ReadLine();
        
            String replaced_text = text.PadRight(30, 'y');
            Console.WriteLine(replaced_text);


            
            Console.ReadLine();




        }
    }
}
