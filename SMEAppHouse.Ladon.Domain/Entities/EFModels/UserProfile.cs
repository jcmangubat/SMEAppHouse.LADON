
using System.ComponentModel.DataAnnotations;
using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class UserProfile : GuidKeyedEntity
{
    public Guid IdentityUserId { get; set; }

    [StringLength(10)]
    public string? ClientCode { get; set; }

    [StringLength(8)]
    public string? Salutation { get; set; }

    [StringLength(20)]
    public string FirstName { get; set; }

    [StringLength(20)]
    public string LastName { get; set; }
    public GendersEnum Gender { get; set; }

    [StringLength(11)]
    public string MobilePhoneNo { get; set; }

    [StringLength(200)]
    public string? ThumbnailUrl { get; set; }

    [StringLength(200)]
    public string? ProfileImageUrl { get; set; }

    [StringLength(120)]
    public string? BusinessInstitutionName { get; set; }

    public virtual List<Message> Messages { get; set; } = [];
    public virtual List<Address> Addresses { get; set; } = [];
    public virtual List<ClientTestimony> ClientTestimonies { get; set; } = [];
    public virtual List<Article> Articles { get; set; } = [];
    public virtual List<QuoteRequest> QuoteRequests { get; set; } = [];
    public virtual List<ArticleComment> ArticleComments { get; set; } = [];
}
