using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheDungeonsOfThay
{
    class MainScreen
    {

        public void OnStartedGame(object source, EventArgs args)
        {
            Console.WriteLine("Welcome to the Dungeons of Thay!!!");
            Console.WriteLine("Do you wish to start anew or continue? anew or continue");
            string answer = Console.ReadLine();

            if(answer == "anew")
            {
                Console.Clear();
                OnStartedCharacterCreation();
            }

        }


        public delegate void StartCharacterCreationEventHandler(object source, EventArgs args);

        public event StartCharacterCreationEventHandler StartedCharacterCreation;

        protected virtual void OnStartedCharacterCreation()
        {
            if (StartedCharacterCreation != null)
            {
                StartedCharacterCreation(this, EventArgs.Empty);
            }
        }

        public void OnStartedNewGame(object source, EventArgs args)
        {
            Console.WriteLine("You've made it back to the main screen!");
        }

    }
}
