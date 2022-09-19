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
            Console.WriteLine("How many cars would u like to add");

            int amount = Convert.ToInt32(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < amount; i++)
            {
                
                cars.Add(Car.Ask_UserforCar());
            }
           
            
            foreach (Car car in cars)
            {
                //
                car.PrintCarInformation();
            }



            
           
            
            Console.ReadLine();
        }

        

    }

}

