using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextForRPGTest;

namespace TheDungeonsOfThay
{
    class Program 
    {
        static void Main(string[] args)
        {
            ScreenManager SM = new ScreenManager();
            MainScreen MS = new MainScreen();
            CharacterCreationScreen CS = new CharacterCreationScreen();

            SM.CreateScreenManager();
            SM.StartedGame += MS.OnStartedGame;
            MS.StartedCharacterCreation += CS.OnStartedCharacterCreation;

            SM.StartGame();

        }

  
    }
}
