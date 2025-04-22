using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalShelter.BackEnd;


namespace AnimalShelter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Dog("Kutya", 12),
                new Cat("Deni", 1)
            };

            foreach (var animal in animals) 
            {
                Console.WriteLine(animal.Description());
                Console.WriteLine(animal.Speak());
                Console.WriteLine($"Age shifted: {animal.ShiftedAge()}");
            }

            AnimalCountDown(5);
            AnimalFileHandler.SaveAnimals("animals.txt", animals);
        }
    }
}
