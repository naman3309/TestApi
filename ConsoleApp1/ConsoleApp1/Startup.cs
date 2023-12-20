using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ConsoleApp1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleWare>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Use 1.1\n");
            //    await next();
            //    await context.Response.WriteAsync("Use 1.2\n");
            //});

            //app.Map("/nig", CustomCode);
            //app.UseMiddleware<CustomMiddleWare>();
            
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Use 2.1\n");
            //    await next();
            //    await context.Response.WriteAsync("Use 2.2\n");
            //});
 
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Run()\n");
            //});


            if(env.IsDevelopment())
            { app.UseDeveloperExceptionPage(); }
            app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            

        }
        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("from Map\n");
                await next();
            });
        }
    }
}
