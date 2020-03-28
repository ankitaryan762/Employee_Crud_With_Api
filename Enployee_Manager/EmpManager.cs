using Employee_Repository;
using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enployee_Manager
{
    public class EmpManager : IEmpManager
    {
        private readonly IEmployeeRepository emp_Repository;

        public EmpManager(IEmployeeRepository emp_Repository)
        {
            this.emp_Repository = emp_Repository;
        }
        public Task<int> AddEmployee(Model_Of_Employee employee)
        {
            return this.emp_Repository.AddEmployee(employee);
        }

        public Model_Of_Employee DeleteEmployee(int id)
        {
            return this.emp_Repository.DeleteEmployee(id);
        }

        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            return this.emp_Repository.GetAllEmployees();
        }

        public Model_Of_Employee GetEmployee(int id)
        {
            return this.emp_Repository.GetEmployee(id);
        }

        public Task<int> UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            return this.emp_Repository.UpdateEmployee(employeeChanges);
        }
    }
}
