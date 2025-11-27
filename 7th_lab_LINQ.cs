using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string department, double salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        // Sample employee list
        List<Employee> employees = new List<Employee>
        {
            new Employee("Sudeep", "IT", 55000),
            new Employee("John", "HR", 40000),
            new Employee("Alex", "IT", 72000),
            new Employee("Maria", "Finance", 65000),
            new Employee("David", "IT", 48000)
        };

        // Filter department
        Console.Write("Enter department to filter: ");
        string dept = Console.ReadLine();

        // LINQ: filter + sort
        var filteredEmployees = employees
                                .Where(emp => emp.Department.Equals(dept, StringComparison.OrdinalIgnoreCase))
                                .OrderBy(emp => emp.Salary);  // ascending order (use OrderByDescending for descending)

        // Display results
        Console.WriteLine($"\nEmployees in '{dept}' Department (Sorted by Salary):\n");

        foreach (var emp in filteredEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }
    }
}
