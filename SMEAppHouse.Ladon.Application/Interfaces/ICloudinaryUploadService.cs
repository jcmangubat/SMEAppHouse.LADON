using Microsoft.AspNetCore.Http;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface ICloudinaryUploadService
{
    Task<(bool Success, string? CDNUrlPath)> UploadFileAsync(IFormFile file, string assetFolder);
}

