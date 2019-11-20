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
    [Table("Statuses")]
    public class Status
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Please enter the project type")]
        [StringLength(25, MinimumLength = 5)]
        [DisplayName("Project Type")]
        public string StatusDesc { get; set; }
    }
}