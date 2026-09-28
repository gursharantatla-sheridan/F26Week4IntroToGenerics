using ListExample;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee class is defined under ListExample project

            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            Dictionary<int, Employee> dictEmployees = new Dictionary<int, Employee>();
            dictEmployees.Add(emp1.Id, emp1);
            dictEmployees.Add(emp2.Id, emp2);
            dictEmployees.Add(emp3.Id, emp3);

            //dictEmployees.Add(emp1.Id, emp1);

            Console.Write("Enter key: ");
            int key = Convert.ToInt32(Console.ReadLine());

            if (dictEmployees.ContainsKey(key))
            {
                Employee emp = dictEmployees[key];
                Console.WriteLine(emp);
            }
            else
                Console.WriteLine("Invalid key");
        }
    }
}
