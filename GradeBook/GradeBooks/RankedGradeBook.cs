using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new System.InvalidOperationException("F");
            }

           //foreach (var student in Students)
            //{
                if (averageGrade > (80 / 100 * Students.Count))
                {
                    return 'A';
                }
                else if (averageGrade > (60 / 100 * Students.Count) && averageGrade < (40 / 100 * Students.Count))
                {
                    return 'B';
                }
                else if (averageGrade > (40 / 100 * Students.Count) && averageGrade < (20 / 100 * Students.Count))
                {
                    return 'C';
                }
                else if (averageGrade > (20 / 100 * Students.Count))
                {
                    return 'D';
                }
               
          //  }
                return GetLetterGrade(averageGrade);

        }
    }
}
