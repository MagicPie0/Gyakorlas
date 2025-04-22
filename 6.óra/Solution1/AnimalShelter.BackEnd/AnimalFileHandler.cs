using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnimalShelter.BackEnd
{
    public static class AnimalFileHandler
    {

        public static void SaveAnimals(string path, List<Animal> animals)
        {
            File.WriteAllLines(path, animals.Select(a => $"{a.GetType().Name}, {a.Age}"));
        }

        public static List<Animal> LoadAnimals(string path) 
        {
            var lines = File.ReadAllLines(path);
            var result = new List<Animal>();

            foreach (var line in lines) 
            {
                var parts = line.Split(',');
                var type = parts[0];
                var age = int.Parse(parts[1]);

                Animal a = type switch
                {
                    "Dog" => new Dog("Bodri", age),
                    "Cat" => new Cat("Cirmos", age),
                    _ => null
                };

                if(a != null)
                    result.Add(a);
            }

            return result;
        }
    }
}
