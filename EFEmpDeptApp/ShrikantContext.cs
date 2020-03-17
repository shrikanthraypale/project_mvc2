using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFEmpDept
{
    class ShrikantContext :DbContext
    {
        public ShrikantContext() : base("ShrikantContext") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> dep { get; set; }
    }
}
