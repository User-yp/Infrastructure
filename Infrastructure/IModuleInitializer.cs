using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public interface IModuleInitializer
{
    public void Initialize(IServiceCollection services);
}