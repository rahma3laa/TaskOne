using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    public  class ScoringSystem
    {
        public static bool IsPassing(Student student)
        {
            return student.Score > 50;
        }

      
        public static bool IsFailing(Student student)
        {
            return student.Score <= 50;
        }
    }
}
