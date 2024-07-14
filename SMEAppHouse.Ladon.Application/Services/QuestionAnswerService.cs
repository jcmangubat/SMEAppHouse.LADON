using System.Linq.Expressions;
using AutoMapper;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Helpers.Expressions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;
using SMEAppHouse.Ladon.Domain.Repositories;

namespace SMEAppHouse.Ladon.Application.Services;

public class QuestionAnswerService(IMapper mapper,
                            ILogger<QuestionAnswerService> logger,
                            IQuestionAnswerRepository questionAnswerRepository) : IQuestionAnswerService
{
    private readonly IMapper _mapper = mapper;
    private readonly ILogger<QuestionAnswerService> _logger = logger;
    private readonly IQuestionAnswerRepository _questionAnswerRepository = questionAnswerRepository;

    public async Task<QuestionAnswerModel?> GetQuestionAnswerAsync(Guid questionAnswerId)
    {
        try
        {
            var questionAnswer = await _questionAnswerRepository.GetSingleAsync(a => a.Id == questionAnswerId);
            var blgPost = _mapper.Map<QuestionAnswerModel>(questionAnswer);
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
            var questionAnswers = await _questionAnswerRepository.GetListAsync(efModelFilter);
            var blgPosts = _mapper.Map<List<QuestionAnswerModel>>(questionAnswers);
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
            var qaList = (await _questionAnswerRepository.GetListAsync(efModelFilter)).ToList();
            var nonImportantQAs = (await _questionAnswerRepository.GetListRandomAsync(efModelFilter, 12 - qaList.Count())).ToList();
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

    public async Task<QuestionAnswerModel?> AddQuestionAnswerAsync(QuestionAnswerModel questionAnswerModel)
    {
        try
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerModel);
            await _questionAnswerRepository.AddAsync(questionAnswer);
            await _questionAnswerRepository.CommitAsync();

            questionAnswerModel.Id = questionAnswer.Id;
            return questionAnswerModel;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task UpdateQuestionAnswerAsync(QuestionAnswerModel questionAnswerModel)
    {
        try
        {
            var questionAnswer = _mapper.Map<QuestionAnswer>(questionAnswerModel);
            await _questionAnswerRepository.UpdateAsync(questionAnswer);
            await _questionAnswerRepository.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}