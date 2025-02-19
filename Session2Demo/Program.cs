using Microsoft.EntityFrameworkCore;
using Session2Demo.Contexts;
using Session2Demo.Entities;

namespace Session2Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Revision
            //EF Core:ORM in .Net
            //ORM

            //1.Mapping
            //Code First [Generate Table per class]
            //Db First
            //2.L2E [C# Code (LINQ)-->EF Core --> SQL DB]

            //3 Ways Generate
            //1.TPC:Table per class
            //2.TPH:Table per Heriarichy
            //3.TPCC:Table per Concrete Class 
            #endregion


            //CRUD Operations
            //Create - Read - Update - Delete

            ////CLR can't manage database connection
            //AppDbContext Context = new AppDbContext();
            //try
            //{
            //code
            //}
            //finally
            //{
            //    Context.Dispose(); 
            //}

            //using (AppDbContext context = new AppDbContext()) 
            //{

            //};

            //AppDbContext context = new AppDbContext();

            //context.Dispose();

            /*using (AppDbContext context = new AppDbContext())
            {

            }*/

            using AppDbContext context = new AppDbContext();

            #region Create-Insert

            ////Create-Insert

            //var employee = new Employee
            //{
            //    Name = "Noura Ali",
            //    Age = 25,
            //    Address = "Cairo",
            //    Salary=10000
            //};

            //Console.WriteLine(context.Entry(employee).State); //Detached

            ////context.Add(employee);
            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); //Added

            //var result = context.SaveChanges();
            //Console.WriteLine(result);
            //Console.WriteLine(context.Entry(employee).State);//UnChanged

            //employee.Name = "Omar";
            //Console.WriteLine(context.Entry(employee).State); //Modified
            //Console.WriteLine(result);

            //Console.WriteLine(context.Entry(employee).State);

            //context.Entry(employee).State = EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges(); 
            #endregion

            #region Read-Select
            ////Read-Select

            ////var result =context.Employees.Where(E=>E.Id == 4 ).FirstOrDefault();
            //var result =context.Employees.FirstOrDefault(E=>E.Id==4);

            ////var result = context.Employees.ToList().Select(E=>E.Name);

            //Console.WriteLine(context.Entry(result).State);

            //result.Name = "Ali";

            //Console.WriteLine(context.Entry(result).State);

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item);
            ////}


            ////Console.WriteLine(result?.Name);
            ////Console.WriteLine(result?.Id); 
            #endregion

            #region Update
            ////Update
            //var result = context.Employees.FirstOrDefault(E => E.Id == 40);

            //Console.WriteLine(context.Entry(result).State);

            //result.Name = "Mahmoud";

            //Console.WriteLine(context.Entry(result).State);

            //context.Update(result);

            //Console.WriteLine(context.Entry(result).State);

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(result).State);

            #endregion

            #region Delete
            ////Delete 

            //var result = context.Employees.FirstOrDefault(E=>E.Id==40);

            //Console.WriteLine(context.Entry(result).State);//Unchanged

            //context.Employees.Remove(result);

            //Console.WriteLine(context.Entry(result).State); //Modified

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(result).State);//Detached 
            #endregion



        }
    }
}
