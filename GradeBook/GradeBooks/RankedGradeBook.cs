using GradeBook.Enums;

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
            int rank = Students.Count * 20 / 100;
        
            if (rank >= 80)
            {
                return 'A';
            }
            else if (rank >= 60 && rank < 80)
            {
                return 'B';
            }
            else if (rank >= 40 && rank < 60)
            {
                return 'C';
            }
            if (rank < 40)
            {
                return 'D';
            }
          
            if (Students.Count < 5)
            {
                throw new System.InvalidOperationException("F");
            }
            
            return GetLetterGrade(averageGrade);

        }
    }
}
