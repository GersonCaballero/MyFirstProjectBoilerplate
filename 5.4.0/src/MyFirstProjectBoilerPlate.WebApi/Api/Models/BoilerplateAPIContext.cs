using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectBoilerPlate.Api.Models
{
    class BoilerplateAPIContext : AbpDbContext
    {
        public virtual IDbSet<Department> Departments { get; set; }
        public virtual IDbSet<Employee> Employees { get; set; }

        public BoilerplateAPIContext()
        : base("Default")
        {

        }

    }
}
