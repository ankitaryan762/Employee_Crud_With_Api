// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmpDbContext.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Ankit Aryan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Employee_Repository.context
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using EmployeeModel;
    using System.Text;
    using DbContext = Microsoft.EntityFrameworkCore.DbContext;

    /// <summary>
    /// This is DbContext of Employee class
    /// </summary>
    public class EmpDbContext : DbContext
    {
        /// <summary>
        /// this is the Comstructor
        /// </summary>
        /// <param name="options"></param>
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// This is the DbSet of Employee
        /// </summary>
        public Microsoft.EntityFrameworkCore.DbSet<Model_Of_Employee> Employees
        {
            get; set;
        }
    }
}
