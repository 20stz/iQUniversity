using System;

namespace iQuestUniversity
{
    public class Cat
    {
        private string Name { get; }

        private string Sound { get; }

        public Cat(string name, string sound)
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