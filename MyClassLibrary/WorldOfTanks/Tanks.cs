using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
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

        public void Show()
        {
            Console.WriteLine("Наименование Танка => " + theNamesOfTheTank
                + "\n" + "Уровень Боекомпекта => " + levelTankAmmunition
                + "\n" + "Уровень брони => " + amorLevel
                + "\n" + "Уровень маневренности => " + levelManeuverability);
        }

    }
}
