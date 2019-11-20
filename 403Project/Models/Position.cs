using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _403Project.Models
{
    //[Table("Owner")]
    public class Position
    {
        //[Key]
        //[HiddenInput(DisplayValue = false)]
        public int PositionID { get; set; }

        //[Required(ErrorMessage = "Please enter the position description"]
        //[DisplayName("Position Description")]
        //[StringLength(30, minimum = 5)]
        public string PositionDesc { get; set; }

    }
}