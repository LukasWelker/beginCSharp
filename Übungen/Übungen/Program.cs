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
            Console.WriteLine("Hello how many houses you would like to add?");
            int amount = Convert.ToInt32(Console.ReadLine());
            List<Haus> Haeuser = new List<Haus>();
            double QM = 0;
            for(int i = 0; i < amount; i++)
            {
                Haeuser.Add(Haus.AskForUsersHouse());
            }

            foreach (Haus haus in Haeuser)
            {
                haus.PrintHausInformation();
                double summe1 = haus.Hauswohnfläche();
                double summe2 = haus.GründstückQM();
                Console.WriteLine($"Deine Hausfläche beträgt {summe1}");
                Console.WriteLine($"Deine Grundstückfläche beträgt {summe2}");
                QM = summe1 + summe2;
                Console.WriteLine($"Deine gesamte Gründtsückfläche beträgt {QM}");
            }

            

            
            
            

            
           Console.ReadLine();

        }

        

    }

}

