using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEmpDept
{
    class Employee
    {
        [Key]
        public int Eid { get; set; }
        
        public string Ename { get; set; }
        public string Desig { get; set; }
        public Department dep { get; set; }
        public int Did { get; set; }
        public Double Salary { get; set; }
      
        //[ForeignKey("Did")]
       
    }
}
