using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class IndexModel(ILogger<IndexModel> logger, ApplicationSettings applicationSettings, IQuestionAnswerService questionAnswerService)
        : BasePageModel(applicationSettings)
    {
        private readonly IQuestionAnswerService _questionAnswerService = questionAnswerService;

        public IEnumerable<QuestionAnswerModel> RandomQuestionAnswers { get; set; }

        public void OnGet()
        {
            logger.Log(LogLevel.Information, "");
        }

        public async Task<IActionResult> OnGetRandomQuestionAnswersAsync()
        {
            RandomQuestionAnswers = await _questionAnswerService.GetBestTenQAsAsync();

            return Partial("~/Pages/Home/PartialViews/_FAQs.cshtml", RandomQuestionAnswers);
        }
    }
}
