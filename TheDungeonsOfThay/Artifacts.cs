using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class Artifacts : IArtifacts, IItem
    {
        public float HPBonus { get; set; }
        public float DEFBonus { get; set; }
        public float STRBonus { get; set; }
        public float DexBonus { get; set; }
        public int ManaBonus { get; set; }
        public float ATKBonus { get; set; }
        public float MiscBonus { get; set; }
        public string OnPickUp { get; set; }
        public float Weight { get; set; }
        public float GoldValue { get; set; }
        public int Quantity { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string Lore { get; set; }
        public string Ondrop { get; set; }

        public string Bonusinfo()
        {
            return $"{Name} has been imbued with a magical item, it now gives you plus 1 to strength"; //placeholder method, logic to add later
        }

        public string DropItem()
        {
            return $"You've dropped {Name}."; // remove item from inventory
        }

        public string GainItem()
        {
            return $"You've added {Name} into your inventory. \nWeight: {Weight} \nValue:{GoldValue}";
        }

        public string Inspect()
        {
            return $"Name:{Name} Value:{GoldValue} Quantity:{Quantity} Weight:{Weight} Effect:{Effect} Lore{Lore} ";
        }

        public float StatBonus()
        {
            return MiscBonus++;//pass stat variable and return it increased by 1 or higher Int value
        }
    }
}
