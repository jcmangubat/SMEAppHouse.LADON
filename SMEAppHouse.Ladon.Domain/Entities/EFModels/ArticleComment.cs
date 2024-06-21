using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

/// <summary>
/// Represents a comment or feedback submitted by a reader.
/// </summary>
public class ArticleComment : GuidKeyedEntity
{
    /// <summary>
    /// The name of the commenter.
    /// </summary>
    public string? AuthorName { get; set; }

    /// <summary>
    /// The email address of the commenter.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// The content of the comment.
    /// </summary>
    public required string CommentText { get; set; }

    // Navigation property to the parent comment;
    // Foreign key to the parent comment (self-referencing)
    public Guid? ParentArticleCommentId { get; set; }
    public ArticleComment? ParentArticleComment { get; set; }

    // Navigation property to child comments
    public ICollection<ArticleComment> ArticleCommentReplies { get; set; } = [];

    public int? Likes { get; set; }
    public int? Dislikes { get; set; }

    public Guid? ArticleId { get; set; }
    public virtual Article? Article { get; set; } // Navigation property

    public Guid? UserProfileId { get; set; }
    public virtual UserProfile? UserProfile { get; set; }
}