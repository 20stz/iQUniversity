using System;

namespace iQuestUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"iQuest University debugging{Environment.NewLine}");

            Duck duck = new Duck("ratusca", "mac");
            duck.MakeSound();

            Duck duck2 = new Duck("ducky", "mac");
            duck2.MakeSound();

            Dog dog = new Dog("azorel", "ham");
            dog.MakeSound();

            Dog dog2 = new Dog("rex", "ham");
            dog2.MakeSound();

            Cat cat = new Cat("miti", "miau");
            cat.MakeSound();

            Cat cat2 = new Cat("tina", "miau");
            cat2.MakeSound();

            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey();
        }
    }
}
