using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class Armor : IItem, IArmor
    {
        public string OnPickUp { get; set; }
        public float Weight { get; set; }
        public float GoldValue { get; set; }
        public int Quantity { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Lore { get; set; }
        public string Ondrop { get; set; }
        public string ArmorType { get; set; }
        public string ArmorSubType { get; set; }
        public float ArmorMod { get; set; }
        public int ArmorSlot { get; set; }

        public string DropItem()
        {
            return $"You've dropped {Name}."; // remove item from inventory
        }

        public string EquipArmor()
        {
            return $"{Name} has been equipped to the appropiate slot.";// add logic to equip armor to appropiate slot
        }

        public string GainItem()
        {
            return $"You've added {Name} into your inventory. \nWeight: {Weight} \nValue:{GoldValue}";
        }

        public string Inspect()
        {
            return $"You've added {Name} into your inventory. \nWeight: {Weight} \nValue:{GoldValue}";
        }

        public string UnEquipArmor()
        {
          return  $"{Name} has been unequipped.";
        }
    }
}
