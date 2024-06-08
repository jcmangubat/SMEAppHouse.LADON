
namespace SMEAppHouse.Ladon.Application.Models;

public class QuestionAnswerModel
{
    public required string Question { get; set; }
    public required string AnswerText { get; set; }
    public bool? IsImportant { get; set; }
    public Guid? Id { get; set; }
}