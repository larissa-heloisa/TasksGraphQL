using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TaskApi.Application;
using TaskApi.BusinessRules.Handlers;
using TaskApi.BusinessRules.Handlers.Interfaces;
using TaskApi.BusinessRules.Validators;
using TaskApi.BusinessRules.Validators.Interfaces;
using TaskApi.Infrastructure;
using TaskApi.Infrastructure.Repositories;

namespace TaskApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>(option => option.UseInMemoryDatabase("TaskDatabase"));

            services
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

            services
                .AddScoped<ITaskValidator, TaskValidator>()
                .AddScoped<ITaskRepository, TaskRepository>()
                .AddScoped<IUpsertTaskHandler, UpsertTaskHandler>()
                .AddScoped<IGetAllTasksHandler, GetAllTaskHandler>()
                .AddScoped<IGetByIdTaskHandler, GetByIdTaskHandler>();

                


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
