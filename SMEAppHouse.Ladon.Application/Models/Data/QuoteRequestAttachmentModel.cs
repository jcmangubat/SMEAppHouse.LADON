using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class QuoteRequestAttachmentModel : KeyedModel
{
    public required string OriginalFilename { get; set; }
    public string? AssetCDNUrl { get; set; }

    public required Guid QuoteRequestId { get; set; }
}