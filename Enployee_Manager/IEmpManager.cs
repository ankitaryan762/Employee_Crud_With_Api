// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmpManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Enployee_Manager
{
    using EmployeeModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is a interface
    /// </summary>
    public interface IEmpManager
    {
        /// <summary>
        /// this is method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Model_Of_Employee GetEmployee(int id);

        /// <summary>
        /// this is method
        /// </summary>
        /// <returns></returns>
        IEnumerable<Model_Of_Employee> GetAllEmployees();

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        Task<int>  AddEmployee(Model_Of_Employee employee);

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        Task<int> UpdateEmployee(Model_Of_Employee employeeChanges);

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Model_Of_Employee DeleteEmployee(int id);
    }
}
