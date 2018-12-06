using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneDirectory.Entities.Concrete
{
    public class Employee:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePhoto { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public string DepartmentID { get; set; }
        public Department Department { get; set; }
    }
}
