using System;
using System.ComponentModel.DataAnnotations;

namespace TrackAndReport.DataModels.Customer
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerState { get; set; }
        public string CustomerDetails { get; set; }
        public string CustomerContactNumber { get; set; }
        public string Status { get; set; }

    }
}
