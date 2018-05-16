using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class HumanRace : IRace
    {
        public string Name { get; set; }
        public float BaseHealth { get; set; }
        public float BaseArmor { get; set; }
        public float BaseStrength { get; set; }
        public float BaseDexterity { get; set; }
        public float BaseMana { get; set; }

        public HumanRace()
        {
            Name = "Human";
            BaseHealth = 20;
            BaseArmor = 12;
            BaseStrength = 12;
            BaseDexterity = 10;
            BaseMana = 5;
        }

        public string RaceDescription()
        {
            return "One of the youngest but largest races in the world of thay, humans are jack of all trades that can\n" +
                "persue many fields but usually are behind compared to other races in that field";
        }
    }
}
