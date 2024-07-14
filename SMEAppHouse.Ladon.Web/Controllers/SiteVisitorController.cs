using Microsoft.AspNetCore.Mvc;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models.Data;
using SMEAppHouse.Ladon.Domain.Constants;

namespace SMEAppHouse.Ladon.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SiteVisitorController( ILogger<SiteVisitorController> logger,
                                    IMessageService messageService)
    : ControllerBase
{
    private readonly ILogger<SiteVisitorController> _logger = logger;
    private readonly IMessageService _messageService = messageService;    

    // GET: api/Messages
    [HttpGet]
    public async Task<IActionResult> GetMessagesAsync()
    {
        try
        {
            var messages = await _messageService.GetMessagesAsync();
            return Ok(messages);
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message, ex);
            throw;
        }
    }

    // POST: api/Messages
    [HttpPost("SendMessage")]
    public async Task<IActionResult> SendMessageAsync([FromBody] MessageModel message)
    {
        if (!ModelState.IsValid)
        {
            var errorList = ModelState.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
            );

            return BadRequest(new
            {
                success = false,
                errors = errorList //ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList()
            });
        }

        try
        {
            message.SiteMessageSource = Rules.SiteMessageSourcesEnum.FromContactUs;
            
            await _messageService.AddMessageAsync(message);
            return Ok(new
            {
                success = true,
                message = "Message sent successfully",
                data = message
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(message: ex.Message, ex);
            return StatusCode(500, new
            {
                success = false,
                message = "An error occurred while sending the message."
            });
        }
    }
}
