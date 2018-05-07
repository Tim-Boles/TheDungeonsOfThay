using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class MainCharacter : IActor
    {
        public float Health { get; set; }
        public float Armor { get; set; }
        public float Strength { get; set; }
        public float Dexterity { get; set; }
        public int Mana { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }

        public float Attack()
        {
            throw new NotImplementedException();
        }

        public void Spell()
        {
            throw new NotImplementedException();
        }

        public float SpellDamage()
        {
            throw new NotImplementedException();
        }

        public void Status()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage()
        {
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}
