using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MakingPi
{

    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await TaskAsync(context);
            });
        }

        private async Task TaskAsync(HttpContext context)
        {
            double i = 0.0;
            double sum = 0.0;
            while (1 == 1)
            {
                sum += 4.0 * Math.Pow(-1.0, i) / (2.0 * i + 1.0);
                if (i % 10000000 == 0)
                    await context.Response.WriteAsync(string.Format("{0}    {1}", i, sum));
                i++;
            }
        }
    }
}
