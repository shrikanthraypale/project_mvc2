using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFEmpDept
{
    class Department
    {
        [Key]
        public int Dyd{ get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
