using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class DwarfRace : IRace
    {
        public string Name { get; set; }
        public float BaseHealth { get; set; }
        public float BaseArmor { get; set; }
        public float BaseStrength { get; set; }
        public float BaseDexterity { get; set; }
        public float BaseMana { get; set; }

        public DwarfRace()
        {
            Name = "Dwarf";
            BaseHealth = 16;
            BaseArmor = 16;
            BaseStrength = 16;
            BaseDexterity = 6;
            BaseMana = 0;
        }

        public string RaceDescription()
        {
            return "A race nearly as old as the elves, dwarfs have lived deep in the mountains for eons\n" +
                "There they have perfected the art of armor crafting and have become quite strong from the years of smithing\n" +
                "throught this time they have lost touch with the magic of old, this doesn't stop a few from learning the ways\n" +
                "Dwarfs have a lifespan of around 150 years";
        }
    }
}
