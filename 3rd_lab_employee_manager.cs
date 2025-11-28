using System;

// Base class
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    // Virtual method (can be overridden)
    public virtual double CalculateBonus()
    {
        return Salary * 0.05;  // Default bonus: 5%
    }
}

// Derived class Manager
class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary) {}

    // Overriding bonus calculation
    public override double CalculateBonus()
    {
        return Salary * 0.10; // Manager bonus: 10%
    }
}

// Derived class Engineer
class Engineer : Employee
{
    public Engineer(string name, double salary) : base(name, salary) {}

    // Overriding bonus calculation
    public override double CalculateBonus()
    {
        return Salary * 0.08; // Engineer bonus: 8%
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism: Employee reference, different objects
        Employee emp1 = new Manager("Sudeep", 60000);
        Employee emp2 = new Engineer("Alex", 50000);
        Employee emp3 = new Employee("John", 40000); // Base class

        Console.WriteLine($"{emp1.Name} (Manager) Bonus: {emp1.CalculateBonus()}");
        Console.WriteLine($"{emp2.Name} (Engineer) Bonus: {emp2.CalculateBonus()}");
        Console.WriteLine($"{emp3.Name} (Employee) Bonus: {emp3.CalculateBonus()}");
    }
}
