using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : BasePageModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger, ApplicationSettings applicationSettings)
            : base(applicationSettings)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }

}
