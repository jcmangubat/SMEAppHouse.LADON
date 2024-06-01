using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Options;

namespace SMEAppHouse.Ladon.Web.Extensions;

public class CustomResponseCompressionConfigurer(IWebHostEnvironment env)
    : IConfigureOptions<ResponseCompressionOptions>
{
    private readonly IWebHostEnvironment _env = env ?? throw new ArgumentNullException(nameof(env));

    public void Configure(ResponseCompressionOptions options)
    {
        if (!_env.IsDevelopment())
        {
            //options.Providers.Add<BrotliCompressionProvider>();
            //options.Providers.Add<GzipCompressionProvider>();
        }
        else
        {
            var brotli = options.Providers.FirstOrDefault(p => p is BrotliCompressionProvider);
            if (brotli != null)
                options.Providers.Remove(brotli);
        }

        ServiceRegistrationExtensions.ConfigureMimeTypes(options);
    }
}