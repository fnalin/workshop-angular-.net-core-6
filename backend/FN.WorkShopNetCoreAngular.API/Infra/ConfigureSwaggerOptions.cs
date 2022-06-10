using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace FN.WorkShopNetCoreAngular.API.Infra;

public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider;

    public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
    {
        _provider = provider;
    }

    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, CreateVersionInfo(description));
        }
    }

    private OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
    {
        return new OpenApiInfo()
        {
            Title = "WorkShopNetCoreAngular",
            Version = description.ApiVersion.ToString(),
            Description = description.IsDeprecated ? "This API version has been deprecated" : ""
        };
    }
}