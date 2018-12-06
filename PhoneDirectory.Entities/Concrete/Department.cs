using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PhoneDirectory.Entities.Concrete
{
    public class Department
    {
        public Department()
        {

        }
        public Department(string DepartmentName, int DepartmentNo)
        {
            this.DepartmentName = DepartmentName;
            this.DepartmentNo = DepartmentNo;
            EmployeeCount = 0;
        }
        public Department(string DepartmentName, string DepartmentDescription, int DepartmentNo)
        {
            this.DepartmentName = DepartmentName;
            this.DepartmentDescription = this.DepartmentDescription;
            this.DepartmentNo = DepartmentNo;
            EmployeeCount = 0;
        }


        [Key]
        public string DepartmentID { get; set; }
        [Index(IsUnique = true)]
        public int DepartmentNo { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int EmployeeCount { get; set; }
    }
}
