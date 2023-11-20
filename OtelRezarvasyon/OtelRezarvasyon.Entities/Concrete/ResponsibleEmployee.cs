using OtelRezarvasyon.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Entities.Concrete
{
    public class ResponsibleEmployee:IEntity
    {
        public int ResponsibleEmployeeId { get; set; }
        public string ResponsibleEmployeeName { get; set; }
        public string ResponsibleEmployeePassword { get; set; }
        public string ResponsibleEmployeeGuv { get; set; }
        public string ResponsibleEmployeeDepartment { get; set; }
        public string ResponsibleEmployeeAssignment { get; set; }
        public int ResponsibleEmployeeRemainder { get; set; }
    }
}
