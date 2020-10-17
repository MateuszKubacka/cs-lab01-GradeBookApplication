using GradeBook.Enums;
using System;
using System.Collections.Generic;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public String name { get; set; }
        public GradeBookType Type = GradeBookType.Ranked;

        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5) throw new InvalidOperationException("There must be at least 5 students");



            List<double> allGrades = GetAllGrades();
            List<double> betterGrades = GetBetterGrades(averageGrade, allGrades);

            int allGradesCount = allGrades.Count;
            int betterGradesCount = betterGrades.Count;
            float twentyPercentOfStudents = 0.2f * allGradesCount;

            if (betterGradesCount >= 4 * twentyPercentOfStudents)
                return 'A';
            else if (betterGradesCount >= 3 * twentyPercentOfStudents)
                return 'B';
            else if (betterGradesCount >= 2 * twentyPercentOfStudents)
                return 'C';
            else if (betterGradesCount >= twentyPercentOfStudents)
                return 'D';
            else
                return 'F';

        }


        public List<double> GetBetterGrades(double averageGrade, List<double> grades)
        {
            List<double> betterGrades = new List<double>();

            foreach (double grade in grades)
            {
                if (averageGrade > grade) betterGrades.Add(grade);
            }

            return betterGrades;
        }

        public List<double> GetAllGrades()
        {
            List<double> grades = new List<double>();

            foreach (var student in Students)
            {
                grades.AddRange(student.Grades);
            }

            return grades;
        }

    }
}