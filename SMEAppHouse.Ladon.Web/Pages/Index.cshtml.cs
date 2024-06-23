using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

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
            
        }

        public async Task<IActionResult> OnGetRandomQuestionAnswersAsync()
        {
            RandomQuestionAnswers = await _questionAnswerService.GetBestTenQAsAsync();
            return Partial("~/Pages/Home/PartialViews/_FAQs.cshtml", RandomQuestionAnswers);
        }

        public async Task<IActionResult> OnGetOfferedServicesAsync()
        {
            var offeredServices = OpenOfferedServicesJson();
            return Partial("~/Pages/Home/PartialViews/_Services.cshtml", offeredServices);
        }

        public async Task<IActionResult> OnGetLatestBlogArticlesAsync()
        {
            var blogs = await _articleService.GetArticlesAsync(10);

            return Partial("~/Pages/Home/PartialViews/_Blogs.cshtml", blogs);
        }

        public async Task<IActionResult> OnGetClientTestimonialsAsync()
        {
            var testimonials = await _clientTestimonialsService.GetClientTestimonialsAsync(activesOnly: true);

            return Partial("~/Pages/Home/PartialViews/_Testimonials.cshtml", testimonials);
        }

        private static List<ServiceItem> OpenOfferedServicesJson()
        {
            var jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OfferedServices.json");
            if (!System.IO.File.Exists(jsonFilePath))
                throw new FileNotFoundException("The OfferedServices.json file was not found in the root of the project folder.");

            var jsonData = System.IO.File.ReadAllText(jsonFilePath);
            var offeredServices = JsonConvert.DeserializeObject<List<ServiceItem>>(jsonData);
            return offeredServices;
        }
    }
}
