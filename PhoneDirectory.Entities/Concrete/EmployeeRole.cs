using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Entities.Concrete
{
    public class EmployeeRole:IdentityRole
    {
        public string Description { get; set; }

        public EmployeeRole()
        {

        }

        public EmployeeRole(string roleName) : base(roleName)
        {
            Description = "";
        }

        public EmployeeRole(string description, string roleName) : base(roleName)
        {
            Description = description;
        }
    }
}
