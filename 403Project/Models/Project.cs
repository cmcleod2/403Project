using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _403Project.Models
{
    //[Table("Projects")]
    public class Project
    {
        //[Key]
        //[DisplayName("Project ID")]
        //[HiddenInput(DisplayValue = false)]
        public int ProjectID { get; set; }

        //[Required]
        //[DisplayName("Budgeted Hours")]
        public float BudgetedHours { get; set; }

        //[DisplayName("Actual Hours")]
        public float? ActualHours { get; set; }

        //[Required]
        //[DisplayName("Budgeted Calendar Days")]
        public float BudgetedCalDays { get; set; }

        //[DisplayName("Actual Calendar Days")]
        public float ActualCalDays { get; set; }

        //[DisplayName("Deposit Date")]
        public DateTime? DepositDate { get; set; }

        //[DisplayName("Begin Date")]
        public DateTime? BeginDate { get; set; }

        //[DisplayName("Date Completed")]
        public DateTime? CompletedDate { get; set; }

        //[DisplayName("Date Paid")]
        public DateTime? PaidDate { get; set; }

        //[DisplayName("Date Delivered")]
        public DateTime? DeliveredDate { get; set; }

        //[DisplayName("Bid price")]
        public float? BidPrice { get; set; }

        //[DisplayName("Final Price")]
        public float? ProjectPrice { get; set; }

        //[Required]
        //[DisplayName("Deposit Paid")]
        public Boolean DepositPaid { get; set; }

        //[Required]
        //[DisplayName("Paid in Full")]
        public Boolean PaidInFull { get; set; }

        //[DisplayName("Square Footage")]
        public float? SquareFoot { get; set; }

        //[DisplayName("Deck Size Square Footage")]
        public float? DeckSize { get; set; }

        //[DisplayName("Hand Framed Living Space Roof")]
        public Boolean? HandFramedLivRoof { get; set; }

        //[DisplayName("Structure in Snow Country")]
        public Boolean? SnowCountry { get; set; }

        //[DisplayName("Insulated Concrete Forms")]
        public Boolean? InsConcreteForms { get; set; }

        //[DisplayName("Client ID")]
        public int? ClientID { get; set; }

        //[DisplayName("Structure Type ID")]
        public int? STypeID { get; set; }

        //[DisplayName("Project Type ID")]
        public int? PTypeID { get; set; }

        //[DisplayName("Status ID")]
        public int? StatusID { get; set; }


    }
}