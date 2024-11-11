giusing System.Diagnostics;
using System;
using System.Collections.Generic;
namespace DelegateTask
{
    public  class Program
    {
        public delegate bool ScoreCriteria(Student student);
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            List<Student> students = new List<Student>
            {
               new Student("Rahma",100),
               new Student("Ahmed",50),
               new Student("Mona",40),
               new Student("Nour",75),
               new Student("Ali",60),
               new Student("Omar",85),
               new Student("Eslam",20),
            };

            ScoreProcessor scoreProcessor = new ScoreProcessor();

            ScoreCriteria passingCriteria = new ScoreCriteria(ScoringSystem.IsPassing);
            ScoreCriteria failingCriteria = new ScoreCriteria(ScoringSystem.IsFailing);

            List<Student> passingStudents = ScoreProcessor.FilterStudents(students, passingCriteria);
            Console.WriteLine("Passing Students:");
            passingStudents.PrintStudentList();
            Console.WriteLine("-------------------");
            List<Student> failingStudents = ScoreProcessor.FilterStudents(students, failingCriteria);
            Console.WriteLine("\nFailing Students:");
            failingStudents.PrintStudentList();
            Console.WriteLine("-------------------");
            double averageScore = ScoreProcessor.CalculateAverageScore(students);
            Console.WriteLine($"\nAverage Score: {averageScore}");
            Console.WriteLine("-------------------");
            Student topStudent = students.TopScorer();  
            Console.WriteLine($"\nTop Scorer: {topStudent.Name} his Score is {topStudent.Score}");
        }
       
    }
}
