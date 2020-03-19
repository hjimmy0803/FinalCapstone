using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndividualCapstone.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Monthly Service")]
        public DateTime MonthlySerice { get; set; }

        [Display(Name = "Bi Monthly Service")]
        public DateTime BiMonthlyService { get; set; }

        [Display(Name = "Quarterly Service")]
        public DateTime QuarterlyService { get; set; }

        

    }
}
