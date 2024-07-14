using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Core.CodeKits.Tools;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Repositories;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;
using QuoteRequest = SMEAppHouse.Ladon.Domain.Entities.EFModels.QuoteRequest;

namespace SMEAppHouse.Ladon.Application.Services;

public class QuoteRequestService(ILogger<QuoteRequestService> logger,
                                IMapper mapper,
                                IQuoteRequestRepository quotesRequestsRepository,
                                ICloudinaryUploadService cloudinaryUploadService) : IQuoteRequestService
{
    private readonly ILogger<QuoteRequestService> _logger = logger;
    private readonly IMapper _mapper = mapper;
    private readonly IQuoteRequestRepository _quotesRequestsRepository = quotesRequestsRepository;
    private readonly ICloudinaryUploadService _cloudinaryUploadService = cloudinaryUploadService;

    public async Task<QuoteRequestModel> GetQuoteRequestAsync(Guid id)
    {
        try
        {
            var quoteRequest = await _quotesRequestsRepository.GetSingleAsync(p => p.Id == id);
            var qtRqst = _mapper.Map<QuoteRequestModel>(quoteRequest);
            return qtRqst;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<IEnumerable<QuoteRequestModel>> GetQuoteRequestsAsync()
    {
        try
        {
            var quoteRequests = await _quotesRequestsRepository.GetListAsync();
            var qtRqsts = _mapper.Map<IEnumerable<QuoteRequestModel>>(quoteRequests);
            return qtRqsts;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<QuoteRequestModel> AddQuoteRequestAsync(QuoteRequestModel quoteRequest)
    {
        try
        {
            var qtRqst = _mapper.Map<QuoteRequest>(quoteRequest);
            qtRqst.SquareAreaUoM = LengthUnitsEnum.Meter;
            if (quoteRequest.DesiredStartDate.HasValue && quoteRequest.DesiredEndDate.HasValue &&
                quoteRequest.DesiredStartDate.Value <= quoteRequest.DesiredEndDate.Value)
            {
                var (months, days, hours) = CalculateDateDifference(quoteRequest.DesiredStartDate.Value, quoteRequest.DesiredEndDate.Value);
                qtRqst.ProjectDurationMonths = months;
                qtRqst.ProjectDurationDays = days;
                qtRqst.ProjectDurationHours = hours;
            }
            else if (quoteRequest.DesiredStartDate.HasValue && (quoteRequest.DurationMonths.HasValue ||
                quoteRequest.DurationDays.HasValue || quoteRequest.DurationHours.HasValue))
            {
                quoteRequest.DesiredEndDate = CalculateEndDate(quoteRequest.DesiredStartDate.Value, quoteRequest.DurationMonths, quoteRequest.DurationDays, quoteRequest.DurationHours);
            }

            await _quotesRequestsRepository.AddAsync(qtRqst);
            await _quotesRequestsRepository.CommitAsync();

            quoteRequest.Id = qtRqst.Id;
            return quoteRequest;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    public async Task<MessageModel?> GetMessageFromQuoteRequestAsync(Guid id)
    {
        Func<IQueryable<QuoteRequest>, IIncludableQueryable<QuoteRequest, object>> include = query =>
            query.Include(p => p.Attachments);

        try
        {
            var qtRqst = await _quotesRequestsRepository.GetSingleAsync(p => p.Id == id, include);
            if (qtRqst == null)
                return null;

            var quoteRqst = _mapper.Map<QuoteRequestModel>(qtRqst);
            var message = new MessageModel
            {
                UserProfileId = quoteRqst.RequestorUserProfileId,
                SiteMessageSource = SiteMessageSourcesEnum.FromServiceQuoteRequest,
                EmailAddress = quoteRqst.EmailAddress,
                MobilePhoneNo = quoteRqst.PhoneNo,
                Name = quoteRqst.FullName,
                Subject = $"Quote Request ({quoteRqst.FullName} - {DateTime.Now:g})",
                ContentText = GenerateTextDocument(qtRqst),
                ContentHtml = GenerateHtmlDocument(qtRqst)
            };
            return message;
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }

    private static string GenerateHtmlDocument(QuoteRequest quoteRequest)
    {
        var htmlContent = HtmlResourceLoader.LoadHtmlResource("QuoteRequestMessageTemplate.html", "EmailTemplates");

        if (quoteRequest.PreferredCommunicationMethod == ContactMethodPreferencesEnum.Email ||
            quoteRequest.PreferredCommunicationMethod == ContactMethodPreferencesEnum.Both)
        {
            var noContactMsg = "<h4 style=\"color: red; margin-bottom:15px;\">[Please do not respond. Client prefers phone contact only]</h4>";
            htmlContent = htmlContent.Replace(noContactMsg, string.Empty);
        }

        htmlContent = htmlContent
                        .Replace("[name]", $"{quoteRequest.FirstName} {quoteRequest.LastName}".Trim())
                        .Replace("[company-name]", quoteRequest.CompanyName)
                        .Replace("[email-address]", quoteRequest.EmailAddress)
                        .Replace("[phoneno]", quoteRequest.PhoneNo)
                        .Replace("[contact-method]", quoteRequest.PreferredCommunicationMethod.ToString())
                        .Replace("[address-line1]", quoteRequest.AddressLine1)
                        .Replace("[address-line2]", quoteRequest.AddressLine2)
                        .Replace("[stateorregion]", quoteRequest.StateOrRegion)
                        .Replace("[city]", quoteRequest.City)
                        .Replace("[zipcode]", quoteRequest.ZipCode)
                        .Replace("[country]", quoteRequest.CountryCode)
                        .Replace("[projectname]", quoteRequest.SiteProjectName)
                        .Replace("[proj-address-line1]", quoteRequest.SiteAddressLine1)
                        .Replace("[proj-address-line2]", quoteRequest.SiteAddressLine2)
                        .Replace("[proj-stateorregion]", quoteRequest.StateOrRegion)
                        .Replace("[proj-city]", quoteRequest.SiteCity)
                        .Replace("[proj-zipcode]", quoteRequest.SiteZipCode)
                        .Replace("[proj-country]", quoteRequest.SiteCountryCode)
                        .Replace("[proj-category]", quoteRequest.ProjectCategory.ToString())
                        .Replace("[proj-servicetypecode]", quoteRequest.ProjectServiceTypeCode)
                        .Replace("[desired-start-date]", quoteRequest.DesiredStartDate.ToString())
                        .Replace("[desired-end-date]", quoteRequest.DesiredEndDate.ToString())
                        .Replace("[duration-months]", quoteRequest.ProjectDurationMonths.ToString())
                        .Replace("[duration-days]", quoteRequest.ProjectDurationDays.ToString())
                        .Replace("[duration-hours]", quoteRequest.ProjectDurationHours.ToString())
                        .Replace("[square-area]", quoteRequest.SquareArea.ToString())
                        .Replace("[square-area-uom]", quoteRequest.SquareAreaUoM.ToString())
                        .Replace("[floors]", quoteRequest.NumberOfFloors.ToString())
                        .Replace("[requirements-and-features]", quoteRequest.SpecialRequirementsOrFeatures)
                        .Replace("[min-budget]", quoteRequest.BudgetMinAmount.ToString())
                        .Replace("[max-budget]", quoteRequest.BudgetMaxAmount.ToString())
                        .Replace("[spec-budget]", quoteRequest.BudgetSpecificAmount.ToString())
                        .Replace("[comments-questions]", quoteRequest.AdditionalCommentsOrQuestions)
                        .Replace("[referral-source]", quoteRequest.ReferralSource.ToString());


        if (quoteRequest.Attachments.Count == 0)
            return htmlContent;

        var attSection = string.Empty;
        foreach (var attachment in quoteRequest.Attachments)
        {
            attSection += $"<tr><td><img src='{attachment.AssetCDNUrl}' alt='image'/></td></tr>";
        }

        if (!string.IsNullOrEmpty(attSection))
            htmlContent = htmlContent.Replace("<tr><td><span id='#attachments'>[N/A]</span></td></tr>", attSection);

        return htmlContent;
    }

    private static (int Months, int Days, int Hours) CalculateDateDifference(DateTime startDate, DateTime endDate)
    {
        if (endDate < startDate)
            throw new ArgumentException("End date must be greater than or equal to start date");

        // Calculate the difference in months
        var months = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;
        if (endDate.Day < startDate.Day)
            months--;

        // Adjust days and hours after calculating months
        DateTime tempDate = startDate.AddMonths(months);
        TimeSpan remainingTimeSpan = endDate - tempDate;

        var days = remainingTimeSpan.Days;
        var hours = remainingTimeSpan.Hours;

        return new(months, days, hours);
    }

    private static DateTime CalculateEndDate(DateTime startDate, int? months = null, int? days = null, int? hours = null)
    {
        DateTime newDate = startDate;

        if (months.HasValue)
            newDate = newDate.AddMonths(months.Value);

        if (days.HasValue)
            newDate = newDate.AddDays(days.Value);

        if (hours.HasValue)
            newDate = newDate.AddHours(hours.Value);

        return newDate;
    }

    public static string GenerateTextDocument(QuoteRequest quoteRequest)
    {
        var report = new StringBuilder();

        if (quoteRequest.PreferredCommunicationMethod == ContactMethodPreferencesEnum.Phone)
        {
            report.AppendLine("[DO NOT REPLY]");
            report.AppendLine($"Client prefers contact method via {quoteRequest.PreferredCommunicationMethod}.\r\n\r\n");
        }

        report.AppendLine("CONTACT INFORMATION\r\n");
        report.AppendLine($"Name: {$"{quoteRequest.FirstName} {quoteRequest.LastName}".Trim()}");
        report.AppendLine($"Company Name: {quoteRequest.CompanyName}");
        report.AppendLine($"Email Address: {quoteRequest.EmailAddress}");
        report.AppendLine($"Phone Number: {quoteRequest.PhoneNo ?? "N/A"}");
        report.AppendLine($"Preferred Contact Method: {quoteRequest.PreferredCommunicationMethod}");
        report.AppendLine($"Contact Address Line 1: {quoteRequest.AddressLine1}");
        report.AppendLine($"Contact Address Line 2: {quoteRequest.AddressLine2 ?? "N/A"}");
        report.AppendLine($"Contact State/Region: {quoteRequest.StateOrRegion ?? "N/A"}");
        report.AppendLine($"Contact City: {quoteRequest.City ?? "N/A"}");
        report.AppendLine($"Contact Zip Code: {quoteRequest.ZipCode ?? "N/A"}");
        report.AppendLine($"Contact Country: {quoteRequest.CountryCode ?? "N/A"}\r\n");
        report.AppendLine("PROJECT DETAILS\r\n");
        report.AppendLine($"Project Name: {quoteRequest.SiteProjectName}");
        report.AppendLine($"Project Address Line 1: {quoteRequest.SiteAddressLine1 ?? "N/A"}");
        report.AppendLine($"Project Address Line 2: {quoteRequest.SiteAddressLine2 ?? "N/A"}");
        report.AppendLine($"Project State/Region: {quoteRequest.SiteStateOrRegion ?? "N/A"}");
        report.AppendLine($"Project City: {quoteRequest.SiteCity ?? "N/A"}");
        report.AppendLine($"Project Zip Code: {quoteRequest.SiteZipCode ?? "N/A"}");
        report.AppendLine($"Project Country: {quoteRequest.SiteCountryCode ?? "N/A"}");
        report.AppendLine($"Project Category: {quoteRequest.ProjectCategory?.ToString() ?? "N/A"}");
        report.AppendLine($"Project Service Type Code: {quoteRequest.ProjectServiceTypeCode ?? "N/A"}\r\n");
        report.AppendLine("TIMELINE\r\n");

        report.AppendLine($"Desired Start Date: {quoteRequest.DesiredStartDate?.ToString("MM/dd/yyyy") ?? "N/A"}");
        report.AppendLine($"Desired End Date: {quoteRequest.DesiredEndDate?.ToString("MM/dd/yyyy") ?? "N/A"}");
        report.AppendLine($"Project Duration in Months: {quoteRequest.ProjectDurationMonths?.ToString(@"dd\.hh\:mm\:ss") ?? "N/A"}");
        report.AppendLine($"Project Duration in Days: {quoteRequest.ProjectDurationDays?.ToString(@"dd\.hh\:mm\:ss") ?? "N/A"}");
        report.AppendLine($"Project Duration in Hours: {quoteRequest.ProjectDurationHours?.ToString(@"dd\.hh\:mm\:ss") ?? "N/A"}\r\n");
        report.AppendLine("SPECIFICATIONS\r\n");
        report.AppendLine($"Square Area: {quoteRequest.SquareArea?.ToString() ?? "N/A"}");
        report.AppendLine($"Square Area UoM: {quoteRequest.SquareAreaUoM?.ToString() ?? "N/A"}");
        report.AppendLine($"Number of Floors: {quoteRequest.NumberOfFloors?.ToString() ?? "N/A"}");
        report.AppendLine($"Special Requirements/Features: {quoteRequest.SpecialRequirementsOrFeatures}\r\n");
        report.AppendLine("BUDGET INFORMATION\r\n");
        report.AppendLine($"Budget Min Amount: {quoteRequest.BudgetMinAmount?.ToString("N0") ?? "N/A"}");
        report.AppendLine($"Budget Max Amount: {quoteRequest.BudgetMaxAmount?.ToString("N0") ?? "N/A"}");
        report.AppendLine($"Budget Specific Amount: {quoteRequest.BudgetSpecificAmount?.ToString("N0") ?? "N/A"}\r\n");
        report.AppendLine("ADDITIONAL INFORMATION\r\n");
        report.AppendLine($"Additional Comments/Questions: \r\n{quoteRequest.AdditionalCommentsOrQuestions ?? "N/A"}");
        report.AppendLine($"Referral Source: {quoteRequest.ReferralSource}\r\n");

        return report.ToString();
    }
}