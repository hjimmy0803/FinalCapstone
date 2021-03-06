﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IndividualCapstone.Models
{
    public class Customer
    {
        

        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [Display (Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display (Name = "Final Pay")]
        public int FinalPay { get; set; }

        [Display (Name = "Estimated Amount")]
        public double EstimatedAmount { get; set; }

        [Display (Name = "Service Denied")]
        public bool ServiceDenied { get; set; }

        [Display (Name = "Service Accepted")]
        public bool ServiceAccepted { get; set; }


        [ForeignKey("IdentityUSer")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("Address")]
        [Display(Name = "Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Account")]
        [Display(Name = "Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [ForeignKey("TypeOfService")]
        [Display(Name = "Type Of Service")]
        public int TypeOfServiceId { get; set; }
        public TypeOfService TypeOfService { get; set; }

      




    }
}
