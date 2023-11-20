using OtelRezarvasyon.Business.Abstract;
using OtelRezarvasyon.DataAccess.Abstract;
using OtelRezarvasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezarvasyon.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        //burası değişebilir. farklı bir interface olabilir.
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public List<Employee> GetAll(int employeeId)
        {
            return _employeeDal.GetAll(p =>p.EmployeeId == employeeId);
        }
        // sadece görev bölümünü getir
        public List<Employee> GetEmployeeTasks(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
