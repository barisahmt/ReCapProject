using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilites.IoS;

public interface ICoreModule
{
    void Load(IServiceCollection serviceCollection);
}