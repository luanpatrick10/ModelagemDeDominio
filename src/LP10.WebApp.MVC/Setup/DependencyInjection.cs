using LP10.Catalogo.Application.Services;
using LP10.Catalogo.Data;
using LP10.Catalogo.Data.Repository;
using LP10.Catalogo.Domain.Repository;
using LP10.Catalogo.Domain.Services;
using LP10.Core.Bus;

namespace LP10.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServics(this IServiceCollection services)
        {
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
