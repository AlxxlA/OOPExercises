using System;
using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers.Models
{
    public class Worker : Human, IWorker
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return Math.Round(this.WeekSalary / (this.WorkHoursPerDay * 5), 2);
        }

        public override string ToString()
        {
            return base.ToString() + $", Money per hour: {this.MoneyPerHour()}";
        }
    }
}