using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SMEAppHouse.Ladon.Web.Pages;

public class TermsOfUseModel : PageModel
{
    private readonly ILogger<TermsOfUseModel> _logger;

    public TermsOfUseModel(ILogger<TermsOfUseModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

