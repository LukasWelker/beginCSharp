using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Haus
    {
        //Properties
        public double Length_House { get; set; }
        public double Wide_house { get; set; }
        public double Height { get; set; }
        public string Rooftype { get; set; }
        public string Putzfarbe { get; set; }
        public int Floors { get; set; }
        public int Price { get; set; }
        public double Length_property { get; set; }
        public double Wide_proverty { get; set; }

        public Haus( double length_House, double wide_house, double height, string rooftype, string putzfarbe, int floors,
             int price,  double length_property, double wide_proverty)
        {
            Length_House = length_House;
            Wide_house = wide_house;
            Height = height;
            Rooftype = rooftype;
            Putzfarbe = putzfarbe;
            Floors = floors;
            Price = price;
            Length_property = length_property;
            Wide_proverty = wide_proverty;

        } 
        public Haus()
        {

        }
        
        public static Haus AskForUsersHouse()
        {
            Haus haus = new Haus();
            Console.WriteLine("Wie lang soll ihr Haus sein?");
            haus.Length_House = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit soll ihr Haus sein?");
            haus.Wide_house = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie hoch soll ihr Haus sein?");
            haus.Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Was für eine Dachart soll ihr Haus haben?");
            haus.Rooftype = Console.ReadLine();

            Console.WriteLine("Was für eine Putzfarbe soll ihr Haus haben?");
            haus.Putzfarbe = Console.ReadLine();

            Console.WriteLine("Wie viele etagen soll ihr Haus haben?");
            haus.Floors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie viel soll ihr haus kosten?");
            haus.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wie lang soll das gesamte Grünstück sein inclusive Garten etc. ?");
            haus.Length_property = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wie breit soll das gesamte Gründtsück inclusive Garten etc. sein ?");
            haus.Wide_proverty = Convert.ToDouble(Console.ReadLine());
            return haus;

        }
        public double GründstückQM()
        {
            double summe1 = Length_House * Wide_house;
            return summe1;
        }
        public double Hauswohnfläche()
        {
            double summe2 = Length_House * Wide_house * Floors;
            return summe2;
        }

        public void PrintHausInformation()
        {
            Console.WriteLine($"Mein Haus  {Length_House} lang , {Wide_house} breit, {Height} hoch und hat folgende Dachart: {Rooftype}, es ist verputzt in dieser Farbe {Putzfarbe}," +
                $"hat diese Anzahl an Etagen {Floors}, kostet {Price} Euro und das Grünstückd ist {Length_property} lang und {Wide_proverty} breit");
           
        }
         






    }
}
