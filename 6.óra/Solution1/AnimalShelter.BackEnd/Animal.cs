using System;

namespace AnimalShelter.BackEnd
{
    public abstract class Animal
    {
        protected string name;
        public int Age { get; set; }

        protected Animal(string name, int age)
        {
            this.name = name;
            Age = age;
        }

        public abstract string Speak();

        public virtual string Description() => $"{name}, {Age} years old";

        public int ShiftedAge() => Age << 1;

        public static void CountDown(int n)
        {
            if(n <= 0) return;
            Console.WriteLine(n);
            CountDown(n - 1);
        }

    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override string Speak() => "Woof!";
    }

    public class Cat : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override string Speak() => "Meow!";
    }
}
