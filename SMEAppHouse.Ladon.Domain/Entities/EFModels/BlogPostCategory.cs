namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class BlogPostCategory
{
    public Guid Id { get; set; }

    public required Guid BlogPostId { get; set; }
    public virtual required BlogPost BlogPost { get; set; }

    public required Guid BlogCategoryId { get; set; }
    public virtual required BlogCategory BlogCategory { get; set; }
}