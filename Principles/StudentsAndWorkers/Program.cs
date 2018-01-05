using System;
using System.Collections.Generic;
using System.Linq;
using StudentsAndWorkers.Contracts;
using StudentsAndWorkers.Models;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            var students = new List<IStudent>();
            var workers = new List<IWorker>();

            students.Add(new Student("Pesho", "Peshev", 100));
            students.Add(new Student("Maria", "No", 40));
            students.Add(new Student("Maria", "Ivanova", 55.5m));
            students.Add(new Student("Ivan", "Peshev", 80));
            students.Add(new Student("Iva", "Peshev", 80));
            students.Add(new Student("SurStenli", "Rois", 0));
            students.Add(new Student("Lady", "Dim", 90));
            students.Add(new Student("Pesho", "Peshev", 95));
            students.Add(new Student("Stanka", "Peneva", 100));
            students.Add(new Student("Don", "Kon", 75));

            workers.Add(new Worker("Dunkan", "Maclald", 1000, 8));
            workers.Add(new Worker("Leo", "Messi", 100000, 6));
            workers.Add(new Worker("Lea", "Kad", 1000, 4));
            workers.Add(new Worker("Niko", "Nikov", 1000, 5));
            workers.Add(new Worker("Alex", "A", 1000, 6));
            workers.Add(new Worker("Dani", "Neda", 1000, 8));
            workers.Add(new Worker("Fel", "Jet", 2000, 8));
            workers.Add(new Worker("Pele", "Pele", 500, 8));
            workers.Add(new Worker("MC", "T", 1400, 8));
            workers.Add(new Worker("TC", "M", 1400, 12));

            var all = new List<IHuman>(students);
            all.AddRange(workers);

            var studentsSortedByGrade = students.OrderBy(s => s.Grade);

            var workersSortedBySalary = workers.OrderByDescending(w => w.MoneyPerHour());

            var allSortedByName = all.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);

            Console.WriteLine("Students sorted by grade:");
            foreach (var student in studentsSortedByGrade)
            {
                Console.WriteLine($"    {student}");
            }
            Console.WriteLine();

            Console.WriteLine("Workers sorted by salary:");
            foreach (var worker in workersSortedBySalary)
            {
                Console.WriteLine($"    {worker}");
            }
            Console.WriteLine();

            Console.WriteLine("All sorted by name:");
            foreach (var human in allSortedByName)
            {
                Console.WriteLine($"    {human}");
            }
        }
    }
}