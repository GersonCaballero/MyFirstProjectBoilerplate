using Abp.Domain.Entities;

namespace MyFirstProjectBoilerPlate.Employees
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public Department Department { get; set; }
    }
}
