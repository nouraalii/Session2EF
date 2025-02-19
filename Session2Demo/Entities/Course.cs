using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stud_Course> Students { get; set; }
    }
}
