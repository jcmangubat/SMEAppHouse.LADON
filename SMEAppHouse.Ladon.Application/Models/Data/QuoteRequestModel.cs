using System.ComponentModel.DataAnnotations;
using SMEAppHouse.Ladon.Application.Models.Base;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class QuoteRequestModel : KeyedModel
{
    [Display(Name = "First Name")]
    public required string FirstName { get; set; }

    [Display(Name = "Last Name")]
    public required string LastName { get; set; }

    [Display(Name = "Company or your business name")]
    public string? CompanyName { get; set; }

    [Display(Name = "Email address")]
    [EmailAddress]
    public required string EmailAddress { get; set; }

    [Display(Name = "Phone Number")]
    public string? PhoneNo { get; set; }

    [Display(Name = "Contact Preference")]
    public ContactMethodPreferencesEnum ContactPreference { get; set; }

    [Display(Name = "Address")]
    public string? Address { get; set; }

    [Display(Name = "City")]
    public string? City { get; set; }

    [Display(Name = "Zip Code")]
    public string? ZipCode { get; set; }

    [Display(Name = "State / Region")]
    public string? StateOrRegion { get; set; }

    [Display(Name = "Country")]
    public string? CountryCode { get; set; }

    [Display(Name = "Site Project Name")]
    public required string SiteProjectName { get; set; }

    [Display(Name = "Service Category")]
    public ServiceCategoriesEnum? ServiceCategory { get; set; }

    [Display(Name = "Service Type")]
    public string? ServiceCode { get; set; }

    [Display(Name = "Site address is same as above")]
    public bool SiteAddressSameAsResidential { get; set; }

    [Display(Name = "Site Address")]
    public string? SiteAddress { get; set; }

    [Display(Name = "Site City")]
    public string? SiteCity { get; set; }

    [Display(Name = "Site Zip Code")]
    public string? SiteZipCode { get; set; }

    [Display(Name = "Site State or Region")]
    public string? SiteStateOrRegion { get; set; }

    [Display(Name = "Site Country")]
    public string? SiteCountryCode { get; set; }

    [Display(Name = "Desired Start Date")]
    public DateTime? DesiredStartDate { get; set; }

    [Display(Name = "Desired End Date")]
    public DateTime? DesiredEndDate { get; set; }

    [Display(Name = "Months")]
    public int? DurationMonths { get; set; }

    [Display(Name = "Days")]
    public int? DurationDays { get; set; }

    [Display(Name = "Hours")]
    public int? DurationHours { get; set; }

    [Display(Name = "Site area (in square meters)")]
    public double? SquareArea { get; set; }

    [Display(Name = "Number of Floors")]
    public int? NumberOfFloors { get; set; }

    [Display(Name = "Please describe your specific requirements or features")]
    public required string SpecialRequirementsOrFeatures { get; set; }

    [Display(Name = "Minimum Budget Amount")]
    public double? MinimumBudgetAmount { get; set; }

    [Display(Name = "Maximum Budget Amount")]
    public double? MaximumBudgetAmount { get; set; }

    [Display(Name = "Specific Budget Amount")]
    public double? SpecificBudgetAmount { get; set; }

    [Display(Name = "Additional comments or questions")]
    public string? AdditionalCommentsOrQuestions { get; set; }

    [Display(Name = "Where did you hear us from?")]
    public required ReferralSourcesEnum ReferralSource { get; set; }

    public Guid? RequestorUserProfileId { get; set; }

    public string FullName => $"{FirstName} {LastName}".Trim();
}
