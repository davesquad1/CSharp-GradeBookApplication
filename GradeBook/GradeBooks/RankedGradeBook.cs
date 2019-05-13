using GradeBook.Enums;
using System;
using System.Linq;

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
                throw new InvalidOperationException("Ranked grading requires at least 5 students.");
            }

            var threshold = 0.2 * Students.Count;

            if (averageGrade >= threshold * Students.Count)
            {
                return 'A';
            }
            else if (averageGrade >= threshold * Students.Count && averageGrade <= (threshold * 2) * Students.Count)
            {
                return 'B';
            }
            else if (averageGrade >= (threshold  * 2) * Students.Count && averageGrade <= (threshold * 4) * Students.Count)
            {
                return 'C';
            }
            else if (averageGrade >= (threshold * 4) * Students.Count && averageGrade <= (threshold * 6) * Students.Count)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

            //return base.GetLetterGrade(averageGrade);
        }

            
            

            //if (averageGrade >= (80 / 100 * Students.Count))
            //{
            //    return 'A';
            //}
            //else if (averageGrade >= (60 / 100 * Students.Count) && averageGrade < (80 / 100 * Students.Count))
            //{
            //    return 'B';
            //}
            //else if (averageGrade >= (40 / 100 * Students.Count) && averageGrade < (60 / 100 * Students.Count))
            //{
            //    return 'C';
            //}
            //else if (averageGrade <= (20 / 100 * Students.Count))
            //{
            //    return 'D';
            //}
            //return GetLetterGrade(averageGrade);
        }
    }


