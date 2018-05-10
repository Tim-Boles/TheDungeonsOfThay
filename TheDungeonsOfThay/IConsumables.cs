using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IConsumables
    {
        int Duration { get; set; }
        


        string OnUse();  
    }
}
