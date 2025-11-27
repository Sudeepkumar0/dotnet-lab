using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    // Constructor
    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    // Method to calculate average grade
    public static double CalculateAverageGrade(List<Student> students)
    {
        if (students == null || students.Count == 0)
        {
            return 0;
        }

        double total = 0;

        foreach (var student in students)
        {
            total += student.Grade;
        }

        return total / students.Count;
    }
}

class Program
{
    static void Main()
    {
        // Creating student objects
        List<Student> studentList = new List<Student>()
        {
            new Student("Sudeep", 21, 85.5),
            new Student("Alex", 22, 90.0),
            new Student("John", 20, 78.5)
        };

        // Calculate average grade
        double average = Student.CalculateAverageGrade(studentList);

        Console.WriteLine("Average Grade of Students: " + average);
    }
}
