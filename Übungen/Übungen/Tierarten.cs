using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übungen
{
    //Vererbungen sind gedacht um Properties zu verrerben keine Methoden
    public abstract class Tierarten
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Lifespan { get; set; }
        public double Weight { get; set; }
        public bool Fiel { get; set; }

        public abstract void Geräusche();
        public abstract void Essen();
        public abstract void Trinken();

        //Im Zweifel immer public void
        public void Printinfo()
        {
            
        }
        //
        public override string ToString()
        {
            // == bedeutet ist so / = bedeutet ist nicht so
            if (Fiel == false)
            {
               return $"Das {this.GetType().Name} heißt {this.Name} und ist so viele Jahre alt {this.Age}, ausßerdem " +
                                    $"ist so groß {this.Height} cm lebt bis zu {this.Lifespan} Jahre es wiegt so viel {Weight} kilo";
            }
            else
            {
                return $"Das {this.GetType().Name} heißt {this.Name} und ist so viele Jahre alt {this.Age}, ausßerdem " +
                                   $"ist so groß {this.Height} cm lebt bis zu {this.Lifespan} Jahre es wiegt so viel {Weight} kilo und hat Fell";
            }
            
        }







    }
}
