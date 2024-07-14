using System.ComponentModel.DataAnnotations;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.ViewModels
{
    public class SignupInputModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [StringLength(10)]
        public string ClientCode { get; set; }

        [StringLength(8)]
        public string Salutation { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        public GendersEnum Gender { get; set; }

        [StringLength(11)]
        public string MobilePhoneNo { get; set; }

        [StringLength(200)]
        public string ThumbnailUrl { get; set; }

        [StringLength(200)]
        public string ProfileImageUrl { get; set; }

        [StringLength(120)]
        public string BusinessInstitutionName { get; set; }

        // Remember Me field
        public bool RememberMe { get; set; }
    }
}