using Microsoft.AspNetCore.Http;

namespace SMEAppHouse.Ladon.Application.Interfaces;

public interface IImageKitUploadService
{
    Task<string> UploadFileAsync(IFormFile formFile, string assetFolder);
}

