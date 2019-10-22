using System;

namespace iQuestUniversity
{
    public abstract class Animal
    {
        protected string Name { get; }

        protected string Destination { get; }


        private string Sound { get;  }

        protected Animal(string name, string sound, string destination)
        {
            Name = name;
            Sound = sound;
            Destination = destination;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes {Sound}");
        }
    }
}
