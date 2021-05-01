using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbChallenge
{
    public class Grade
    {
        public int GradeId { get; set; }
        public decimal GradeAvg { get; set; }
        public string GradeLevel { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
