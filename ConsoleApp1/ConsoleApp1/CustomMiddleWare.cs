using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("\n");
            await next(context);
            await context.Response.WriteAsync("\n");
        }
    }
}
