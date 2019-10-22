using System;

namespace iQuestUniversity
{
    public abstract class AnimalThatWalks : Animal
    {

        protected AnimalThatWalks(string name, string sound, string destination) : base(name, sound, destination) { }
        
        public void Walk()
        {
            Console.WriteLine($"{Name} walks {Destination}");
        }
    }
}
