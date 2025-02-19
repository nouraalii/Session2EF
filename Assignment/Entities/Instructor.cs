using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }
        public int DeptId { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> CourseInsts { get; set; } = new List<Course_Inst>();
    }
}
