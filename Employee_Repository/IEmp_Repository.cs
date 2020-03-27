using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Repository
{
   public interface IEmp_Repository
    {
        Model_Of_Employee GetEmployee(int id);
        IEnumerable<Model_Of_Employee> GetAllEmployees();
        Model_Of_Employee AddEmployee(Model_Of_Employee employee);
        Model_Of_Employee UpdateEmployee(Model_Of_Employee employeeChanges);
        Model_Of_Employee DeleteEmployee(int id);
    }
}
