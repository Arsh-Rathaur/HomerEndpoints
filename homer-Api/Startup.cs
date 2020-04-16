using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repository.Interface;
using Data.Repository.Provider;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace HomerEndpoints
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
            services.AddControllers();
            //services.AddSingleton<HomerDbContext>();
            //services.AddSingleton<ILogin, Login>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.MapControllerRoute("default", "{controller=Accounts}/{action=Login}/{id?}");

                endpoints.MapPost("/api/Create_User", CreateUser);
                endpoints.MapPost("/api/login", login);
                endpoints.MapPut("/api/UpdatUser", Update);
            });
        }

        public Task CreateUser(HttpContext context)
        {
            var User = JsonConvert.DeserializeObject<Users>(GetRawBodyStringAsync(context.Request).Result);
            var AllData = new Unit(new HomerDbContext()).CreateUser(User);
            return context.Response.WriteAsync($"{AllData}!");
        }

        public Task login(HttpContext context)
        {
            var User = JsonConvert.DeserializeObject<Users>(GetRawBodyStringAsync(context.Request).Result);
            var AllData = new Unit(new HomerDbContext()).FindUser(User);
            return context.Response.WriteAsync($"{AllData}!");
        }

        public Task Update(HttpContext context)
        {
            var User = JsonConvert.DeserializeObject<Users>(GetRawBodyStringAsync(context.Request).Result);
            var AllData = new Unit(new HomerDbContext()).UpdateUser(User);
            return context.Response.WriteAsync($"{AllData}!");
        }

        public async Task<string> GetRawBodyStringAsync(HttpRequest request, Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            using (StreamReader reader = new StreamReader(request.Body, encoding))
                return await reader.ReadToEndAsync();
        }
    }
}
