using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Api.Features.ApplicationHealth
{
    public static class HealthCheckOptionsFactory
    {
        public static HealthCheckOptions Create()
        {
            return new HealthCheckOptions
            {
                ResultStatusCodes =
                {
                    [HealthStatus.Healthy] = StatusCodes.Status200OK,
                    [HealthStatus.Degraded] = StatusCodes.Status200OK,
                    [HealthStatus.Unhealthy] = StatusCodes.Status503ServiceUnavailable
                },
                AllowCachingResponses = false,
                ResponseWriter = Writer
            };
        }

        private static Task Writer(HttpContext httpContext, HealthReport result)
        {
            httpContext.Response.ContentType = "application/json";

            var json = new JObject(
                new JProperty("status", result.Status.ToString()),
                new JProperty("checks", new JArray(result.Entries.Select(pair =>
                    new JObject(
                        new JProperty("name", pair.Key),
                        new JProperty("status", pair.Value.Status.ToString()),
                        new JProperty("description", pair.Value.Description),
                        new JProperty("duration", pair.Value.Duration.TotalMilliseconds),
                        new JProperty("data", new JObject(pair.Value.Data.Select(p => new JProperty(p.Key, p.Value))))
                    )
                )))
            );
            return httpContext.Response.WriteAsync(json.ToString(Formatting.None));
        }
    }
}
