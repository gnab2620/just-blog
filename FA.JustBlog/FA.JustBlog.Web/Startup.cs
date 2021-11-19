
using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FA.JustBlog.Web.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IPostTagMapRepository, PostTagMapRepository>();

            services.AddAutoMapper(typeof(Mapper));
            services.AddDefaultIdentity<Users>()
                 .AddRoles<IdentityRole>()
                 .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
             , UserManager<Users> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();
            SeedData.Seed(userManager, roleManager);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "Post ",
                   defaults: new { controller = "Post", action = "Edit" },
                   pattern: "Post/Edit/{id}"

                   );
                endpoints.MapControllerRoute(
                    name: "Cate detail",
                    defaults: new { controller = "Post", action = "PostsByCategoryUrlSlug" },
                    pattern: "cate/{UrlSlug}"

                    );endpoints.MapControllerRoute(
                    name: "tag detail",
                    defaults: new { controller = "Post", action = "PostsByTagUrlSlug" },
                    pattern: "tag/{UrlSlug}"

                    );
                endpoints.MapControllerRoute(
                    name: "Post detail",
                    defaults: new {  controller = "Post", action = "GetPostDetails" },
                    pattern: "post/{year}/{month}/{seoUrl}",
                    constraints: new { year = @"\d{4}", month = @"\d{2}" }
                    );
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
