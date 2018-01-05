using System.Collections.Generic;
using School.Contracts;

namespace School.Models
{
    public class Discipline : IDiscipline
    {
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.LecturesCount = lectures;
            this.ExercisesCount = exercises;
            this.Comments = new List<IComment>();
        }

        public string Name { get; }

        public int LecturesCount { get; }

        public int ExercisesCount { get; }

        public ICollection<IComment> Comments { get; }
    }
}