using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace LunarSoft.Dms.Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseWebRoot(Directory.GetCurrentDirectory() + "/Assets")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Application>()
                .Build();

            host.Run();
        }
    }
}