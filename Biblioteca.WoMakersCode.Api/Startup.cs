using Biblioteca.WoMakersCode.Application.Mappings;
using Biblioteca.WoMakersCode.Application.Models.AdicionarAutor;
using Biblioteca.WoMakersCode.Application.Models.AdicionarUsuario;
using Biblioteca.WoMakersCode.Application.Models.AtualizarDevolucaoLivro;
using Biblioteca.WoMakersCode.Application.Models.ExcluirEmprestimo;
using Biblioteca.WoMakersCode.Application.Models.ListarLivros;
using Biblioteca.WoMakersCode.Application.UseCases;
using Biblioteca.WoMakersCode.Core.Repositories;
using Biblioteca.WoMakersCode.infra.Database;
using Biblioteca.WoMakersCode.infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace Biblioteca.WoMakersCode.Api
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
            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<IEmprestimoRepository, EmprestimoRepository>();
            services.AddTransient<ILivroRepository, LivroRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse>, AdicionarUsuarioUseCase>();
            services.AddTransient<IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse>, AdicionarAutorUseCase>();
            services.AddTransient<IUseCaseAsync<ListarLivrosRequest, List<ListarLivrosResponse>>, ListarLivrosUseCase>();
            services.AddTransient<IUseCaseAsync<AtualizarDevolucaoLivroRequest, AtualizarDevolucaoLivroResponse>, AtualizarDevolucaoLivroUseCase>();
            services.AddTransient<IUseCaseAsync<ExcluirEmprestimoRequest, ExcluirEmprestimoResponse>, ExcluirEmprestimoUseCase>();
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Biblioteca.WoMakersCode.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Biblioteca.WoMakersCode.Api v1"));
            }

            context.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        
    }
}
