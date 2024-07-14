using SMEAppHouse.Core.Patterns.EF.ModelComposites.Interfaces;

namespace SMEAppHouse.Ladon.Application.Models.Base;

public class KeyedModel : IEntityKeyedArchivable<Guid>
{
    public Guid Id { get; set; }
    public bool? IsActive { get; set; } = true;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateModified { get; set; } = DateTime.Now;
    public bool? IsArchived { get; set; }
    public DateTime? DateArchived { get; set; }
    public string? ReasonArchived { get; set; }
}
