using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using static DelegateTask.Program;

namespace DelegateTask
{
    public class ScoreProcessor
    {
        public static  List<Student> FilterStudents(List<Student> students, ScoreCriteria criteria)
        {
            List<Student> filteredStudents = new List<Student>();

            foreach (var student in students)
            {
                if (criteria(student))
                {
                    filteredStudents.Add(student);
                }
            }

            return filteredStudents;
        }
        public static double CalculateAverageScore(List<Student> students)
        {
            double totalScore = 0; ;
            foreach (var student in students)
            {
                totalScore += student.Score;
            }
            // return zero no student 
            return students.Count > 0 ? totalScore / students.Count : 0;
        }
    }
}
