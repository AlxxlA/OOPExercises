using System.Collections.Generic;

namespace School.Contracts
{
    public interface ISchool
    {
        ICollection<IClass> Classes { get; }
    }
}