using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextForRPGTest;

namespace TheDungeonsOfThay
{
    class CharacterCreationScreen
    {
        private MainCharacter NewCharacter;
        private TextFileData tFData;
        private TextFileDataIO tFDataIO;

        public void OnStartedCharacterCreation(object source, EventArgs args)
        {
            Console.WriteLine("Welcome to character creation!");
            NewCharacter = new MainCharacter();
            tFData = new TextFileData();
            tFDataIO = new TextFileDataIO();
            CharacterCreation();
        }

        private void CharacterCreation()
        {
            Console.WriteLine("First we must choose a name");
            ChooseName();
            Console.WriteLine("Now we must choose a race");
            ChooseRace();
            Console.WriteLine("Now we must choose a class");
            ChooseClass();
            Console.WriteLine("Now you can add points to your base attributes");
            AddPointsToAtts();
            Console.WriteLine("Now let's take a look at your character!");
            NewCharacter.Level = 1;
            NewCharacter.EXP = 0;
            CharacterOverview();
            SaveCharacterAndStartGame();
        }

        private void SaveCharacterAndStartGame()
        {
            tFData.Name = NewCharacter.Name;
            Console.WriteLine("what is your user name, so we can save the file!");
            string userName = Console.ReadLine();
            System.IO.Directory.CreateDirectory($@"C:\Users\{userName}\Desktop\ThaySaves");
            tFData.Path = $@"C:\Users\{userName}\Desktop\ThaySaves";
            tFData.CreateFile();
            tFDataIO.WriteToFile(tFData.TruePath, NewCharacter.toStringArray());
            Console.WriteLine("Time to start the game!");
            Console.Clear();
            OnStartedNewGame();
        }

        public delegate void StartNewGameEventHandler(object source, EventArgs args);

        public event StartNewGameEventHandler StartedNewGame;

        protected virtual void OnStartedNewGame()
        {
            if(StartedNewGame != null)
            {
                StartedNewGame(this, EventArgs.Empty);
            }
        }

        private void CharacterOverview()
        {
            Console.WriteLine($"Name: {NewCharacter.Name}\nRace: {NewCharacter.Race}\nClass: {NewCharacter.ClassName}\n" +
                $"Level: {NewCharacter.Level}\nHealth: {NewCharacter.Health}\nArmor: {NewCharacter.Armor}\nStrength: {NewCharacter.Strength}\n" +
                $"Dexterity: {NewCharacter.Dexterity}\nMana: {NewCharacter.Mana}");
            Console.WriteLine("Now will save your character and get you started!");
        }

        private void AddPointsToAtts()
        {
            float pointsToSpend = 12;
            Console.WriteLine("Here are your current attributes");
            Console.WriteLine($"Health: {NewCharacter.Health}\nArmor: {NewCharacter.Armor}\n" +
                $"Strength: {NewCharacter.Strength}\nDexterity: {NewCharacter.Dexterity}\n" +
                $"Mana: {NewCharacter.Mana}\n");
            Console.WriteLine($"You now have {pointsToSpend} points to spend on improving your attributes");
            Console.WriteLine("Type the name of the attribute and you will be asked how many points you wish to spend\n" +
                "For health and mana each point spent will add 2 points to the attribute");
            SpendPoints(pointsToSpend);
            Console.Clear();
        }

