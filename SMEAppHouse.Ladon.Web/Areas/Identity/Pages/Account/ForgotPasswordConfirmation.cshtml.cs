// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Web.Pages.Common;

namespace SMEAppHouse.Ladon.Web.Areas.Identity.Pages.Account;

public partial class ForgotPasswordConfirmationPageModel : BasePageModel
{
    public ForgotPasswordConfirmationPageModel(ApplicationSettings applicationSettings) 
        : base(applicationSettings)
    {
    }

    public string Email { get; set; }

    public void OnGet(string email)
    {
        Email = email;
    }
}
