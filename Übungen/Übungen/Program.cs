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
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");

            ////fi.CopyTo("C:/Projects001/beginCSharp/MeineDatei13");
            ////FileInfo fi_neu = new FileInfo("C:/Projects001/beginCSharp/MeineDatei13");
            ////fi_neu.Delete();
            //Console.WriteLine("Gebe mir den Pfad an wohin die Datei vershcieben werden soll");
            //string path =  Console.ReadLine();
            //path = path.Replace("\\, "\\\\";
            //DirectoryInfo di = new DirectoryInfo(path);
            //while (di.Exists == false)
            //{
            //    Console.WriteLine("Dein Pfad existiert nicht gib mir einen neuen!");
            //    path = Console.ReadLine();
            //    di = new DirectoryInfo(path);
            //}
            //Console.WriteLine("Wie soll die Datei heißen?");
            //string fileName = Console.ReadLine();

            //fi.CopyTo(path +"\\"+ fileName);
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");

            //if (fi.Exists)
            //{
            //    //Execute only if File exists
            //}

            string path = @"C:\Projects001Batei123";
            StreamReader sr = new StreamReader(path);
            //legiert unseere bool Wert das !
            List<string[]> einträge = new List<string[]>();
            //Remove Header
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                einträge.Add(sr.ReadLine().Split(';'));
            }

            using (StreamWriter writer = new StreamWriter(@"C:\Projects001\beginCSharp\JungeHuepfer.csv"))
            {
                for (int i = 0; i < einträge.Count; i++)
                {
                    if (Convert.ToInt32(einträge[i][2]) < 20 && einträge[i][0] == "m")
                    {
                        //\t bedeutet Tabulator
                        writer.WriteLine(string.Join(";", einträge[i]));
                        Console.WriteLine(string.Join("\t", einträge[i]));
                    }
                    //string.Join gibt einen string zurück Liste aus Parametern kann man zsm kleben

                }

            }
            
            Console.ReadLine();

        }

        

    }

}

