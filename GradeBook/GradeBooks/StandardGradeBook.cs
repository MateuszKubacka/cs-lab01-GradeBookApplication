using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook 
    {
        public String name { get; set; }

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.name = name;
            IsWeighted = isWeighted;
            Type = Enums.GradeBookType.Standard;
        }
    }
}
