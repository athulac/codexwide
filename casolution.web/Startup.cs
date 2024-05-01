using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace casolution.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "/", pattern: "{action=Index}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "home", pattern: "{action=Index}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "about", pattern: "{action=About}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "contact", pattern: "{action=Contact}/{id?}", defaults: new { controller = "Home" });

                endpoints.MapControllerRoute(name: "services/web-sites-designing", pattern: "{action=services/web-sites-designing}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/software-development", pattern: "{action=services/software-development}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/search-engine-optimisation", pattern: "{action=services/search-engine-optimisation}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/system-analyze-and-design", pattern: "{action=services/system-analyze-and-design}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/bussiness-process-re-engineering", pattern: "{action=services/bussiness-process-re-engineering}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/case-studying", pattern: "{action=services/case-studying}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "services/3rd-party-integrations", pattern: "{action=services/3rd-party-integrations}/{id?}", defaults: new { controller = "Home" });
                

                endpoints.MapControllerRoute(name: "more-about", pattern: "{action=MoreAbout}/{id?}", defaults: new { controller = "Home" });
                endpoints.MapControllerRoute(name: "vu-meter", pattern: "{action=projects}/{vu-meter}", defaults: new { controller = "Project" });

                //endpoints.MapControllerRoute(name: "project", pattern: "{action=Index}/{id?}", defaults: new { controller = "Project" });
                //endpoints.MapControllerRoute(name: "vu-meter", pattern: "{action=MoreAbout}/{id?}", defaults: new { controller = "Projects" });
                //endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
