using System;
using System.Collections.Generic;

namespace AppEFCore.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Employee> Employee { get; set; }
    }
}
