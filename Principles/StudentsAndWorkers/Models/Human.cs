﻿using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers.Models
{
    public abstract class Human : IHuman
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}