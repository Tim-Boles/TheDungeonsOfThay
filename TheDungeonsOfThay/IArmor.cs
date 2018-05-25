using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IArmor
    {
        string ArmorType { get; set; }
        string ArmorSubType { get; set; }
        float ArmorMod { get; set; }
        int ArmorSlot { get; set; }



        string EquipArmor();// add logic to equip armor to appropriate slot
        string UnEquipArmor();// add logic to unequip armor

        
       
    }

    
}
