using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            Tanks[] WIN = new Tanks[5];
            Tanks[] T34 = new Tanks[5];
            for (int i = 0; i < T34.Length; i++)
            {
                WIN[i] = new Tanks();
            }
            for (int i = 0; i < T34.Length; i++)
            {
                T34[i] = new Tanks( "T34", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            }
           
            Tanks[] Pantera = new Tanks[5];
            
            for (int i = 0; i < T34.Length; i++)
            {
                Pantera[i] = new Tanks("pantera", rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100));
            }
            for (int i = 0; i < 5; i++)
            {
                T34[i].Show();
                Pantera[i].Show(); ;
                WIN[i] = T34[i] * Pantera[i];
                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                WIN[i].Show();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
