using AnimalHierarchy.Common;
using AnimalHierarchy.Contracts;

namespace AnimalHierarchy.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; }

        public int Age { get; }

        public Gender Gender { get; }

        public abstract string MakeSound();
    }
}