using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit1 = new Rabbit(EyeColor.Blue, FurColor.Black, Gender.Female, new DateTime(2010, 10, 1));
            rabbit1.PrintInfo();
            rabbit1.Move();
            rabbit1.Sleep();
            rabbit1.Eat();
           

            Console.ReadKey();
        }
    }
}
