using CleanArchitecture.Application.Interfaces.Authors;
using CleanArchitecture.Application.Interfaces.Books;
using CleanArchitecture.Application.Models.Authors.GetAllAuthors.Queries;
using CleanArchitecture.Persistence.Repositories.Authors;
using CleanArchitecture.Persistence.Repositories.Books;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Presentation
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
            services.AddMvc();
            
            // Author Mediatr
            services.AddMediatR(typeof(GetAllAuthorsQuery).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetAllAuthorsQuery).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetAllAuthorsQuery).GetTypeInfo().Assembly);

            services.AddTransient<IAuthorRepository, AuthorRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
