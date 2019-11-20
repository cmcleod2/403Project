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
    [Table("Clients")]
    public class Client
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int ClientID { get; set; }

        [Required(ErrorMessage = "Please Enter Client First Name")]
        [DisplayName("Client First Name")]
        public string ClFirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Client Last Name")]
        [DisplayName("Client Last Name")]
        public string ClLastName { get; set; }

        [Required(ErrorMessage = "Please Enter Client Phone Number")]
        [DisplayName("Client Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string ClPhone { get; set; }

        [Required(ErrorMessage = "Please Enter Client Email")]
        [DisplayName("Client Email")]
        [DataType(DataType.EmailAddress)]
        public string ClEmail { get; set; }
    }
}