using System.Collections.Generic;
using School.Contracts;

namespace School.Models.Persons
{
    public class Teacher : Person, ITeacher
    {
        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<IDiscipline>();
            this.Comments = new List<IComment>();
        }

        public ICollection<IDiscipline> Disciplines { get; }

        public ICollection<IComment> Comments { get; }
    }
}