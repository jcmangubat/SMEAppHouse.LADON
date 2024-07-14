using Microsoft.AspNetCore.Mvc.RazorPages;
using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Web.Pages.Common;

public class BasePageModel(ApplicationSettings applicationSettings) : PageModel
{
    protected readonly ApplicationSettings _applicationSettings = applicationSettings;

    public ApplicationSettings ApplicationSettings => _applicationSettings;
}

public class BasePageModel<TPageModel>(ILogger<TPageModel> logger,
    ApplicationSettings applicationSettings) : PageModel
    where TPageModel : PageModel
{
    protected readonly ILogger<TPageModel> _logger = logger;
    protected readonly ApplicationSettings _applicationSettings = applicationSettings;
}