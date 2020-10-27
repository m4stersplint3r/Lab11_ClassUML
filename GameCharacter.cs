using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_ClassUML
{
    class GameCharacter
    {
        public string Name { get; set; }
        public double HealthPoints { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public GameCharacter() { }
        public GameCharacter(string Name, double HealthPoints, int Strength, int Intelligence)
        {
            this.Name = Name;
            this.HealthPoints = HealthPoints;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
        }
        public virtual void Play()
        {
            Console.WriteLine("{0,-16} {1,-15}", "Name: ", Name);
            Console.WriteLine("{0,-16} {1,-15}", "Class: ", this.GetType().Name);
            Console.WriteLine("{0,-16} {1,-15}", "Health: ", HealthPoints);
            Console.WriteLine("{0,-16} {1,-15}", "Strength: ", Strength);
            Console.WriteLine("{0,-16} {1,-15}", "Intelligence: ", Intelligence);
        }
    }
}
