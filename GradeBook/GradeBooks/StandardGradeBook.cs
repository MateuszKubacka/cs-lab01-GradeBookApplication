using System;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook 
    {
        public String name { get; set; }

        public StandardGradeBook(string name) : base(name)
        {
            this.name = name;
        }
    }
}
