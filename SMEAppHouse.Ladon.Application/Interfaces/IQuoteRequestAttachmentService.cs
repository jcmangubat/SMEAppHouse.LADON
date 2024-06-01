using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IQuoteRequestAttachmentService
{
    Task<QuoteRequestAttachmentModel?> GetAttachmentAsync(Guid quoteRequestAttachmentId);
    Task<IEnumerable<QuoteRequestAttachmentModel>?> GetAttachmentsAsync(Guid quoteRequestId);
    Task UpdateAttachmentAsync(QuoteRequestAttachmentModel quoteRequestAttachment);
    Task<QuoteRequestAttachmentModel?> SaveAttachmentAsync(QuoteRequestAttachmentModel quoteRequestAttachment);
}