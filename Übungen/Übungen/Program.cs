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
            string[] namen = new string[13];

            string[] namen2 = new string[]
            {
                 "Lukas", "Jonas", "Mona", "Marie","hilipp", "Erwin",
                "Leon", "Marcello", "JOhannes", "Robin"
            };
            for (int i = 0; i< namen2.Length; i++)
            {
                namen2[i] += " 123";
            }
                
            //foreach (string trainee in namen2)
            //{
            //    Console.WriteLine(trainee);
            //}
            Console.ReadLine();
        }
    }
}
