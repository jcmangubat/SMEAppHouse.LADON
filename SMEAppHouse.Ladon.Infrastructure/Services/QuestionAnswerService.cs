using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;
using SMEAppHouse.Ladon.Infrastructure.Helpers;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class QuestionAnswerService(IMapper mapper,
                            ILogger<QuestionAnswerService> logger,
                            IQuestionAnswerRepository QuestionAnswerRepository) : IQuestionAnswerService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<QuestionAnswerService> _logger = logger;
    private readonly IQuestionAnswerRepository _QuestionAnswerRepository = QuestionAnswerRepository;

    public async Task<QuestionAnswerModel?> GetQuestionAnswerAsync(Guid QuestionAnswerId)
    {
        try
        {
            var QuestionAnswer = await _QuestionAnswerRepository.GetSingleAsync(a => a.Id == QuestionAnswerId);
            var blgPost = _mapper.Map<QuestionAnswerModel>(QuestionAnswer);
            return blgPost;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<QuestionAnswerModel>?> GetQuestionAnswersAsync(Expression<Func<QuestionAnswerModel, bool>> modelFilter)
    {
        try
        {
            Expression<Func<QuestionAnswer, bool>> efModelFilter = ExpressionConverter.Convert<QuestionAnswer, QuestionAnswerModel>(modelFilter);
            var QuestionAnswers = await _QuestionAnswerRepository.GetListAsync(efModelFilter);
            var blgPosts = _mapper.Map<List<QuestionAnswerModel>>(QuestionAnswers);
            return blgPosts;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<QuestionAnswerModel>?> GetBestTenQAsAsync()
    {
        try
        {
            Expression<Func<QuestionAnswer, bool>> efModelFilter = ExpressionConverter.Convert<QuestionAnswer, QuestionAnswerModel>(qa => qa.IsImportant == true);
            var qaList = (await _QuestionAnswerRepository.GetListAsync(efModelFilter)).ToList();
            var nonImportantQAs = (await _QuestionAnswerRepository.GetListRandomAsync(efModelFilter, 12 - qaList.Count())).ToList();
            qaList.AddRange(nonImportantQAs);

            var blgPosts = _mapper.Map<List<QuestionAnswerModel>>(qaList);
            return blgPosts;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<QuestionAnswerModel?> SaveQuestionAnswerAsync(QuestionAnswerModel questionAnswerModel)
    {
        try
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerModel);
            await _QuestionAnswerRepository.AddAsync(questionAnswer);
            await _QuestionAnswerRepository.CommitAsync();

            questionAnswerModel.Id = questionAnswer.Id;
            return questionAnswerModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateQuestionAnswerAsync(QuestionAnswerModel QuestionAnswerModel)
    {
        try
        {
            var QuestionAnswer = _mapper.Map<QuestionAnswer>(QuestionAnswerModel);
            await _QuestionAnswerRepository.UpdateAsync(QuestionAnswer);
            await _QuestionAnswerRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}