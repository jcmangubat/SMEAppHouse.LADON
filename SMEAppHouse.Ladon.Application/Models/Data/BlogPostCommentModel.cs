using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class BlogPostCommentModel : KeyedModel
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
}
