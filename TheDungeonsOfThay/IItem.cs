using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IItem
    {
        float Weight { get; set; }
        float GoldValue { get; set; }
        int Quantity { get; set; }
        string ID { get; set; }
        string Name { get; set; }
        string Effect { get; set; }
        string Lore { get; set; }
        string Ondrop { get; set; }

        // calls weight, goldvalue, description, quantity, Effect, name.
        string Inspect();
        //displays drop item text and removes from inventory.
        string DropItem();




    }
}



   