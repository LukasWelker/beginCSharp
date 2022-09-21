using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public  class Cars2
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        
        public bool MotorLaeuft { get; private set; }
        public int Geschwindigkeit { get; private set; }
       public bool ZufriedenheitColor { get; private set; }
        


        public Cars2(int typeid, string make, string model, string typename, string color, int geschwindigkeit)
        {
            TypeId = typeid;
            Make = make;
            TypeName = typename;
            Color = color;
            Geschwindigkeit = geschwindigkeit;
            Model = model;
        }




        public void StarteMotor()
        {
            if(MotorLaeuft == true)
            {
                Console.WriteLine("Der Motor ist schon gestartet, funktioniert nicht zwei Mal");
            }
            else
            {
                
                Console.WriteLine("Motor wurde erfolgreich gestartet!");
            }
                
            
        }
        public void Beschleunigung()
        {
            Geschwindigkeit += 1;
            Console.WriteLine("Deine Geschwindigkeit hat sich um 1 erhöht");
                      
        }
        public void BeschleunigungUm(int wert)
        {
            for (Geschwindigkeit = 0; Geschwindigkeit <= wert; Geschwindigkeit += 5)
            {
                if(Geschwindigkeit == 70)
                {
                    Console.WriteLine("OHHH Marcello wurde innerorts mit 70kmh geblitzt.PECH GEHABT!:( Das wars mit dem Führerschein!");
                }
                Console.WriteLine($"Dein aktuelle Geschwindigkeit beträgt {Geschwindigkeit}!");
                if (Geschwindigkeit == wert)
                {
                    Console.WriteLine("Maximalfeschwindigkeit ist bereits erreicht");
                }
            }
        }
        public void Bremsen()
        {
            Geschwindigkeit -= 10;
            Console.WriteLine("Deine Geschwindigkeit hat sich um 10 verringert");
        }
        public void BremsenUm(int wert)
        {
            for(Geschwindigkeit = wert; Geschwindigkeit >= 0;Geschwindigkeit -= 10)
            {
                Console.WriteLine($"Deine aktuelle Geschwindigkeit beträgt {Geschwindigkeit}");
                if (Geschwindigkeit <= 0)
                {
                    Console.WriteLine("Dein Auto steht bereits");
                }

            }

        }
        public void Lackierung()
        {
            string newColor = Color;
            if(ZufriedenheitColor == false)
            {
                Console.WriteLine("Möchtest du deine Farbe des Autos verändern(y/n)");
                string ColorChange = Console.ReadLine();
                if(ColorChange == "y")
                {
                    Console.WriteLine("Welche Farbe hättest du gerne?");
                     newColor = Console.ReadLine();
                    Console.WriteLine($"Alles klar dein Auto wird nun in deine neue Wunschfarbe {newColor} lackiert.");
                    Color = newColor;
                }
                else
                {
                    Console.WriteLine("Alles klar dein Auto scheint schon dein Wunschauto zu sein");                    
                }
            }
        }
        public override string ToString()
        {
           
            return $"Dein Fahrzeug ist ein " +
                $"{Make} {Model} {TypeName} " +
                $" in der Farbe {Color}.";
        }
        
        

        
        
    }
     

}
