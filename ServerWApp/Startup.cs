using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServerWApp.Models;

namespace ServerWApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // readonly string CORSOpenPolicy = "OpenCORSPolicy";
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Hata sayfasını geliştirme ortamında kullanmak için
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Hata yönetimi için
                app.UseHsts();
            }
            
            app.UseHttpsRedirection(); // HTTPS'e yönlendirme

            // services.AddCors(options => options
            // .AddPolicy(name:CORSOpenPolicy, builder =>{
            //     builder
            //     //.AllowAnyOrigin()
            //     .WithOrigins("http://localhost:4200")
            //     .AllowAnyMethod()
            //     .AllowAnyHeader();
            // }));

            app.UseRouting();

            // app.UseCors(CORSOpenPolicy);

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // API rotalarını eşleme
            });
        }
    }
}
