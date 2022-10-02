using Core.Utilites.IoS;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extantions;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddDepencyResolvers(this IServiceCollection serviceCollection,
        ICoreModule[] modules)
    {
        foreach (var module in modules) module.Load(serviceCollection);
        return ServiceTool.Create(serviceCollection);
    }
}