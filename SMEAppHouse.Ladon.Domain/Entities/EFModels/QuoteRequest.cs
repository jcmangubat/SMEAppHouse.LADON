using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class QuoteRequest : GuidKeyedEntity
{
    #region Contact Information

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string CompanyName { get; set; }

    public required string EmailAddress { get; set; }
    public string? PhoneNo { get; set; }
    public required string AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? StateOrRegion { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? CountryCode { get; set; }

    #endregion

    #region Project Details

    public required string SiteProjectName { get; set; }
    public string? SiteAddressLine1 { get; set; }
    public string? SiteAddressLine2 { get; set; }
    public string? SiteStateOrRegion { get; set; }
    public string? SiteCity { get; set; }
    public string? SiteZipCode { get; set; }
    public string? SiteCountryCode { get; set; }

    /// <summary>
    /// See: ProjectServiceTypesManager
    /// </summary>
    public ServiceCategoriesEnum? ProjectCategory { get; set; }
    public string? ProjectServiceTypeCode { get; set; }

    #endregion

    #region Timeline

    public DateTime? DesiredStartDate { get; set; }
    public DateTime? DesiredEndDate { get; set; }
    public int? ProjectDurationMonths { get; set; }
    public int? ProjectDurationDays { get; set; }
    public int? ProjectDurationHours { get; set; }

    #endregion

    #region Specifications

    public double? SquareArea { get; set; }
    public LengthUnitsEnum? SquareAreaUoM { get; set; }
    public int? NumberOfFloors { get; set; }
    public required string SpecialRequirementsOrFeatures { get; set; }

    #endregion

    #region Budget Information

    /// <summary>
    /// Minimum amount of the budget range (nullable)
    /// </summary>
    public decimal? BudgetMinAmount { get; set; }

    /// <summary>
    /// Maximum amount of the budget range (nullable)
    /// </summary>
    public decimal? BudgetMaxAmount { get; set; }

    /// <summary>
    /// Specific budget amount (nullable)
    /// </summary>
    public decimal? BudgetSpecificAmount { get; set; }

    #endregion

    #region Additional Information

    /// <summary>
    /// Any Additional Comments or Questions
    /// </summary>
    public string? AdditionalCommentsOrQuestions { get; set; }


    /// <summary>
    /// Preferred Method of Contact
    /// </summary>
    public required ContactMethodPreferencesEnum PreferredCommunicationMethod { get; set; }

    public required ReferralSourcesEnum ReferralSource { get; set; }


    /* submitter (reference to an existing account is optional) */
    public Guid? RequestorUserProfileId { get; set; }

    public virtual UserProfile? RequestorUserProfile { get; set; }

    /// <summary>
    /// Any Attachments or Supporting Documents(e.g., blueprints, site plans)
    /// </summary>
    public virtual List<QuoteRequestAttachment> Attachments { get; set; } = [];

    #endregion
}
