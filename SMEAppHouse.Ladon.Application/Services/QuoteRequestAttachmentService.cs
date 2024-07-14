using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Repositories;
using QuoteRequestAttachment = SMEAppHouse.Ladon.Domain.Entities.EFModels.QuoteRequestAttachment;

namespace SMEAppHouse.Ladon.Application.Services;

public class QuoteRequestAttachmentService(ILogger<QuoteRequestAttachmentService> logger, IMapper mapper,
                                IQuoteRequestAttachmentRepository quoteRequestAttachmentRepository)
    : IQuoteRequestAttachmentService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger _logger = logger;
    private readonly IQuoteRequestAttachmentRepository _quoteRequestAttachmentRepository = quoteRequestAttachmentRepository;

    public async Task<QuoteRequestAttachmentModel?> GetAttachmentAsync(Guid quoteRequestAttachmentId)
    {
        try
        {
            var attachment = await _quoteRequestAttachmentRepository.GetSingleAsync(a => a.Id == quoteRequestAttachmentId);
            var qtRqstAtt = _mapper.Map<QuoteRequestAttachmentModel>(attachment);
            return qtRqstAtt;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<QuoteRequestAttachmentModel>?> GetAttachmentsAsync(Guid quoteRequestId)
    {
        try
        {
            var attachments = await _quoteRequestAttachmentRepository.GetListAsync(a => a.QuoteRequestId == quoteRequestId);
            var qtRqstAtts = _mapper.Map<List<QuoteRequestAttachmentModel>>(attachments);
            return qtRqstAtts;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<QuoteRequestAttachmentModel?> AddAttachmentAsync(QuoteRequestAttachmentModel quoteRequestAttachment)
    {
        try
        {
            var qtRqstAtt = _mapper.Map<QuoteRequestAttachment>(quoteRequestAttachment);
            await _quoteRequestAttachmentRepository.AddAsync(qtRqstAtt);
            await _quoteRequestAttachmentRepository.CommitAsync();

            quoteRequestAttachment.Id = qtRqstAtt.Id;
            return quoteRequestAttachment;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateAttachmentAsync(QuoteRequestAttachmentModel quoteRequestAttachment)
    {
        try
        {
            var qtRqstAtt = _mapper.Map<QuoteRequestAttachment>(quoteRequestAttachment);
            await _quoteRequestAttachmentRepository.UpdateAsync(qtRqstAtt);
            await _quoteRequestAttachmentRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}