        private void SpendPoints(float pointsToSpend)
        {
            float pointsLeft = pointsToSpend;
            while(pointsLeft > 0)
            {
                string attributeToSpendPointsOn = Console.ReadLine();
                switch (attributeToSpendPointsOn.ToUpper())
                {
                    case "HEALTH":
                        float pointsForHealth;
                        while (true)
                        {
                            Console.WriteLine("How many points do you wish to spend?");
                            pointsForHealth = Int32.Parse(Console.ReadLine());
                            if(pointsForHealth > pointsLeft)
                            {
                                Console.WriteLine($"You've went over your budget, you have {pointsLeft} points left");
                            }
                            else
                            {
                                break;
                            }
                        }
                        NewCharacter.Health += pointsForHealth * 2;
                        Console.WriteLine($"Your health is now {NewCharacter.Health}");
                        pointsLeft -= pointsForHealth;
                        Console.WriteLine($"You now have {pointsLeft} points left, what attribute next?");
                        break;
                    case "MANA":
                        float pointsForMana;
                        while (true)
                        {
                            Console.WriteLine("How many points do you wish to spend?");
                            pointsForMana = Int32.Parse(Console.ReadLine());
                            if (pointsForMana > pointsLeft)
                            {
                                Console.WriteLine($"You've went over your budget, you have {pointsLeft} points left");
                            }
                            else
                            {
                                break;
                            }
                        }
                        NewCharacter.Mana += pointsForMana * 2;
                        Console.WriteLine($"Your mana is now {NewCharacter.Mana}");
                        pointsLeft -= pointsForMana;
                        Console.WriteLine($"You now have {pointsLeft} points left, what attribute next?");
                        break;
                    case "STRENGTH":
                        float pointsForStrength;
                        while (true)
                        {
                            Console.WriteLine("How many points do you wish to spend?");
                            pointsForStrength = Int32.Parse(Console.ReadLine());
                            if (pointsForStrength > pointsLeft)
                            {
                                Console.WriteLine($"You've went over your budget, you have {pointsLeft} points left");
                            }
                            else
                            {
                                break;
                            }
                        }
                        NewCharacter.Strength += pointsForStrength;
                        Console.WriteLine($"Your strength is now {NewCharacter.Strength}");
                        pointsLeft -= pointsForStrength;
                        Console.WriteLine($"You now have {pointsLeft} points left, what attribute next?");
                        break;
                    case "ARMOR":
                        float pointsForArmor;
                        while (true)
                        {
                            Console.WriteLine("How many points do you wish to spend?");
                            pointsForArmor = Int32.Parse(Console.ReadLine());
                            if (pointsForArmor > pointsLeft)
                            {
                                Console.WriteLine($"You've went over your budget, you have {pointsLeft} points left");
                            }
                            else
                            {
                                break;
                            }
                        }
                        NewCharacter.Armor += pointsForArmor;
                        Console.WriteLine($"Your armor is now {NewCharacter.Armor}");
                        pointsLeft -= pointsForArmor;
                        Console.WriteLine($"You now have {pointsLeft} points left, what attribute next?");
                        break;
                    case "DEXTERITY":
                        float pointsForDex;
                        while (true)
                        {
                            Console.WriteLine("How many points do you wish to spend?");
                            pointsForDex = Int32.Parse(Console.ReadLine());
                            if (pointsForDex > pointsLeft)
                            {
                                Console.WriteLine($"You've went over your budget, you have {pointsLeft} points left");
                            }
                            else
                            {
                                break;
                            }
                        }
                        NewCharacter.Dexterity += pointsForDex;
                        Console.WriteLine($"Your dexterity is now {NewCharacter.Dexterity}");
                        pointsLeft -= pointsForDex;
                        Console.WriteLine($"You now have {pointsLeft} points left, what attribute next?");
                        break;
                    default:
                        Console.WriteLine("I didn't understand that request, maybe you typed it incorrectly?");
                        break;
                }
            }
        }

        private void ChooseClass()
        {
            List<IClass> Class = new List<IClass>();
            WarriorClass wc = new WarriorClass();
            MageClass mc = new MageClass();
            RougeClass rc = new RougeClass();
            Class.Add(wc);
            Class.Add(mc);
            Class.Add(rc);

            Console.WriteLine("Here are the avaliable classes");
            Console.WriteLine(wc.Name);
            Console.WriteLine(mc.Name);
            Console.WriteLine(rc.Name);

            bool doneWithClassChoice = false;

            while (doneWithClassChoice == false)
            {
                Console.WriteLine("Which do you want?");
                string classChoice = Console.ReadLine();

                foreach (IClass className in Class)
                {
                    if (classChoice.ToUpper() == className.Name.ToUpper())
                    {
                        NewCharacter.ClassName = className.Name;
                        doneWithClassChoice = true;
                    }
                }
                Console.WriteLine("Looks like we didn't understand your choice, try again!");
            }
            
            Console.Clear();
        }

        private void ChooseRace()
        {
            List<IRace> Race = new List<IRace>();
            HumanRace hr = new HumanRace();
            ElfRace er = new ElfRace();
            DwarfRace dr = new DwarfRace();
            Race.Add(hr);
            Race.Add(er);
            Race.Add(dr);

            Console.WriteLine("Here are the avaliable races: ");
            Console.WriteLine(hr.Name);
            Console.WriteLine(er.Name);
            Console.WriteLine(dr.Name);

            bool doneWithRaceChoice = false;

            while (doneWithRaceChoice == false)
            {
                Console.WriteLine("Which do you want?");
                string race = Console.ReadLine();

                foreach (IRace thisRace in Race)
                {
                    if (thisRace.Name.ToUpper() == race.ToUpper())
                    {

                        NewCharacter.Race = thisRace.Name;
                        NewCharacter.Health = thisRace.BaseHealth;
                        NewCharacter.Mana = thisRace.BaseMana;
                        NewCharacter.Armor = thisRace.BaseArmor;
                        NewCharacter.Strength = thisRace.BaseStrength;
                        NewCharacter.Dexterity = thisRace.BaseDexterity;
                        doneWithRaceChoice = true;
                    }
                }
                Console.WriteLine("Looks like we didn't understand your choice, try again!");
            }

            Console.Clear();

        }

        private void ChooseName()
        {
            string name = Console.ReadLine();
            NewCharacter.Name = name;
            Console.Clear();
        }
    }
}
