using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ClassUML
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter() { }
        public MagicUsingCharacter(string Name, double HealthPoints, int Strength, int Intelligence, int MagicalEnergy)
            :base(Name, HealthPoints, Strength, Intelligence)
        {
            this.MagicalEnergy = MagicalEnergy;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("{0,-16} {1,-15}", "Magical Energy: ", MagicalEnergy);
        }
    }
}
