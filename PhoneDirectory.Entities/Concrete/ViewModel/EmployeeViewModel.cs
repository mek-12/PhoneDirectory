using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Entities.Concrete.ViewModel
{
    public class EmployeeViewModel
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string ImageBase64 { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentNo { get; set; }
        public string DepartmentID { get; set; }
    }
}
