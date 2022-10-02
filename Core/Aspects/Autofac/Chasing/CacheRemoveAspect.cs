using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilites.İntercaptors;
using Core.Utilites.IoS;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Chasing;

public class CacheRemoveAspect : MethodInterception
{
    private readonly ICacheManager _cacheManager;
    private readonly string _pattern;

    public CacheRemoveAspect(string pattern)
    {
        _pattern = pattern;
        _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
    }

    protected override void OnSuccess(IInvocation invocation)
    {
        _cacheManager.RemoveByPattern(_pattern);
    }
}