using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using EmployeeModel;
using System.Data.Entity;
using System.Text;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Employee_Repository.context
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        {
        }
        public System.Data.Entity.DbSet<Model_Of_Employee> Employees
        {
            get; set;
        }
    }
 
}
