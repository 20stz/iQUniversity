using Animal;
using System;

namespace iQuestUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"iQuest University debugging{Environment.NewLine}");

            Duck duck = new Duck();
            duck.Sound();

            Dog dog = new Dog();
            dog.Sound();

            Cat cat = new Cat();
            cat.Sound();

            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey();
        }
    }
}
