using System.Linq.Expressions;
using SMEAppHouse.Ladon.Application.Models.Data;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IQuestionAnswerService
{
    Task<QuestionAnswerModel?> GetQuestionAnswerAsync(Guid questionAnswerId);

    Task<IEnumerable<QuestionAnswerModel>?> GetQuestionAnswersAsync(Expression<Func<QuestionAnswerModel, bool>> modelFilter);
    Task<IEnumerable<QuestionAnswerModel>?> GetBestTenQAsAsync();
    Task<QuestionAnswerModel?> AddQuestionAnswerAsync(QuestionAnswerModel questionAnswerModel);

    Task UpdateQuestionAnswerAsync(QuestionAnswerModel questionAnswerModel);
}
