using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Stripovi.Web.Areas.Identity.Data;
using Stripovi.Web.MockData;
using Stripovi.Web.MockData.MockKorpaRepository;
using Stripovi.Web.MockData.MockPorudzbinaRepository;
using Stripovi.Web.MockData.MockStripRepository;

namespace Stripovi.Web
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
            services.AddRazorPages();

            services.AddScoped<IPorudzbinaRepository, SQLPorudzbinaRepository>();
            services.AddScoped<IStripRepository, SQLStripRepository>();
            services.AddScoped<IKorpaRepository, SQLKorpaRepository>();

            services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
                options.AppendTrailingSlash = true;
            });

            services.AddAutoMapper(typeof(StripProfile));
            // services.AddScoped<IStripoviService, StripoviService>();
            // services.AddHttpClient("Stripovi",client =>
            // {
            //   client.BaseAddress = new Uri("https://localhost:44387/api/");
            // });

            services.AddDbContext<UserDbContext>(options =>                                                                 //Kopirano iz IdentityHosta, jer je izbacivao error kada se Scaffolduje 
                    options.UseSqlServer(Configuration.GetConnectionString("StripoviWebDbContextConnection")));                       

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>();
        }

     
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
