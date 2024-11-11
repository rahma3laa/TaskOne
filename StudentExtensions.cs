using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    public  static class StudentExtensions
    {
        public static void PrintStudentList(this List<Student> students)
        {
            foreach (var student in students) { 
             Console.WriteLine($"Sudent name: {student.Name} , Student score: {student.Score}" );
            }
        }
        public static Student TopScorer(this List<Student> students) {
            if (students.Count == 0) return null;
            // اول طالب كده كده التوب
            Student topStudent = students[0];
            foreach (var student in students) {
                if (student.Score > topStudent.Score)
                {
                    topStudent = student;
                }
            }
            return topStudent;
        }
    }
}
