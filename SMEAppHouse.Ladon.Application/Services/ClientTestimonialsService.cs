using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Application.Services;

public class ClientTestimonialsService(IMapper mapper,
                            ILogger<ClientTestimonialsService> logger,
                            IClientTestimonyRepository clientTestimonyRepository) : IClientTestimonialsService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<ClientTestimonialsService> _logger = logger;
    private readonly IClientTestimonyRepository _clientTestimonyRepository = clientTestimonyRepository;

    public async Task<IEnumerable<ClientTestimonyModel>?> GetClientTestimonialsAsync(Expression<Func<ClientTestimonyModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<ClientTestimony, bool>> efModelFilter = ExpressionConverter.Convert<ClientTestimony, ClientTestimonyModel>(modelFilter);
            var testimonials = await _clientTestimonyRepository.GetListAsync(efModelFilter);
            var testimonies = _mapper.Map<List<ClientTestimonyModel>>(testimonials);
            return testimonies;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<ClientTestimonyModel>?> GetClientTestimonialsAsync(bool? activesOnly = null)
    {
        try
        {
            IEnumerable<ClientTestimony> testimonials = [];
            if (activesOnly.HasValue)
                testimonials = await _clientTestimonyRepository.GetListAsync(filter: p => p.IsActive == activesOnly.Value);
            else
                testimonials = await _clientTestimonyRepository.GetListAsync();
            
            var testimonies = _mapper.Map<List<ClientTestimonyModel>>(testimonials);
            return testimonies;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ClientTestimonyModel?> GetClientTestimonyAsync(Guid clientTestimonyId)
    {
        try
        {
            var testimonial = await _clientTestimonyRepository.GetSingleAsync(a => a.Id == clientTestimonyId);
            var testimony = _mapper.Map<ClientTestimonyModel>(testimonial);
            return testimony;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<ClientTestimonyModel?> AddClientTestimonialAsync(ClientTestimonyModel clientTestimonyModel)
    {
        try
        {
            var testimonial = _mapper.Map<ClientTestimony>(clientTestimonyModel);
            await _clientTestimonyRepository.AddAsync(testimonial);
            await _clientTestimonyRepository.CommitAsync();

            clientTestimonyModel.Id = testimonial.Id;
            return clientTestimonyModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateClientTestimonialAsync(ClientTestimonyModel clientTestimonyModel)
    {
        try
        {
            var testimonial = _mapper.Map<ClientTestimony>(clientTestimonyModel);
            await _clientTestimonyRepository.UpdateAsync(testimonial);
            await _clientTestimonyRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}