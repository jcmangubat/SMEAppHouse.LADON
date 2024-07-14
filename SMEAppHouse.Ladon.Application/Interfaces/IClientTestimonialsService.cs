using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IClientTestimonialsService
{
    Task<ClientTestimonyModel?> GetClientTestimonyAsync(Guid clientTestimonyId);

    Task<IEnumerable<ClientTestimonyModel>?> GetClientTestimonialsAsync(Expression<Func<ClientTestimonyModel, bool>> modelFilter);
    Task<IEnumerable<ClientTestimonyModel>?> GetClientTestimonialsAsync(bool? activesOnly = null);
    Task<ClientTestimonyModel?> AddClientTestimonialAsync(ClientTestimonyModel clientTestimonyModel);

    Task UpdateClientTestimonialAsync(ClientTestimonyModel clientTestimonyModel);
}