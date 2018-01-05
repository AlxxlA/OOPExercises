using System.Collections.Generic;

namespace School.Contracts
{
    public interface ITeacher : IPerson, ICommentable
    {
        ICollection<IDiscipline> Disciplines { get; }
    }
}