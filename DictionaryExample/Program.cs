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

            //Console.Write("Enter key: ");
            //int key = Convert.ToInt32(Console.ReadLine());

            //if (dictEmployees.ContainsKey(key))
            //{
            //    Employee emp = dictEmployees[key];
            //    Console.WriteLine(emp);
            //}
            //else
            //    Console.WriteLine("Invalid key");

            //foreach(KeyValuePair<int, Employee> kvp in dictEmployees)
            foreach(var kvp in dictEmployees)
            {
                int key = kvp.Key;
                Employee e = kvp.Value;

                Console.WriteLine("Key = " + key);
                Console.WriteLine(e);
            }
        }
    }
}
