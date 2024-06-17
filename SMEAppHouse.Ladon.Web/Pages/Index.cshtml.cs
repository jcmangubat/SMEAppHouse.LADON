using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages
{
    public class IndexModel(ILogger<IndexModel> logger, ApplicationSettings applicationSettings,
                            IQuestionAnswerService questionAnswerService,
                            IArticleService articleService,
                            IClientTestimonialsService clientTestimonialsService)
        : BasePageModel(applicationSettings)
    {
        private readonly IArticleService _articleService = articleService;
        private readonly IQuestionAnswerService _questionAnswerService = questionAnswerService;
        private readonly IClientTestimonialsService _clientTestimonialsService = clientTestimonialsService;

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

        public async Task<IActionResult> OnGetLatestBlogArticlesAsync()
        {
            var blogs = await _articleService.GetBlogsAsync(10);

            return Partial("~/Pages/Home/PartialViews/_Blogs.cshtml", blogs);
        }

        public async Task<IActionResult> OnGetClientTestimonialsAsync()
        {
            var testimonials = await _clientTestimonialsService.GetClientTestimonialsAsync(activesOnly: true);

            return Partial("~/Pages/Home/PartialViews/_Testimonials.cshtml", testimonials);
        }
    }
}
