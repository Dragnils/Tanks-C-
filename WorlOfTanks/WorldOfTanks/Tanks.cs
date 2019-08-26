using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    
    public class Tanks
    {        
        private string theNamesOfTheTank;
        int levelTankAmmunition;
        int amorLevel;
        int levelManeuverability;

        public Tanks() { theNamesOfTheTank = null; levelTankAmmunition = 0; amorLevel = 0; levelManeuverability = 0; }

        public Tanks(string nameoftank, int boekompl, int bron, int manev)
        {
            theNamesOfTheTank = nameoftank;
            levelTankAmmunition = boekompl;
            amorLevel = bron;
            levelManeuverability = manev;
        }

        public static Tanks operator *(Tanks T34, Tanks Pantera)
        {
            if (T34.levelTankAmmunition > Pantera.levelTankAmmunition && T34.amorLevel > Pantera.amorLevel) return T34;
            else if (T34.amorLevel > Pantera.amorLevel && T34.levelManeuverability > Pantera.levelManeuverability) return T34;
            else if (T34.levelTankAmmunition > Pantera.levelTankAmmunition && T34.levelManeuverability > Pantera.levelManeuverability) return T34;
            else return Pantera;
        }

        Random rand = new Random();
        public void Tan4ik(string nameoftank, int boekompl, int bron, int manev)
        {
            theNamesOfTheTank = nameoftank;
            levelTankAmmunition = boekompl;
            amorLevel = bron;
            levelManeuverability = manev;

            //for (int i = 0; i < levelManeuverability; i++)
            //{
            //    levelManeuverability = rand.Next(0, 101); //Уровня боекомплекта танка 

            //    Console.WriteLine(levelManeuverability);
            //}

            //for(int i =0; i< levelTankAmmunition; i++)
            //{
            //    levelTankAmmunition = rand.Next(0, 101);
            //}

            //for (int i = 0; i < amorLevel; i++)
            //{
            //    amorLevel = rand.Next(0, 101);
            //}

        }

        public void Show()
        {
            Console.WriteLine("Наименование Танка => " + theNamesOfTheTank
                + "\n" + "Уровень Боекомпекта => " + levelTankAmmunition
                + "\n" + "Уровень брони => " + amorLevel
                + "\n" + "Уровень маневренности => " + levelManeuverability);
        }      
        
           
        
    }
}
