using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        [DisplayName("Employee ID")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter the employee's first name.")]
        [DisplayName("First Name")]
        public string EmpFirstName { get; set; }

        [Required(ErrorMessage = "Please enter the employee's last name.")]
        [DisplayName("Last Name")]
        public string EmpLastName { get; set; }

        [Required(ErrorMessage = "Please enter the employee's email address.")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Please enter the employee's phone number.")]
        [StringLength(10)]
        [DisplayName("Phone Number")]
        public string EmpPhone { get; set; }

        [DisplayName("Wage")]
        public double EmpWage { get; set; }

        [DisplayName("Password")]
        public string EmpPassword { get; set; }

        [DisplayName("Position ID")]
        public int PositionID { get; set; }



    }
}