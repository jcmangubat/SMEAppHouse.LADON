using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels
{
    public class Address : GuidKeyedEntity
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public AddressTypesEnum AddressType { get; set; }
        public Guid UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}