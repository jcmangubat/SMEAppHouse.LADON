using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Core.CodeKits.Extensions;
using SMEAppHouse.Core.CodeKits.Geo;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Infrastructure.Interfaces;
using SMEAppHouse.Ladon.Web.Extensions;
using SMEAppHouse.Ladon.Web.Pages.Common;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Web.Pages;

public class QuoteRequestPageModel(ILogger<QuoteRequestPageModel> logger,
                                ApplicationSettings applicationSettings,
                                IProjectServiceTypesManager serviceTypesManager,
                                IMessageService messageService,
                                IQuoteRequestService quoteRequestService,
                                IQuoteRequestAttachmentService quoteRequestAttachmentService,
                                IHttpContextAccessor httpContextAccessor,
                                IAuthMembershipService authService,
                                IValidator<QuoteRequestModel> validator,
                                IImageKitUploadService imageKitUploadService)
    : BasePageModel(applicationSettings)
{
    private readonly ILogger<QuoteRequestPageModel> _logger = logger;
    private readonly IValidator<QuoteRequestModel> _validator = validator;
    private readonly IProjectServiceTypesManager _serviceTypesManager = serviceTypesManager;
    private readonly IMessageService _messageService = messageService;
    private readonly IQuoteRequestService _quoteRequestService = quoteRequestService;
    private readonly IQuoteRequestAttachmentService _quoteRequestAttachmentService = quoteRequestAttachmentService;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;
    private readonly IAuthMembershipService _authService = authService;
    private readonly IImageKitUploadService _imageKitUploadService = imageKitUploadService;

    [BindProperty]
    public QuoteRequestModel QuoteRequest { get; set; }

    [BindProperty]
    public List<IFormFile> FormFiles { get; set; }

    public IEnumerable<DropdownItem> ReferralSources { get; set; } = [];
    public IEnumerable<DropdownItem> ServiceCategories { get; set; } = [];
    public IEnumerable<DropdownItem> Countries { get; set; } = [];

    public string? ErrorMessage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public void OnGet()
    {
        ReferralSources = DropdownItem.Get<ReferralSourcesEnum>();
        ServiceCategories = DropdownItem.Get<ServiceCategoriesEnum>();
        Countries = GeoKit.CountryInfos
                        .OrderBy(c => c.Name)
                        .Select(countryInf => new DropdownItem
                        {
                            Value = countryInf.Code,
                            Description = countryInf.Name
                        })
                        .ToList();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="category"></param>
    /// <returns></returns>
    public JsonResult OnGetServiceCodes(ServiceCategoriesEnum category)
    {
        var serviceTypes = _serviceTypesManager.GetServices(category);
        var services = serviceTypes.Select(s => new DropdownItem
        {
            Value = s.Code,
            Description = s.Description
        })
                        .Where(p => p.Description.NotEqualsCaseInsensitive("other") &&
                                    p.Description.NotEqualsCaseInsensitive("others"))
                        .OrderBy(p => p.Description)
                        .ToList();
        var otherServiceType = serviceTypes.Select(s => new DropdownItem
        {
            Value = s.Code,
            Description = s.Description
        }).FirstOrDefault(p => p.Description.EqualsCaseInsensitive("other") ||
                                    p.Description.EqualsCaseInsensitive("others"));

        if (otherServiceType != null)
            services.Add(otherServiceType);

        return new JsonResult(services);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="formFiles"></param>
    /// <returns></returns>
    public async Task<IActionResult> OnPostSubmitQuoteRequest()
    {
        _logger.LogInformation("SubmitQuoteRequest: Starting...");
        ValidationResult result = await _validator.ValidateAsync(QuoteRequest);
        if (!result.IsValid)
        {
            // Clear existing model state errors to avoid duplication
            ModelState.Clear();

            result.AddToModelState(this.ModelState);
            var errors = ModelState
                .Where(x => x.Value.Errors.Any())
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToList()
                );

            return new JsonResult(new
            {
                success = false,
                message = "validation errors",
                errors
            });
        }

        try
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext?.User.Identity != null &&
                httpContext.User.Identity.IsAuthenticated)
            {
                // Retrieve the currently authenticated user
                if (httpContext != null)
                {
                    _logger.LogInformation("SubmitQuoteRequest: Retrieving user profile to include in the RFP...");
                    var userProfileDto = await _authService.GetUserAsync(httpContext.User);
                    if (userProfileDto != null)
                        QuoteRequest.RequestorUserProfileId = userProfileDto.Id;
                }
            }
            _logger.LogInformation("SubmitQuoteRequest: Saving RFP...");
            var quoteRequest = await _quoteRequestService.AddQuoteRequestAsync(QuoteRequest);

            if (FormFiles != null && FormFiles.Count > 0)
            {
                _logger.LogInformation("SubmitQuoteRequest: Uploading attachments to ImageKitIO...");
                foreach (var formFile in FormFiles)
                {
                    try
                    {
                        string? uploadFolderPath = string.Empty;
                        if (_applicationSettings.QRFPath.IsNotNullOrEmpty())
                            uploadFolderPath = _applicationSettings.QRFPath;

                        _logger.LogInformation("SubmitQuoteRequest: Starting upload...");
                        var cdnUrlPath = await _imageKitUploadService.UploadFileAsync(formFile, uploadFolderPath ?? string.Empty);

                        var attachment = new QuoteRequestAttachmentModel()
                        {
                            OriginalFilename = formFile.FileName,
                            AssetCDNUrl = cdnUrlPath,
                            QuoteRequestId = quoteRequest.Id,
                        };

                        await _quoteRequestAttachmentService.AddAttachmentAsync(attachment);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogWarning(ex, "Attachment failed to upload to Cloudinary cloud.");
                    }
                }
            }

            _logger.LogInformation("SubmitQuoteRequest: Creating message transformed from RFP to get internals notified...");
            MessageModel? message = await _quoteRequestService.GetMessageFromQuoteRequestAsync(quoteRequest.Id);
            if (message != null)
                await _messageService.AddMessageAsync(message);

            _logger.LogInformation("SubmitQuoteRequest: Done...");
        }
        catch (Exception ex)
        {
            _logger.LogInformation($"SubmitQuoteRequest: Error... >> {ex.GetExceptionMessages()}");

            // Handle any exceptions that occur during the quote request sending process
            return StatusCode(500, new
            {
                success = false,
                message = "An error occurred while sending the quote request",
                error = ex.GetExceptionMessages()
            });
        }

        return new JsonResult(new
        {
            success = true,
            message = "Quote request sent successfully",
            data = QuoteRequest
        });
    }
}

