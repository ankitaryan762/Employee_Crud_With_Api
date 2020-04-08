// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeManagement.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeModel;
    using Enployee_Manager;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Serilog;

    /// <summary>
    /// This is controller 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// this is reference of type IEmpManager
        /// </summary>
        public readonly IEmpManager manager;

        /// <summary>
        /// this is contructor
        /// </summary>
        /// <param name="manager"></param>
        public EmployeeController(IEmpManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// This is method
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("Api/AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Model_Of_Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Api/DeleteEmployee")]
        public Model_Of_Employee DeleteEmployee(int id)
        {
            Log.Information("Employee Deleted");
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Model_Of_Employee GetEmployee(int id)
        {
            Log.Information("Employee details are loaded");
            return this.manager.GetEmployee(id);
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        [Route("Api/UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Model_Of_Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                Log.Information("Existing Employee Updated");
                return this.Ok(employeeChanges);
            }
            else
            {
                Log.Error("This is a Bad Request");
                return this.BadRequest();
            }
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <returns></returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Model_Of_Employee> GetAllEmployees()
        {
            Log.Information("All Employees loaded");
            return this.manager.GetAllEmployees();
        }

        /// <summary>
        /// this is method
        /// </summary>
        /// <returns></returns>
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            var result = this.manager.Login(email, password);

            if (result)
            {
                return Ok(email);
            }
            return this.BadRequest();
        }
    }
}