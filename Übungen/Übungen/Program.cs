using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<string> allTrainees = new List<string>() { "Lukas", "Philipp", "Mona" };
            List<string> filteredTrainees = TraineesEndWithN(allTrainees);
            foreach (string trainee in filteredTrainees)
            {
                Console.WriteLine(trainee); 
                Console.ReadLine();
            }
            Console.ReadLine();
        }
        //static List<string> GiveMeNamesWithM(List<string> allTrainees)
        //{
        //    List<string> traineeswithm= new List<string>();
        //    //Datentyp      Variablenname //in operator Ausgangsvariable
        //    foreach (string trainee in allTrainees)
        //    {
        //        if (trainee.ToLower().StartsWith("m"))
        //        {
        //            traineeswithm.Add(trainee);

        //        }
                

        //    }
        //    return traineeswithm;
        //}
        static List<string> TraineesEndWithN(List <string> allTrainees)
        {
        List<string> traineesendwithn = new List<string>();
            foreach (string trainee in allTrainees)
            {
                if (trainee.EndsWith("N"))
                {
                    allTrainees.Add(trainee);
                }
            }
        return traineesendwithn;
        }

    }

}


