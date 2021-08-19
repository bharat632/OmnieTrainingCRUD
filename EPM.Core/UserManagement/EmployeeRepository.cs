using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPM.Core.UserManagement
{
    public class EmployeeRepository
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Employee Name is required..")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Employee Code is required..")]
        public string EmpCode { get; set; }

        [Required(ErrorMessage = "Email is required..")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is required..")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
