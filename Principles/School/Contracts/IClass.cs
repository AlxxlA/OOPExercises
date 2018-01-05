using System.Collections.Generic;

namespace School.Contracts
{
    public interface IClass : ICommentable
    {
        string Id { get; }

        ICollection<IStudent> Students { get; }

        ICollection<ITeacher> Teachers { get; }
    }
}