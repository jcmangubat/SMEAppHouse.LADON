using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMEAppHouse.Core.Patterns.EF.Helpers;
using SMEAppHouse.Core.Patterns.EF.ModelCfgAbstractions;
using SMEAppHouse.Ladon.Domain.Constants;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Infrastructure.Persistence.Configurations;

public class QuoteRequestConfiguration(string schema = "dbo") 
    : EntityConfiguration<QuoteRequest, Guid>(prefixEntityNameToId: true, 
        prefixAltTblNameToEntity: false, schema: schema, pluralizeTblName: true)
{
    public override void OnModelCreating(EntityTypeBuilder<QuoteRequest> entityBuilder)
    {
        entityBuilder.DefineDbField(x => x.FirstName, true, FieldLengths.QuoteRequest.FirstName);
        entityBuilder.DefineDbField(x => x.LastName, true, FieldLengths.QuoteRequest.LastName);
        entityBuilder.DefineDbField(x => x.CompanyName, false, FieldLengths.QuoteRequest.CompanyName);
        entityBuilder.DefineDbField(x => x.EmailAddress, true, FieldLengths.QuoteRequest.EmailAddress);
        entityBuilder.DefineDbField(x => x.PhoneNo, false, FieldLengths.QuoteRequest.PhoneNumber);
        entityBuilder.DefineDbField(x => x.AddressLine1, true, FieldLengths.QuoteRequest.AddressLine1);
        entityBuilder.DefineDbField(x => x.AddressLine2, false, FieldLengths.QuoteRequest.AddressLine2);
        entityBuilder.DefineDbField(x => x.StateOrRegion, false, FieldLengths.QuoteRequest.StateOrRegion);
        entityBuilder.DefineDbField(x => x.ZipCode, false, FieldLengths.QuoteRequest.ZipCode);
        entityBuilder.DefineDbField(x => x.City, false, FieldLengths.QuoteRequest.City);
        entityBuilder.DefineDbField(x => x.CountryCode, false, FieldLengths.QuoteRequest.CountryCode);

        entityBuilder.DefineDbField(x => x.SiteProjectName, true, FieldLengths.QuoteRequest.SiteProjectName);
        entityBuilder.DefineDbField(x => x.SiteAddressLine1, true, FieldLengths.QuoteRequest.SiteAddressLine1);
        entityBuilder.DefineDbField(x => x.SiteAddressLine2, false, FieldLengths.QuoteRequest.SiteAddressLine2);
        entityBuilder.DefineDbField(x => x.SiteStateOrRegion, false, FieldLengths.QuoteRequest.SiteStateOrRegion);
        entityBuilder.DefineDbField(x => x.SiteCity, false, FieldLengths.QuoteRequest.SiteCity);
        entityBuilder.DefineDbField(x => x.SiteZipCode, false, FieldLengths.QuoteRequest.SiteZipCode);
        entityBuilder.DefineDbField(x => x.SiteCountryCode, false, FieldLengths.QuoteRequest.SiteCountry);
        entityBuilder.DefineDbField(x => x.ProjectCategory, false);
        entityBuilder.DefineDbField(x => x.ProjectServiceTypeCode, false, FieldLengths.QuoteRequest.ProjectServiceTypeCode);

        entityBuilder.DefineDbField(x => x.DesiredStartDate, false);
        entityBuilder.DefineDbField(x => x.DesiredEndDate, false);
        entityBuilder.DefineDbField(x => x.ProjectDurationMonths, false);
        entityBuilder.DefineDbField(x => x.ProjectDurationDays, false);
        entityBuilder.DefineDbField(x => x.ProjectDurationHours, false);

        entityBuilder.DefineDbField(x => x.SquareArea, false);
        entityBuilder.DefineDbField(x => x.SquareAreaUoM, false);
        entityBuilder.DefineDbField(x => x.NumberOfFloors, false);
        entityBuilder.DefineDbField(x => x.SpecialRequirementsOrFeatures, false, FieldLengths.QuoteRequest.SpecialRequirementsOrFeatures);

        entityBuilder.DefineDbField(x => x.BudgetMinAmount, false, 0, null, "decimal(18,2)");
        entityBuilder.DefineDbField(x => x.BudgetMaxAmount, false, 0, null, "decimal(18,2)");
        entityBuilder.DefineDbField(x => x.BudgetSpecificAmount, false, 0, null, "decimal(18,2)");

        entityBuilder.DefineDbField(x => x.AdditionalCommentsOrQuestions, false, FieldLengths.QuoteRequest.AdditionalCommentsOrQuestions);
        entityBuilder.DefineDbField(x => x.PreferredCommunicationMethod, true);
        entityBuilder.DefineDbField(x => x.ReferralSource, true);

        entityBuilder.DefineDbField(x => x.RequestorUserProfileId, false);
        entityBuilder.HasOne(p => p.RequestorUserProfile)
                        .WithMany(p => p.QuoteRequests)
                        .HasForeignKey(p => p.RequestorUserProfileId)
                        .IsRequired(false);

        base.OnModelCreating(entityBuilder);
    }
}
