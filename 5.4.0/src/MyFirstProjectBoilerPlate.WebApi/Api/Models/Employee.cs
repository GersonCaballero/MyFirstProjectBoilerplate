using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectBoilerPlate.Api.Models
{
    class Employee : Entity
    {
        [Key]
        public virtual int IdEmployee { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Tel { get; set; }

        [ForeignKey(nameof(IdDepartment))]
        public virtual Department Department { get; set; }
        public virtual int IdDepartment { get; set; }

    }
}
