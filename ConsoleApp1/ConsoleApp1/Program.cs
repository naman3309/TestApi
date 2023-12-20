using ConsoleApp1;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

internal class Program
{
    private static void Main(string[] args)
    {
        CreatehostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreatehostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
        {
            webHost.UseStartup<Startup>();
        });
    }
}