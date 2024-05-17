using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Course> courses = new List<Course>
        {
            new Course { CourseId = 1, CourseName = "Mathematics" },
            new Course { CourseId = 2, CourseName = "Literature" },
            new Course { CourseId = 3, CourseName = "Informatics" },
            new Course { CourseId = 4, CourseName = "Chemistry" }
        };

        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Anna", Courses = new List<Course>() },
            new Student { StudentId = 2, Name = "Mike", Courses = new List<Course>() },
            new Student { StudentId = 3, Name = "Dave", Courses = new List<Course>() },
            new Student { StudentId = 4, Name = "Alex", Courses = new List<Course>() }
        };

        students[0].Courses.Add(courses[0]); 
        students[0].Courses.Add(courses[2]);
        students[1].Courses.Add(courses[1]); 
        students[1].Courses.Add(courses[3]); 
        students[2].Courses.Add(courses[0]); 
        students[2].Courses.Add(courses[3]); 
        students[3].Courses.Add(courses[2]);
        students[3].Courses.Add(courses[3]);

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} is enrolled in:");
            foreach (var course in student.Courses)
            {
                Console.Write($"{course.CourseName}");
                if (course == student.Courses[1])
                    break;
                Console.WriteLine(",");
            }
            Console.WriteLine();
        }
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
}


