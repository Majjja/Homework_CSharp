using System;

namespace Task_02
{
    public class FirstCourse
    {
        public string CourseName;
        public bool PassedTheCourse;

        public bool Passed()
        {
            if (PassedTheCourse) return true;
            else return false;
        }
    }

    public class SecondCourse
    {
        public string CourseName;
        public StudentsGrades Grade;

        public bool Passed()
        {
            if ((int)Grade > 5) return true;
            else return false;
        }
    }

    public class Project
    {
        public Project(bool course1, bool course2, bool course3, bool course4)
        {
            Course1 = course1;
            Course2 = course2;
            Course3 = course3;
            Course4 = course4;
        }

        public bool Course1;
        public bool Course2;
        public bool Course3;
        public bool Course4;

        public bool[] Courses;

        public void Passed()
        {
            Courses = new bool[] { Course1, Course2, Course3, Course4 };
            int count = 0;
            foreach (var course in Courses)
            {
                if (course)
                    count++;
            }
            if (count >= 3)
                Console.WriteLine("The student has Passed!");
            else
                Console.WriteLine("The student didn't pass.");
        }
    }

    public enum StudentsGrades
    {
        Five = 5,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }
    class Program
    {
        static void Main(string[] args)
        {
            var course1 = new FirstCourse()
            {
                CourseName = "Java Script Basic",
                PassedTheCourse = true
            };

            var course2 = new FirstCourse()
            {
                CourseName = "Java Script Advanced",
                PassedTheCourse = true
            };

            var course3 = new SecondCourse()
            {
                CourseName = "C# Basic",
                Grade = StudentsGrades.Nine
            };

            var course4 = new SecondCourse()
            {
                CourseName = "C# Advanced",
                Grade = StudentsGrades.Eight
            };

            var projectPass = new Project(
                course1.Passed(),
                course2.Passed(),
                course3.Passed(),
                course4.Passed()
                );

            projectPass.Passed();

            Console.ReadLine();
        }
    }
}
