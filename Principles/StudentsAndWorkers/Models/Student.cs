using StudentsAndWorkers.Contracts;

namespace StudentsAndWorkers.Models
{
    public class Student : Human, IStudent
    {
        public Student(string firstName, string lastName, decimal grade = 0)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public decimal Grade { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Grade: {this.Grade}";
        }
    }
}