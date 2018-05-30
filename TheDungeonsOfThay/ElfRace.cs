using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class ElfRace : IRace
    {
        public string Name { get; set; }
        public float BaseHealth { get; set; }
        public float BaseArmor { get; set; }
        public float BaseStrength { get; set; }
        public float BaseDexterity { get; set; }
        public float BaseMana { get; set; }

        public ElfRace()
        {
            Name = "Elf";
            BaseHealth = 12;
            BaseArmor = 8;
            BaseStrength = 8;
            BaseDexterity = 14;
            BaseMana = 10;
        }

        public string RaceDescription()
        {
            return "One of the oldest races in the world of thay, elves have been around for eons and will be for eons more\n" +
                "They are the most intune with magic of any race and are very dextrious, they are very wise and live for 100's of years";
        }
    }
}
