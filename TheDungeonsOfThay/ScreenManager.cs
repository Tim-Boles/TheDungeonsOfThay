using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDungeonsOfThay
{
    class ScreenManager : IManager
    {
        public string ID { get; set; }

        public void CreateScreenManager()
        {
            this.ID = "Screen Manager";
        }

        //1-Define a delegate, holds a refrence to a method with the same type(void) and same params(object and EventArgs)
        public delegate void StartGameEventHandler(object source, EventArgs args);

        //2- Define an event based on that delgate
        public event StartGameEventHandler StartedGame;

        public void StartGame()
        {
            OnStartedGame();
        }

        //3- Raise the event
        protected virtual void OnStartedGame()
        {
            if (StartedGame != null)
            {
                StartedGame(this, EventArgs.Empty);
            }
        }
    }
}
