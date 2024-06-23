using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleCommentModel : KeyedModel
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
    public ArticleCommentModel? ParentArticleComment { get; set; }

    // Navigation property to child comments
    public ICollection<ArticleCommentModel> ArticleCommentReplies { get; set; } = [];

    public int? Likes { get; set; }
    public int? Dislikes { get; set; }

    public Guid? ArticleId { get; set; }
    public virtual ArticleModel? Article { get; set; } // Navigation property

    public Guid? UserProfileId { get; set; }
    public virtual UserProfileModel? UserProfile { get; set; }
}
