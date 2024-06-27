using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Core.CodeKits;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Article.Pages;

public class FeatureProjectPageModel(ApplicationSettings applicationSettings,
                            IFeatureProjectService featureProjectService) :
    BasePageModel(applicationSettings)
{
    private readonly IFeatureProjectService _featureProjectService = featureProjectService;
    
    public FeatureProjectModel? FeatureProject { get; set; }

    public async Task<IActionResult> OnGet(string titleSlug)
    {
        var slug = CodeKit.MakeSlug(titleSlug);
        FeatureProject = await _featureProjectService.GetFeatureProjectBySlugAsync(slug)
                                    ?? throw new Exception("Article not found.");

        // Set dynamic meta tags
        ViewData["Title"] = FeatureProject.Title;
        ViewData["Description"] = FeatureProject.Description;

        return Page();
    }
}
