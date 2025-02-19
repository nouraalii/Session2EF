using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
