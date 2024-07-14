using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SMEAppHouse.Core.CodeKits.Helpers;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Core.CodeKits;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class CloudinaryUploadService : ICloudinaryUploadService
{
    private readonly Cloudinary _cloudinary;
    private readonly CloudinaryCredentials _credentials;
    private readonly ILogger<CloudinaryUploadService> _logger;
    public CloudinaryUploadService(ILogger<CloudinaryUploadService> logger, CloudinaryCredentials credentials)
    {
        _logger = logger;
        _credentials = credentials;
        var account = new Account(
           _credentials.CloudName,
           _credentials.ApiKey,
           _credentials.ApiSecret
       );
        _cloudinary = new Cloudinary(account);
    }

    public async Task<(bool Success, string? CDNUrlPath)> UploadFileAsync(IFormFile file, string assetFolder)
    {
        try
        {
            if (file == null || file.Length == 0)
                throw new ArgumentNullException(nameof(file));

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                AssetFolder = assetFolder,
                PublicId = Guid.NewGuid().Short(),
                UseAssetFolderAsPublicIdPrefix = true,
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            ImageUploadResult uploadResult = await _cloudinary.UploadAsync(uploadParams);
            return (uploadResult.StatusCode == System.Net.HttpStatusCode.OK, uploadResult.Url.AbsoluteUri);
        }
        catch (Exception ex)
        {
            _logger.LogDebug(ex.GetExceptionMessages());
            throw;
        }
    }
}
