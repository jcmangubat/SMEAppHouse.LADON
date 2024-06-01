using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class QuoteRequestAttachment : GuidKeyedEntity
{
    public required string OriginalFilename { get; set; }
    public string? AssetCDNUrl { get; set; }
    
    
    public required Guid QuoteRequestId { get; set; }

    public required virtual QuoteRequest QuoteRequest { get; set; }
}