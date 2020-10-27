using System;
using System.Collections.Generic;

namespace Lab11_ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> characters = new List<GameCharacter>
            {
                new Warrior("Steve", 15, 5, 1,"Axe"),
                new Warrior("The Black Knight", 15, 9, -1, "Broad Sword"),
                new Wizard("Gandalf", 10, 3, 19, 20, 5),
                new Wizard("Firestorm", 10, 2, 11, 13, 3),
                new Wizard("Freeze", 10, 2, 13, 14, 2)
            };

            foreach(GameCharacter character in characters)
            {
                character.Play();
                Console.WriteLine();
            }

            Wizard gandalf = (Wizard)characters[2];
            Warrior tBN = (Warrior)characters[1];
            gandalf.CastFireball(tBN);
            tBN.SwingWeapon(gandalf);
            gandalf.CastFireball(tBN);
            tBN.SwingWeapon(gandalf);
            gandalf.CastFireball(tBN);
            tBN.SwingWeapon(gandalf);
            gandalf.CastFireball(tBN);
            tBN.SwingWeapon(gandalf);
            gandalf.CastFireball(tBN);
            CreateCharacter(characters);
        }

        public static void CreateCharacter(List<GameCharacter> characters)
        {
            int classChoice;
            string characterName, weaponChoice;
            Console.Write($"Choose your class: {Environment.NewLine}1. Warrior{Environment.NewLine}2. Wizard{Environment.NewLine}Choice: ");
            while(int.TryParse(Console.ReadLine().Trim(), out classChoice) == false)
            {
                Console.Write($"You must enter 1 or 2: ");
            }

            Console.Write("Enter character name: ");
            characterName = Console.ReadLine().Trim();
            while(characterName.Length < 1)
            {
                Console.Write("You must enter character name: ");
                characterName = Console.ReadLine().Trim();
            }

            

            switch (classChoice)
            {
                case 1:
                    Console.Write("Choose a weapon: ");
                    weaponChoice = Console.ReadLine().Trim();
                    while (weaponChoice.Length < 1)
                    {
                        Console.Write("You must enter a weapon: ");
                        weaponChoice = Console.ReadLine().Trim();
                    }
                    characters.Add(new Warrior(characterName, 15, 5, 1, weaponChoice));
                    break;
                case 2:
                    characters.Add(new Wizard(characterName, 10, 2, 10, 12, 1));
                    break;
                default:
                    break;
            }
            Console.WriteLine($"A new {characters[characters.Count - 1].GetType().Name} named {characters[characters.Count - 1].Name} has been created.");
        }
    }
}
