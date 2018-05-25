using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class Weapons : IWeapons, IItem
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
        public string DamageType { get; set; }
        public float DamageMod { get; set; }
        public int EquipSlot { get; set; }
        public int GemSlots { get; set; }
        public bool Equipped { get; set; }

        public string DropItem()
        {
            return $"You've dropped {Name}."; // add logic to remove item from inventory
        }

        public string EquipWeapon()
        {
            return $"{Name} has been equipped."; // add logic to equip weapon later
        }

        public string GainItem()
        {
            return $"You've added {Name} into your inventory. \nWeight: {Weight} \nValue:{GoldValue}"; // add logic to pick up and add to inventory
        }

        public string Inspect()
        {
            return $"Name:{Name} \nValue:{GoldValue} \nQuantity:{Quantity} \nWeight:{Weight} \nEffect:{Effect} \nLore{Lore} "; // add logic to inspect
        }

        public string UnequipWeapon()
        {
            return $"{Name} has been unequipped."; // add logic to unequip weapon
        }
    }
}
