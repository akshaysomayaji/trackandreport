using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackAndReport.DataModels.Core
{
    public class UserMembership
    {
        public UserMembership()
        {
            Active = true;
            RecordStatus = 1;
            UpdatedOn = DateTime.Now;
            UpdatedBy = -1;
            IsApproved = false;
            IsLockout = false;
            IsExpired = false;
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Active")]
        public Boolean Active { get; set; }

        [Required]
        [Display(Name = "Record Status")]
        public int RecordStatus { get; set; }

        [Required]
        [Display(Name = "Updated On")]
        public DateTime UpdatedOn { get; set; }

        [Required]
        [Display(Name = "Updated By")]
        public long UpdatedBy { get; set; }

        [Display(Name = "Additional Info")]
        public string AdditionalInfo { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Salt Value")]
        public string SaltValue { get; set; }

        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Is Approved")]
        public Boolean IsApproved { get; set; }

        [Required]
        [Display(Name = "Is Lockout")]
        public Boolean IsLockout { get; set; }

        [Required]
        [Display(Name = "Is Expired")]
        public Boolean IsExpired { get; set; }
    }
}
