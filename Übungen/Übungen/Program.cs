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
            //Aufgabe 1
            List<int> numbers = new List<int>() { 5, 3, 7 };
            
            //Aufgabe2
                numbers.Add(1);
          
            //Aufgabe 3
            while (true) 
            { 

                Console.WriteLine("Gib mir eine Zahl");
                string eingabe2 = Console.ReadLine();
                if (eingabe2 == string.Empty)
                {
                    break;
                }
                int eingabe = Convert.ToInt32(eingabe2);

                numbers.Add(eingabe);
            }

            //Aufgabe 4
            for (int i = 0; i < numbers.Count; i++)
            {
                //Eckige Klamme, um den Inhalt meiner Liste zu zeigen
                Console.WriteLine(numbers[i]);
            }
                
            //Aufgabe 5
            numbers.Insert(1, 99);

            //Aufgabe 6
            numbers.AddRange(new List<int>() { 92, 93, 94});


            //Aufgabe7
            numbers.RemoveAt(1);

            //Aufgabe 8
            numbers.Remove(99);

            //Aufgabe 9
            numbers.RemoveAt(numbers.Count - 1);

            //Aufgabe 10

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Aufgabe 11 ----> Lösche alle Zahlen größer als 80 aus der Liste
            numbers.RemoveAll(x => x < 80);



            Console.ReadLine();

        }
        
    }

}

// While