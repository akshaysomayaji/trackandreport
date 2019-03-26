using System;
using System.ComponentModel.DataAnnotations;

namespace TrackAndReport.DataModels.Customer
{
    public class Site
    {
        [Key]
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteAddress { get; set; }
        public string SiteContact { get; set; }
        public string Status { get; set; }

    }
}
