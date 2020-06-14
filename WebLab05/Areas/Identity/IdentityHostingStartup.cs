using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebLab05.Areas.Identity.IdentityHostingStartup))]
namespace WebLab05.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}