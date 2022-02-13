namespace Consultant.API.Middleware
{
    public class AuthorizationMiddleware
    {
        readonly RequestDelegate _next;

        public AuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var auth = context.Request.Headers.Authorization;

            if (Data.Conf.ApiKey == auth)
            {
                await _next(context);
            }
            else 
            {
                throw new Exceptions.NoAccessException(Shared.Entity.Http.EResponseCode.NoAccess);
            }
        }
    }
}