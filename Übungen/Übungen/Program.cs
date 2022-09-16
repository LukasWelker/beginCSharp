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


            Console.WriteLine("Wir holen uns jetzt eine Zahl aus Number()");

            int zahl1 = 5;
            int zahl2 = 120;
            int ergebnis = Add(zahl1, zahl2);
            Console.WriteLine(ergebnis);

            Console.ReadLine();
            
        }
        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }







        //static Rückgabetyp MethodenName (Parameter)
        static List <string> Number()
        { 
            List<string> name = new List<string>();
            name.Add("ABC");
            //Rückgabevariabel
            return name;
            
        }
    }

}
