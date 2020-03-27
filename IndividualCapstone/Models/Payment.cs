using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividualCapstone.Models
{
    public class Payment
    {
        public string cardNumber { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string cvc { get; set; }
        public int value { get; set; }
    }
}
