// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Employee_Repository
{
    using Employee_Repository.context;
    using EmployeeModel;
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is implementation class of Repository interface
    /// </summary>
    public class EmployeeRepository :IEmployeeRepository
    {
        /// <summary>
        /// this is a reference variable of EmpDbContext class
        /// </summary>
        private readonly EmpDbContext empDbContext;

        /// <summary>
        /// this is a Contructor
        /// </summary>
        /// <param name="empDbContext"></param>
        public EmployeeRepository(EmpDbContext empDbContext)
        {
            this.empDbContext = empDbContext;
        }

        /// <summary>
        /// This is method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Model_Of_Employee employee)
        {
            empDbContext.Employees.Add(employee);
           var result= empDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// this is method
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            return empDbContext.Employees;
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model_Of_Employee GetEmployee(int id)
        {
            return empDbContext.Employees.Find(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            var employee = empDbContext.Employees.Attach(employeeChanges);
            employee.State = EntityState.Modified;
            var result = empDbContext.SaveChangesAsync();
            return result;
        }
    }
}
