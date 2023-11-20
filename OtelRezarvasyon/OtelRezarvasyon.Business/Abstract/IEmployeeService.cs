using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll(int employeeId); // sadece employe id esit olanlar listlensin.
        List<Employee> GetEmployeeTasks(int employeeId);


    }
}
