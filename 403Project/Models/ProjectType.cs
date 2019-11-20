using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project.Models
{
    //[Table("ProjectType")]
    public class ProjectType
    {
        //[Key]
        //[HiddenInput(DisplayValue = false)]
        public int PTypeID { get; set; }

        //[Required(ErrorMessage = "Please enter the project type")]
        //[StringLength(25, MinimumLength = 5)]
        //[DisplayName("Project Type")]
        public string PType { get; set; }
    }
}