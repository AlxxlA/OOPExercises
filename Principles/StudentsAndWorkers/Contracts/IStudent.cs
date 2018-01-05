namespace StudentsAndWorkers.Contracts
{
    public interface IStudent : IHuman
    {
        decimal Grade { get; set; }
    }
}