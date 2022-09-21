using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objekt ertsellt alles was mit new gekenzeichnet ist ist ein Objekt
            Cars2 Auto = new Cars2(1234, "BMW","M4", "M", "Schwarz",2);
            //so ruf´t man seine Klasse auf
            Auto.BeschleunigungUm(120);
            Auto.BremsenUm(120);
            Console.WriteLine(Auto.ToString());
            Auto.Lackierung();
            Console.WriteLine(Auto.ToString());
            Console.ReadLine();
            Auto.Bremsen();
        }
        


    }
}


