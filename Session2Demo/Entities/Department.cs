using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Entities
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }

        [ForeignKey("Manager")]
        public int EmpId { get; set; }
        public Employee Manager { get; set; } //Navigational property 

        public List<Employee> Employees { get; set; }
    }
}
