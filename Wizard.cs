using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab11_ClassUML
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard() { }
        public Wizard(string Name, double HealthPoints, int Strength, int Intelligence, int MagicalEnergy, int SpellNumber) 
            :base(Name, HealthPoints, Strength, Intelligence, MagicalEnergy)
        {
            this.SpellNumber = SpellNumber;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("{0,-16} {1,-15}", "Spell Number: ", SpellNumber);
        }
        public void CastFireball(GameCharacter gameCharacter)
        {
            double damageDone =(double) (this.Intelligence + this.MagicalEnergy) * .08;
            gameCharacter.HealthPoints -= damageDone;
            if(gameCharacter.HealthPoints > 0)
            {
                Console.Write($"{this.Name} cast a ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Fireball");
                Console.ResetColor();
                Console.Write($" on {gameCharacter.Name} and did {damageDone} damage, leaving {gameCharacter.Name} with ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{String.Format("{0:0.##}", gameCharacter.HealthPoints)}");
                Console.ResetColor();
                Console.WriteLine(" health remaining.");
            }
            else
            {
                Console.Write($"{this.Name} has slain {gameCharacter.Name} with a ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Fireball");
                Console.ResetColor();
                Console.WriteLine($" for {damageDone} damage, pathetic.");
            }
            

        }
    }
}
