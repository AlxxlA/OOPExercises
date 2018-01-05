using System.Collections.Generic;
using School.Contracts;

namespace School.Models
{
    public class School : ISchool
    {
        public School(ICollection<IClass> classes)
        {
            this.Classes = classes;
        }

        public ICollection<IClass> Classes { get; }
    }
}