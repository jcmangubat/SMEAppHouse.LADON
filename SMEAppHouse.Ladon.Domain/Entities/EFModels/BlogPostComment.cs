using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

/// <summary>
/// Represents a comment or feedback submitted by a reader.
/// </summary>
public class BlogPostComment : GuidKeyedEntity
{
    /// <summary>
    /// The name of the commenter.
    /// </summary>
    public required string AuthorName { get; set; }

    /// <summary>
    /// The email address of the commenter.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The content of the comment.
    /// </summary>
    public required string CommentText { get; set; }

    public Guid? BlogPostId { get; set; }
    public virtual BlogPost? BlogPost { get; set; } // Navigation property
}
