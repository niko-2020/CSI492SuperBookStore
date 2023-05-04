using System;
using CRWBookStore.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CRWBookStore.Areas.Identity.IdentityHostingStartup))]
namespace CRWBookStore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdentityUserDataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdentityUserDataContextConnection")));

                services.AddDefaultIdentity<CRWBookStoreUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdentityUserDataContext>();
            });
        }
    }
}