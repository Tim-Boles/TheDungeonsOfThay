using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class WarriorClass : IClass
    {
        public bool IsMagicUser { get; set; }
        public string Name { get; set; }

        public WarriorClass()
        {
            IsMagicUser = false;
            Name = "Warrior";
        }
    }
}
