using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IActor
    {
        float Health { get; set; }
        float Armor { get; set; }
        float Strength { get; set; }
        float Dexterity { get; set; }
        float Mana { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        string Race { get; set; }

        float Attack();
        void Spell();
        float SpellDamage();
        void UseItem();
        void TakeDamage();
        void Status();
    }
}
