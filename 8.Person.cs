using System;
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Person Name: {Name}");
        }
    }
    public class Student : Person
    {
        public int StudentID { get; set; }

        public Student(string name, int studentID) : base(name)
        {
            StudentID = studentID;
        }

        public void ShowStudentDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Student ID: {StudentID}");
        }
    }

