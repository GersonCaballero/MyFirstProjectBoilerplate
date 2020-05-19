using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectBoilerPlate.Api.Models
{
    class Department : Entity
    {
        [Key]
        public virtual int IdDepartment { get; set; }
        public virtual string Name { get; set; }

    }
}
