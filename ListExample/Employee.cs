using System;
using System.Collections.Generic;
using System.Text;

namespace ListExample
{
    public class Employee (int id, string? name, double salary)
    {
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
        public double Salary { get; set; } = salary;

        public override string ToString()
        {
            return $"Id = {Id}\nName = {Name}\nSalary = {Salary:C}\n\n";
        }
    }
}
