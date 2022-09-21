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
            Console.WriteLine("Hallo, geb mir bitte deine erste Zahl an!");
            float zahl1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Vielen Dank geb mir nun bitte deine zweite Zahl an!");
            float zahl2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Jetzt fehlt nur noch der Rechenoperator!");
            string operators = Console.ReadLine();
            float result = 0;
            switch (operators)
            {
                case "+":
                    result = Add(zahl1, zahl2);
                    break;
                case "-":
                    result = Subtrahieren(zahl1, zahl2);
                    break;
                case "/":
                    result = Division(zahl1, zahl2);
                    break;
                case "*":
                    result = Multiply(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Parameter gibt es nicht!");
                    break;


            }
            Console.WriteLine($"Das Ergebnis ist {result}");
            Console.ReadLine();
        }



            static float Add(float zahl1, float zahl2)
            {
                float ergebnis = zahl1 + zahl2;
                return ergebnis;
            }
            static float Subtrahieren(float zahl1, float zahl2)
            {
                float ergebnis = zahl1 - zahl2;
                return ergebnis;
            }
            static float Multiply(float zahl1, float zahl2)
            {
                float ergebnis = zahl1 * zahl2;
                return ergebnis;
            }
            static float Division(float zahl1, float zahl2)
            {
                float ergebnis = zahl1 / zahl2;
                return ergebnis;
            }
        }


    }


