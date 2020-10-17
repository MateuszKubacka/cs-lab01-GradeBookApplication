using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public String name { get; set; }
        public GradeBookType Type = GradeBookType.Ranked;

        public RankedGradeBook(string name, GradeBookType type) : base(name)
        {
            this.name = name;
            Type = type;
        }
    }
}
