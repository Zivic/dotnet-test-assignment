using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DogProject.Infrastructure;

public static class RequestHandler
{
    public static async Task<IActionResult> HandleQuery<TModel>(
        Func<Task<TModel>> query, ILogger log)
    {
        try
        {
            return new OkObjectResult( await query());
        }
        catch (Exception e)
        {
            log.LogError(e, "Error handling the query");
            return new BadRequestObjectResult(new
            {
                error = e.Message,
                stackTrace = e.StackTrace
            });
        }
    }
}