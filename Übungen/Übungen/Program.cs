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
            Console.WriteLine("Hallo bitte schreibe mir einen Text mit Leerzeichen vor und nach dem Text!");
            string text = Console.ReadLine() ;
            string trimmed_text = text.Trim(' ');
            Console.WriteLine(trimmed_text);
            


            
            Console.ReadLine();




        }
    }
}
