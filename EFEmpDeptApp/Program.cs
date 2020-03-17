using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEmpDept
{
    class Program
    {
        static void Main(string[] args)
        {
            Department();
            InsertData();
           

        }
        private static void InsertData()
        {
            ShrikantContext edc = new ShrikantContext();
            Console.WriteLine("Enter The EmployeeID:");
            int empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp Name:");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter Emp Designation:");
            string design = Console.ReadLine();

            Console.WriteLine("Enter the DepartmentId;");
            int did = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Emp Salary");
           Double sal = Convert.ToInt32(Console.ReadLine());

            Employee emp = new Employee { Eid = empid, Ename = ename, Desig = design, Did = did, Salary = sal };
            edc.Employees.Add(emp);
            edc.SaveChanges();
            Console.ReadKey();
        }
        private static void Department()
        {
            ShrikantContext edcc = new ShrikantContext();
            Console.WriteLine("Enter your DepartmentID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Department Name");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter your Department Location:");
            string loc = Console.ReadLine();


            Department dept = new Department { Dyd=id, Dname = dname, Location = loc };
            edcc.dep.Add(dept);
            edcc.SaveChanges();
            Console.ReadKey();
          

        }
    }
}
