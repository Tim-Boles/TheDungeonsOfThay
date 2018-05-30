using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class RougeClass : IClass
    {
        public bool IsMagicUser { get; set; }
        public string Name { get; set; }

        public RougeClass()
        {
            IsMagicUser = false;
            Name = "Rouge";
        }
    }
}
