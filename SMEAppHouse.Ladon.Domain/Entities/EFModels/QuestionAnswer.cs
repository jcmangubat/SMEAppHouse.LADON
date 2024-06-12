using SMEAppHouse.Core.Patterns.EF.ModelComposites.Abstractions;

namespace SMEAppHouse.Ladon.Domain.Entities.EFModels;

public class QuestionAnswer : GuidKeyedEntity
{
    public required string Question { get; set; } 
    public required string AnswerText { get; set; }
    public bool? IsImportant { get; set; }

    // Foreign key for the one-to-one relationship
    public Guid? RelatedArticleId { get; set; }

    // Navigation property for the one-to-one relationship
    public virtual Article? RelatedArticle { get; set; }
}