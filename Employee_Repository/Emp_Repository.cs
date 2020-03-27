using Employee_Repository.context;
using EmployeeModel;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Employee_Repository
{
    public class Emp_Repository
    {
        private readonly EmpDbContext empDbContext;

        public Emp_Repository(EmpDbContext empDbContext)
        {
            this.empDbContext = empDbContext;
        }
        public Model_Of_Employee AddEmployee(Model_Of_Employee employee)
        {
            empDbContext.Employees.Add(employee);
            empDbContext.SaveChanges();
            return employee;
        }

        public Model_Of_Employee DeleteEmployee(int id)
        {
            Model_Of_Employee employee = empDbContext.Employees.Find(id);
            if (employee != null)
            {
                empDbContext.Employees.Remove(employee);
                empDbContext.SaveChanges();
            }
            return employee;

        }

        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            return empDbContext.Employees;
        }

        public Model_Of_Employee GetEmployee(int id)
        {
            return empDbContext.Employees.Find(id);
        }

        public Model_Of_Employee UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            var employee = empDbContext.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            empDbContext.SaveChanges();
            return employeeChanges;
        }
    }
}
