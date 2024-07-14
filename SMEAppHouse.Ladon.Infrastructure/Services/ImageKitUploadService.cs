using Imagekit.Sdk;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SMEAppHouse.Core.CodeKits.Extensions;
using SMEAppHouse.Ladon.Application.Interfaces;
using SMEAppHouse.Ladon.Application.Models;

namespace SMEAppHouse.Ladon.Infrastructure.Services;

public class ImageKitUploadService(ILogger<ImageKitUploadService> logger,
                                    ImageKitCredentials credentials) : IImageKitUploadService
{
    private readonly ILogger<ImageKitUploadService> _logger = logger;
    private readonly ImagekitClient _imageKitClient = new(credentials.StandardPublicKey,
                                                            credentials.StandardPrivateKey,
                                                            credentials.UrlEndpoint);

    public async Task<string> UploadFileAsync(IFormFile formFile, string assetFolder)
    {
        try
        {
            if (formFile == null || formFile.Length == 0)
                throw new ArgumentNullException(nameof(formFile));

            using var memoryStream = new MemoryStream();
            await formFile.CopyToAsync(memoryStream);
            memoryStream.Seek(0, SeekOrigin.Begin);
            var fileBytes = memoryStream.ToArray();

            // Upload the file to ImageKit.io
            var request = new FileCreateRequest()
            {
                file = fileBytes,
                fileName = Path.GetFileNameWithoutExtension(formFile.FileName),
                folder = assetFolder,
                overwriteFile = true,
                isPrivateFile = false,
                useUniqueFileName = true,
                overwriteCustomMetadata = true                
            };

            var uploadResponse = await _imageKitClient.UploadAsync(request);

            if (uploadResponse.HttpStatusCode == (int)System.Net.HttpStatusCode.OK)
            {
                var cdnUrl = uploadResponse.url;
                return cdnUrl;
            }
            else
            {
                ImageKitErrorResponse? errorResponse = null;
                if (!string.IsNullOrEmpty(uploadResponse.Raw))
                    errorResponse = JsonConvert.DeserializeObject<ImageKitErrorResponse>(uploadResponse.Raw);

                var logMessage = $"Error uploading file to ImageKit.io. Status code: {uploadResponse.HttpStatusCode}";
                logMessage += errorResponse != null ?
                                $"\r\nDetails: {errorResponse.Message.ToUpperFirstChar()}. {errorResponse.Help.ToUpperFirstChar()}" :
                                string.Empty;

                throw new Exception(logMessage);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error uploading file to ImageKit.io");
            throw;
        }
    }

    public class ImageKitErrorResponse
    {
        public string? Message { get; set; }
        public string? Help { get; set; }
    }

}

