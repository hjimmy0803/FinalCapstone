using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndividualCapstone.Models
{
    public class TypeOfService
    {
        [Key]
       public int Id { get; set; }

        [Display(Name = "Rats")]
        public bool Rats { get; set; }

        [Display(Name = "Ants")]
        public bool Ants { get; set; }

        [Display(Name = "Wasps")]
        public bool Wasps { get; set; }

        [Display(Name = "Bees")]
        public bool Bees { get; set; }

        [Display(Name = "Waterbugs")]
        public bool Waterbugs { get; set; }

        [Display( Name = "Bedbugs")]
        public bool Bedbugs { get; set; }

        [Display(Name = "Earwigs")]
        public bool Earwigs { get; set; }

        [Display(Name = "Silverfish")]
        public bool Silverfish { get; set; }

        [Display(Name = "Yellow Jackets")]
        public bool YellowJackets { get; set; }

        [Display(Name = "Mice")]
        public bool Mice { get; set; }

        [Display(Name = "Spiders")]
        public bool  Spiders { get; set; }

        [Display(Name = "Roaches")]
        public bool Roaches { get; set; }

    }

}
