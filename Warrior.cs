using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ClassUML
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior() { }
        public Warrior(string Name, double HealthPoints, int Strength, int Intelligence, string WeaponType) : base(Name, HealthPoints, Strength, Intelligence)
        {
            this.WeaponType = WeaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("{0,-16} {1,-15}", "Weapon Type: ", WeaponType);
        }
        public void SwingWeapon(GameCharacter gameCharacter)
        {
            double damageDone = (double) this.Strength * .35;
            gameCharacter.HealthPoints -= damageDone;

            if (gameCharacter.HealthPoints > 0)
            {
                Console.Write($"{this.Name} swung their ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{this.WeaponType}");
                Console.ResetColor();
                Console.Write($" at {gameCharacter.Name} and did {damageDone} damage, leaving {gameCharacter.Name} with ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{String.Format("{0:0.##}", gameCharacter.HealthPoints)}");
                Console.ResetColor();
                Console.WriteLine(" health remaining.");
            }
            else
            {
                Console.Write($"{this.Name} has slain {gameCharacter.Name} with a ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{this.WeaponType}");
                Console.ResetColor();
                Console.WriteLine($" for {damageDone} damage, pathetic.");
            }
        }
    }
}
