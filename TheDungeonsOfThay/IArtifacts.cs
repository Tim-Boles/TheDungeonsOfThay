using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    interface IArtifacts
    {
        float HPBonus { get; set; }
        float DEFBonus { get; set; }
        float STRBonus { get; set; }
        float DexBonus { get; set; }
        int ManaBonus { get; set; }
        float ATKBonus { get; set; }
        float MiscBonus { get; set; }

        float StatBonus();
        string Bonusinfo();

        


        


    }
}
