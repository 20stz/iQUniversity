using System;

namespace iQuestUniversity
{
    public abstract class AnimalThatFlies : Animal
    {

        protected AnimalThatFlies(string name, string sound, string destination) : base(name, sound, destination) { }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies to {Destination}");
        }
    }
}
