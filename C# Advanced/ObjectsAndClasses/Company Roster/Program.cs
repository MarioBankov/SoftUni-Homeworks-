using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> workers = new List<Employee>();
            List<Department> departmens = new List<Department>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string employee = data[0];
                double salary = double.Parse(data[1]);
                string departmen = data[2];
                Employee employe = new Employee(employee, salary, departmen);
                if (!departmens.Any(x => x.Name == departmen))
                {
                    Department department = new Department(departmen);
                    department.Employees.Add(employe);
                    departmens.Add(department);
                }
                else
                {
                    var index = departmens.FindIndex(x => x.Name == departmen);
                    departmens[index].Employees.Add(employe);
                }
            }
            double bestSalary = double.MinValue;
            int indexx = -1;
            for (int i = 0; i < departmens.Count; i++)
            {
                var a = departmens[i].Employees.Select(x => x.Salary).Average();
                if (bestSalary < a)
                {
                    bestSalary = a;
                    indexx = i;
                }
            }
            Console.WriteLine("Highest Average Salary: {0}", departmens[indexx].Name);
            var departmentWorkers = departmens[indexx].Employees;
            foreach (var item in departmentWorkers.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1:f2}", item.Name, item.Salary);
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
    class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
