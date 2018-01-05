namespace StudentsAndWorkers.Contracts
{
    public interface IWorker : IHuman
    {
        decimal WeekSalary { get; set; }

        int WorkHoursPerDay { get; set; }

        decimal MoneyPerHour();
    }
}