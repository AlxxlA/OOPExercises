using School.Contracts;

namespace School.Models.Persons
{
    public class Person : IPerson
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}