using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class QuestionAnswerModel : KeyedModel
{
    public new Guid? Id { get; set; }
    public required string Question { get; set; }
    public required string AnswerText { get; set; }
    public bool? IsImportant { get; set; }
    
    public Guid? RelatedBlogPostId { get; set; }
    public virtual BlogPostModel? RelatedBlogPost { get; set; }
}