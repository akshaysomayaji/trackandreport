using System;
using System.ComponentModel.DataAnnotations;

namespace TrackAndReport.DataModels.Customer
{
    public class Press
    {
        [Key]
        public int PressId { get; set; }
        public string PressName { get; set; }
        public string PressAddress { get; set; }
        public string PressContact { get; set; }
        public string PressVersion { get; set; }
        public DateTime PressDate { get; set; }
        public DateTime LastConnected { get; set; }
        public DateTime InstalledDate { get; set; }
    }
}
