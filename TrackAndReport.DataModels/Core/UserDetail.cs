using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackAndReport.DataModels.Core
{
    public class UserDetail
    {
        public UserDetail()
        {
            Active = true;
            RecordStatus = 1;
            UpdatedOn = DateTime.Now;
            UpdatedBy = -1;
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
        [ForeignKey("UserDetail_UserMembership")]
        public long UserMembership_Id { get; set; }
        public UserMembership UserDetail_UserMembership { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Password Format")]
        public int PasswordFormat { get; set; }

        [Display(Name = "Salt Password")]
        public string SaltPassword { get; set; }

        [Display(Name = "Mobile Pin")]
        public string MobilePin { get; set; }
    }
}
