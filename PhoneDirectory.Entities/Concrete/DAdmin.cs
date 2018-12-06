using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneDirectory.Entities.Concrete
{
    public class DAdmin
    {
        public DAdmin()
        {

        }

        public DAdmin(string EmployeeID, string DepartmentID)
        {
            Id = EmployeeID;
            this.DepartmentID = DepartmentID;
        }

        [Key]
        [ForeignKey("Employee")]
        public string Id { get; set; }
        [ForeignKey("Department")]
        public string DepartmentID { get; set; }
        public Department Department { get; set; }

        public Employee Employee { get; set; }
    }
}
