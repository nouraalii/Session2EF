using Assignment.Context;
using Assignment.Entities;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AssignmentDbContext context = new AssignmentDbContext();

            #region Create
            ////Create
            //var dept1 = new Department { Name = "Computer Science" };
            //var dept2 = new Department { Name = "HR" };

            //context.Departments.Add(dept1);
            //context.Departments.Add(dept2);
            //context.SaveChanges();

            //var student01 = new Student { FName = "Noura", LName = "Ali", Address = "Giza", Age = 20, Dep_Id = 1 };
            //var student02 = new Student { FName = "Mariam", LName = "Medht", Address = "Giza", Age = 25, Dep_Id = 2 };

            //context.Students.Add(student01);
            //context.Students.Add(student02);
            //context.SaveChanges();

            //var topic = new Topic { Name = "C#" };
            //context.Topics.Add(topic);
            //context.SaveChanges();

            //var course = new Course { Name = "C#", Description = "Programming", Duration = 3, Top_ID = 1 };
            //context.Courses.Add(course);
            //context.SaveChanges(); 
            #endregion

            #region Read
            //// Read
            //var students = context.Students.ToList();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"ID: {student.ID}, Name: {student.FName} {student.LName}");
            //}

            //var result = context.Departments.FirstOrDefault(D => D.ID == 1);
            //Console.WriteLine($"Dept_Name:{result.Name}"); 
            #endregion

            #region Update
            ////Update
            //var studentToUpdate = context.Students.FirstOrDefault(s => s.FName == "Noura");
            //studentToUpdate.Address = "Cairo";
            //context.SaveChanges();
            //Console.WriteLine($"Updated Student Address: {studentToUpdate.FName} {studentToUpdate.LName}");

            //var course = context.Courses.FirstOrDefault(C=>C.Name=="C#");
            //course.Duration = 2;
            //context.SaveChanges(); 
            #endregion

            #region Delete
            ////Delete
            //var studentToDelete = context.Students.FirstOrDefault(s => s.FName == "Mariam");
            //    context.Students.Remove(studentToDelete);
            //    context.SaveChanges();
            //    Console.WriteLine($"Deleted Student: {studentToDelete.FName} {studentToDelete.LName}"); 
            #endregion

            #region ManytoMany
            ////ManytoMany Relationship 
            //var student1 = new Student { FName = "Dina", LName = "Ali", Address = "Giza", Age = 22, Dep_Id = 2 };
            //var course1 = new Course { Name = "Java", Description = "Java", Duration = 4, Top_ID = 1 };

            //context.Students.Add(student1);
            //context.Courses.Add(course1);
            //context.SaveChanges();

            //var studentCourse = new Stud_Course { Stud_ID = 5, Course_ID = 5, Grade = 95 };
            //context.StudCourses.Add(studentCourse);
            //context.SaveChanges();

            //Console.WriteLine($"Student {student1.FName} study course {course1.Name}"); 
            #endregion
        }

    }
}
