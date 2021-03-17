using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicesCollection)
        {
            servicesCollection.AddMemoryCache();
            servicesCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            //servicesCollection.AddSingleton<ICacheManager, RedisCacheManager>();
            servicesCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //servicesCollection.AddSingleton<Stopwatch>();
        }
    }
}
