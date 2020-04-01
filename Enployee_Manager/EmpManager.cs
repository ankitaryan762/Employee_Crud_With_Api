// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmpManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Enployee_Manager
{
    using Employee_Repository;
    using EmployeeModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this is a manager class just as Business layer
    /// </summary>
    public class EmpManager : IEmpManager
    {
        /// <summary>
        /// this is variable like Repository interface
        /// </summary>
        private readonly IEmployeeRepository emp_Repository;

        /// <summary>
        /// this is Constructor of Manager
        /// </summary>
        /// <param name="emp_Repository"></param>
        public EmpManager(IEmployeeRepository emp_Repository)
        {
            this.emp_Repository = emp_Repository;
        }

        /// <summary>
        /// This is a method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<int> AddEmployee(Model_Of_Employee employee)
        {
            return this.emp_Repository.AddEmployee(employee);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model_Of_Employee DeleteEmployee(int id)
        {
            return this.emp_Repository.DeleteEmployee(id);
        }

        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            return this.emp_Repository.GetAllEmployees();
        }

        /// <summary>
        /// this is s method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model_Of_Employee GetEmployee(int id)
        {
            return this.emp_Repository.GetEmployee(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        public Task<int> UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            return this.emp_Repository.UpdateEmployee(employeeChanges);
        }
    }
}
