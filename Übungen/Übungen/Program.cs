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
            Console.WriteLine("Schreibe mir einen schönen Text mit möglichst vielen g,G und u,U Buchstaben!");
                string text = Console.ReadLine();
            string replaced_text = text.Replace('U', 'G').Replace('u', 'g');
            Console.WriteLine("Vielen Dank für den Text");
            Console.WriteLine("Der alte Text war " + text);
            Console.WriteLine("Und der neue Text ist " + replaced_text);    





            Console.ReadLine();




        }
    }
}
