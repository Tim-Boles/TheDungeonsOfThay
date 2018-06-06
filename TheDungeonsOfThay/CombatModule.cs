using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class CombatModule : IModule
    {
        public string ActorID { get; set; }
        public List<IActor> Actors { get; set; }
        public List<IModule> Modules { get; set; }

        public CombatModule(List<IActor> actorsInCombat, List<IModule> modulesNeededForCombat)
        {
            ActorID = "none";
            Actors = actorsInCombat;
            Modules = modulesNeededForCombat;
            CreateModules();
        }

        private void CreateModules()
        {
            for (int i = 0; i < Actors.Count; i++)
            {
                for (int j = 0; j < Modules.Count; j++)
                {
                    //IModule newModule = new IModule();
                }
            }
        }
    }
}
