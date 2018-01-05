using System;
using System.Collections.Generic;
using System.Linq;
using AnimalHierarchy.Common;
using AnimalHierarchy.Contracts;
using AnimalHierarchy.Models;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main()
        {
            var animals = new List<IAnimal>
            {
                new Dog("Sharo", 2, Gender.Male),
                new Dog("Skalata", 5, Gender.Male),
                new Dog("Bela", 1, Gender.Female),
                new Frog("Kermit", 10, Gender.Male),
                new Frog("Kaka", 20, Gender.Female),
                new Frog("Pepe", 20, Gender.Male),
                new Dog("Leni", 20, Gender.Male),
                new Tomcat("Tom", 8),
                new Tomcat("Jerry", 8),
                new Kitten("Lili", 4),
                new Kitten("Neli", 3),
                new Kitten("kote", 9),
                new Kitten("molly", 10)
            };

            var gruped = animals.GroupBy(a => a.GetType().Name)
                .Select(x => new { GroupName = x.Key, AverageAge = x.Average(a => a.Age) });

            foreach (var group in gruped)
            {
                Console.WriteLine($"Group: {group.GroupName}, Averege age: {group.AverageAge}");
            }
        }
    }
}