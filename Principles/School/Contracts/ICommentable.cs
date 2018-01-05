using System.Collections.Generic;

namespace School.Contracts
{
    public interface ICommentable
    {
        ICollection<IComment> Comments { get; }
    }
}