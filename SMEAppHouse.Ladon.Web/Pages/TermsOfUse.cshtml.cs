using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Pages;

public class TermsOfUseModel(ILogger<TermsOfUseModel> logger, ApplicationSettings applicationSettings) :
    BasePageModel(applicationSettings)
{
    private readonly ILogger<TermsOfUseModel> _logger = logger;

    public void OnGet()
    {
    }
}

