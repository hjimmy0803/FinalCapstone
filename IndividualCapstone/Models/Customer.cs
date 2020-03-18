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
        internal Customer id;

        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("IdentityUSer")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
