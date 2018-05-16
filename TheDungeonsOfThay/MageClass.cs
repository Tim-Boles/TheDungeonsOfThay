using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class MageClass : IClass
    {
        public bool IsMagicUser { get; set; }
        public string Name { get; set; }

        public MageClass()
        {
            IsMagicUser = true;
            Name = "Mage";
        }
    }
}
