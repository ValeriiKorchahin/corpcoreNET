using Corpcore.Utils.Error;
using System.Net;

namespace Corpcore.Middlewares
{
    public class ExceptionMiddleware(RequestDelegate _next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (RestException ex)
            {
                await HandleRestException(context, ex);
            }
            catch (Exception)
            {
                await HandleUnexpectedException(context);
            }
        }

        private static Task HandleRestException(HttpContext context, RestException ex)
        {
            var response = new
            {
                status = (int)ex.Code,
                errors = ex.Errors,
                timestamp = DateTime.UtcNow
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)ex.Code;

            return context.Response.WriteAsJsonAsync(response);
        }

        private static Task HandleUnexpectedException(HttpContext context)
        {
            var response = new
            {
                status = (int)HttpStatusCode.InternalServerError,
                errors = "An unexpected error occurred.",
                timestamp = DateTime.UtcNow
            };

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
