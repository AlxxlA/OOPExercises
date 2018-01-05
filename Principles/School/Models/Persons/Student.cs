using System.Collections.Generic;
using School.Contracts;

namespace School.Models.Persons
{
    public class Student : Person, IStudent
    {
        private static int id = 0;

        public Student(string name) : base(name)
        {
            this.FacultyNumber = id++;
            this.Comments = new List<IComment>();
        }

        public int FacultyNumber { get; }

        public ICollection<IComment> Comments { get; }
    }
}