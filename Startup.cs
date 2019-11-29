using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using tut01.Data;
using tut01.Interfaces;

namespace tut01
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // registra il DbContext
            services.AddDbContext<DatabaseContext>();
            // registra i repository che astraggono l'implementazione dell'ORM
            services.AddScoped<EmployeeRepository>();
            // Abilita la configurazione dei controller
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // di default kestrel viene configurato per servire in http sulla 5000 e https sulla 5001
            // questo middleware redirige le chiamate http verso le https 
            app.UseHttpsRedirection();
            app.UseRouting();
            // consente di servire direttamente index.html
            app.UseDefaultFiles();
            // serve i file statici dalla cartella di default wwwroot
            app.UseStaticFiles();
            // nuovo metodo 3.0 di configurazione degli endpoint
            app.UseEndpoints(endpoints => {
                // mappatura automatica dei controller
                endpoints.MapControllers();
            });
        }
    }
}
