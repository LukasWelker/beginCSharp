using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo lieber User wie ist dein Name?");
            string name =  Console.ReadLine();
            while (name == string.Empty)
            {
                Console.WriteLine("Warum ignoriest du mich wie ist dein Name?");
                name = Console.ReadLine();
               
            }
            Console.WriteLine($"Nett dich kennenzulernen {name} !");

            int i = 0;
            int count = 0;
            while (i < name.Count())
            {
                //Überprüfen ob ein a vorhanden ist
                //Kann vielseiteig verwendet werden!
                if (name[i] == 'a')
                {
                    Console.WriteLine("A ist vorhanden");
                    count++;
                }
                i++;
            }
           
            Console.WriteLine($"so oft ist der Buchstabe a in ihrem Namen vorhanden: {count} Mal !");

            Console.WriteLine();

            Console.WriteLine("Gebe mir nun noch bitte 2 Zahlen ein, erstmal nur die erste!");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vielen Dank für die erste Zahl gebe mir nun bitte noch die 2. Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Möchtest du die größere Zahl wissen (y/n)");
            string answer = Console.ReadLine();
            
            while (answer == "y")
                do
                {
                    Console.WriteLine(Math.Max(zahl1, zahl2));
                    break;
                } 
                while (answer == "n");
                {
                Console.WriteLine($"Pech gehabt das ist deine größere Zahl {Math.Max(zahl1, zahl2)}");
                }
                    
               
                
               

            Console.ReadLine();

        }

        

    }

}

