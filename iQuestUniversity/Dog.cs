using System;

namespace iQuestUniversity
{
    public class Dog
    {
        private string Name { get;  }

        private string Sound { get;  }

        public Dog(string name, string sound)
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