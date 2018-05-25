using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IWeapons
    {
        string DamageType { get; set; }
        float DamageMod { get; set; }
        int EquipSlot { get; set; }
        int GemSlots { get; set; }
        bool Equipped { get; set; }



        string EquipWeapon();
        string UnequipWeapon();




    }
}
