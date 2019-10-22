using System;

namespace iQuestUniversity
{
    public abstract class Animal
    {
        private string Name { get; }

        private string Sound { get;  }

        protected Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes {Sound}");
        }
    }
}
