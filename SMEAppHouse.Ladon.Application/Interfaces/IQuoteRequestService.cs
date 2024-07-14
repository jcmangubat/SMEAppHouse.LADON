using SMEAppHouse.Ladon.Application.Models.Data;
using QuoteRequestModel = SMEAppHouse.Ladon.Application.Models.Data.QuoteRequestModel;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IQuoteRequestService
{
    Task<QuoteRequestModel> GetQuoteRequestAsync(Guid id);
    Task<IEnumerable<QuoteRequestModel>> GetQuoteRequestsAsync();
    Task<MessageModel?> GetMessageFromQuoteRequestAsync(Guid id);
    Task<QuoteRequestModel> AddQuoteRequestAsync(QuoteRequestModel message);
}
