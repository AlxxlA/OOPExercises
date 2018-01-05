namespace School.Contracts
{
    public interface IStudent : IPerson, ICommentable
    {
        int FacultyNumber { get; }
    }
}