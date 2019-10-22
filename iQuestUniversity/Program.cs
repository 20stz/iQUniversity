using System;

namespace iQuestUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"iQuest University debugging{Environment.NewLine}");

            Duck duck = new Duck("ratusca", "mac", "tarile calde");
            duck.MakeSound();
            duck.Fly();

            Duck duck2 = new Duck("ducky", "mac", "miami");
            duck2.MakeSound();
            duck2.Fly();

            Dog dog = new Dog("azorel", "ham", "cusca");
            dog.MakeSound();
            dog.Walk();

            Dog dog2 = new Dog("rex", "ham", "acasa la el");
            dog2.MakeSound();
            dog2.Walk();

            Cat cat = new Cat("miti", "miau", "bucuresti");
            cat.MakeSound();
            cat.Walk();

            Cat cat2 = new Cat("tina", "miau", "cluj");
            cat2.MakeSound();
            cat2.Walk();

            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey();
        }
    }
}
