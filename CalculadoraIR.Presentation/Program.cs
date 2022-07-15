using CalculadoraIR.Presentation.Telas;
using CalculadoraIR.Presentation.Telas.Interfaces;
using CalculadoraIR.Services;
using CalculadoraIR.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        ServiceCollection services = new();
        ConfigureServices(services);

        var serviceProvider = services.BuildServiceProvider();

        var PessoaScreen = serviceProvider.GetService<IAddPessoaFisicaScreen>();

        PessoaScreen.Begin();

      

    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services
            .AddScoped<ITaxCalculator, TaxCalculator>()
            .AddScoped<IAddPessoaFisicaScreen, AddPessoaFisicaScreen>()
            .AddScoped<IPessoaFisicaService, PessoaFisicaService>()            ;
    }

  
}