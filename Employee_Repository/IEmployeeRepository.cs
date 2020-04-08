// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeRepository.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Employee_Repository
{
    using EmployeeModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Interface of Repository
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// This is GetEmployee method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Model_Of_Employee GetEmployee(int id);

        /// <summary>
        /// This is GetAllEmployees method
        /// </summary>
        /// <returns></returns>
        IEnumerable<Model_Of_Employee> GetAllEmployees();

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<int> AddEmployee(Model_Of_Employee employee);

        /// <summary>
        /// This is Method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        Task<int> UpdateEmployee(Model_Of_Employee employeeChanges);

        /// <summary>
        /// This is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Model_Of_Employee DeleteEmployee(int id);

        bool Login(string email, string password);
    }
}
