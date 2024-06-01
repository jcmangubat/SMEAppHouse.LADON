using Microsoft.Extensions.Options;
using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Web.Helper;

public class ValidateConfigurationSettings : IValidateOptions<ApplicationSettings>
{
    public ValidateOptionsResult Validate(string name, ApplicationSettings options)
    {
        if (options.ContactUsRecipients == null || !options.ContactUsRecipients.Any())
            return ValidateOptionsResult.Fail("ContactUsRecipients must be provided.");

        return ValidateOptionsResult.Success;
    }
}
