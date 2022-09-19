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
            //ganzzahlige Zufallvariable k im Intervall I=[0;...;36]
            Random k = new Random();
            int random_zahl;



            int budget = 10000;

       
            int einsatz = 10;
            bool lastgame_won = true;
           
            // ZU beginn ist der Countdown 0
            int count = 0;
            //Läuft die Schleife die ganze Zeit durch wenn mehr als 0 Euro vorhanden sind
            do
            {
                 random_zahl = k.Next(0, 36);
                //Wenn man mindestens 10k hat und das letzte Spiel gewonnen hat setzt man 10 Euro
                if (budget >= 10000 && lastgame_won == true )
                {
                    einsatz = 10;
                }
                //Wenn man mindestens 10k besitzt und das Letzte Spiel verloren hat verdoppelt sich der einsatz
                else if (budget >= 10000 && lastgame_won == false)
                {
                    einsatz = 20;
                }
                //Wenn man weniger als 10k besitzt verdoppelt sich der gesamtverlust dieser wird der einsatz
                else if (budget < 10000)
                {
                    int gesamtverlust = 10000 - budget;
                    einsatz = 2 * gesamtverlust;

                }
                ////Einsatz darf maximal 1000Euro sein
                einsatz = Math.Min(1000, einsatz);
                ////Einsatz ist maximal die Höhe meines Budget
                einsatz = Math.Min(einsatz, budget);


                budget = budget - einsatz;
               
                //Wenn k gerade ist und k ungleich 0 ist erhalte ich 20 Euro
                if (random_zahl % 2 == 0 && random_zahl != 0)
                {
                    int gewinn = 2 * einsatz;
                    budget = budget + gewinn;
                    lastgame_won = true;
                    Console.WriteLine("You won!");
                }
                // Wenn k gleich 0 ist wird der einsatz abgezogen aber der einsatz bleibt gleich
                else if (random_zahl == 0)
                {
                    Console.WriteLine("nothing happend");
                    lastgame_won = false;
                }
                //Wenn k ungerade ist verlieren sie ihren einsatz aber am einsatz verändert sich nichts
                else if (random_zahl % 2 == 1)
                {
                    budget = budget - einsatz;
                    lastgame_won = false;
                    Console.WriteLine("You lost!");
                }
                // Zählt den Coun´t jedes mal wenn die Schleife einmal durchgelaufen ist addiert immer plus 1 wegen dem ++
                count++;
                Console.WriteLine($"Dein aktuelles Budget beträgt: {budget}");
                Console.WriteLine($"Dein aktueller Einsatz beträgt: {einsatz}");
                Console.WriteLine($"Randomzahl: {random_zahl}");




            }
            while (budget > 0 ); 
       
            Console.WriteLine($"Das ist dein momentaner Speielcounter: {count}");
            Console.WriteLine($"Das ist dein momentaner Kontostand: {budget}");



            Console.ReadLine();
        }
        
    }

}

