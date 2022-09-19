using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    public class Car
    {
        //Attribute
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int CCM { get; set; }
        public string Color { get; set; }
        public string TypeName { get; set; }
        public int Tyres { get; set; }


        //Konstruktor besondere Art von Methode zum Erzeugen
        public Car(int typeId, string make, string model, string typeName, int ccm, string color, int Tyre)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = ccm;
            Color = color;
            Tyres = Tyre;

        }
        public Car()

        {

        }

        //METHODEN
        public static Car Ask_UserforCar()
        {
            Car car = new Car();
            Console.WriteLine("Was für ein Auto möchtest du haben(IdNummer)");
            car.TypeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was für eine Automarke möchten sie haben");
            car.Make = Console.ReadLine();

            Console.WriteLine("Was für ein konkretes Model möchten sie?");
            car.Model = Console.ReadLine();

            Console.WriteLine("Was genau ist der Typename");
            car.TypeName = Console.ReadLine();

            Console.WriteLine("Wie viel Hubraum soll das Auto haben?");
            car.CCM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welche Farbe soll das Auto haben");
            car.Color = Console.ReadLine();

            Console.WriteLine("Wie viele Räder soll das Auto haben?");
            car.Tyres = Convert.ToInt32(Console.ReadLine());
            return car;
        }
        public void PrintCarInformation()
        {
            Console.WriteLine($"Mein Fahrzeug ist ein  {Make}  {Model} {TypeName} mit einem Hubraum von {CCM} in der Farbe {Color} mit {Tyres} Reifen");
        }



       
    }
}
