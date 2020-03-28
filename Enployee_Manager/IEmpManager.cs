using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enployee_Manager
{
    public interface IEmpManager
    {
        Model_Of_Employee GetEmployee(int id);
        IEnumerable<Model_Of_Employee> GetAllEmployees();
        Task<int>  AddEmployee(Model_Of_Employee employee);
        Task<int> UpdateEmployee(Model_Of_Employee employeeChanges);
        Model_Of_Employee DeleteEmployee(int id);
    }
}
