using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeGuv { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeAssignment { get; set; }
    }
}
