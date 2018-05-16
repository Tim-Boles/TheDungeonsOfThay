using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IRace
    {
        string Name { get; set; }
        float BaseHealth { get; set; }
        float BaseArmor { get; set; }
        float BaseStrength { get; set; }
        float BaseDexterity { get; set; }
        float BaseMana { get; set; }

        string RaceDescription();
    }
}
