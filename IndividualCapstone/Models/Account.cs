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

        [Display(Name = "Suspend Service")]
        public bool IsSuspended { get; set; }

        

    }
}
