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
    //Database inputs will be added later in project 2.
    //[Table("Owner")]
    public class Position
    {
        //[Key]
        //[HiddenInput(DisplayValue = false)]
        public int PositionKey { get; set; }

        [Required(ErrorMessage = "Please enter the position description")]
        [DisplayName("Description")]
        [StringLength(30, MinimumLength = 5)]
        public string PositionDesc { get; set; }

    }
}