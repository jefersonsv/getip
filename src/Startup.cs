using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace getip
{
    public class Startup
    {
        private static void PrintHeaders(HttpContext context)
        {
            context.Request.Headers.ToList().ForEach(o => Console.WriteLine($"Key: {o.Key} Value: {o.Value}"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async (context) =>
            {
                var xforwardedfor = context.Request.Headers["X-Forwarded-For"].SingleOrDefault();
                await context.Response.WriteAsync(
                        xforwardedfor ?? context.Connection.RemoteIpAddress?.ToString()
                    );
            });
        }
    }
}