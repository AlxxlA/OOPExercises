using System.Collections.Generic;
using School.Contracts;

namespace School.Models
{
    public class Class : IClass
    {
        private static string id = "A";
        private static int counter = 1;

        public Class(ICollection<IStudent> students, ICollection<ITeacher> teachers)
        {
            this.Id = SetId();
            this.Students = students;
            this.Teachers = teachers;
            this.Comments = new List<IComment>();
        }

        public string Id { get; }

        public ICollection<IStudent> Students { get; }

        public ICollection<ITeacher> Teachers { get; }

        public ICollection<IComment> Comments { get; }

        private static string SetId()
        {
            if (id[0] > 90)
            {
                id = "A";
                counter++;
            }

            return id + counter;
        }
    }
}