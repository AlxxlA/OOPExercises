namespace School.Contracts
{
    public interface IDiscipline : ICommentable
    {
        string Name { get; }

        int LecturesCount { get; }

        int ExercisesCount { get; }
    }
}