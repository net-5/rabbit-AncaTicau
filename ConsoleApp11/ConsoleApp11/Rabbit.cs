using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    // Model the Rabbit class knowing that:

    // a rabbit can have Blue, Red or Black eyes
    // a rabbit's fur can be white, brown, black or 
    // it has a gender
    // has a birth date, and based on that you should be able to see how old the rabbit is
    // we also know that a rabbit is a mammal that moves, sleeps and eats

    public enum EyeColor { Blue, Red, Black};
    public enum FurColor { White, Brown, Black, Grey };
    public enum Gender { Male, Female, Unknown };
    public class Rabbit
    {
        private int age = -1;
        private readonly DateTime dateOfBirth;

        public Rabbit( EyeColor eyeColor, FurColor fur, Gender gender, DateTime dateOfBirth)
        {
            this.EyeColor = eyeColor;
            this.FurColor = fur;
            this.Gender = gender;
            this.dateOfBirth = dateOfBirth;
        }

        public EyeColor EyeColor { get; set; }

        public FurColor FurColor { get; set; }
        
        public Gender Gender { get; set; }
        
        public int Age
        {
            get
            {
                if (age != -1)
                {
                    return age;
                }

                age = DateTime.Now.Year - dateOfBirth.Year;

                if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Eye color: " + EyeColor);
            Console.WriteLine("Fur color: " + FurColor);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Date of birth: " + dateOfBirth.ToShortDateString());
        }

        public void Move()
        {
            Console.WriteLine("Rabbit is a mammal and he moves.");
        }
        public void Sleep()
        {
            Console.WriteLine("Rabbit is a mammal and he sleeps.");
        }
        public void Eat()
        {
            Console.WriteLine("Rabbit is a mammal and he eats.");
        }
    }
}
