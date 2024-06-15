namespace Application.Infrastructure.Extensions;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Provides extension methods for configuring the infrastructure layer of the application.
/// </summary>
public static class InfrastructureStartupExtensions
{
  /// <summary>
  /// Configures value object settings from the application configuration.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <param name="configuration">The application's configuration.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection ConfigureValueObjects(this IServiceCollection services, IConfiguration configuration)
  {
    //services.Configure<ValueObjectSettings>(options => configuration.GetSection("ValueObjectSettings"));

    return services;
  }

  /// <summary>
  /// Adds essential infrastructure services to the application.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
  {
    services.AddBusinessServices();
    services.AddDataServices();
    services.AddGenericServices();
    services.AddSecurityServices();
    services.AddSystemServices();
    services.AddThirdPartyServices();

    return services;
  }

  /// <summary>
  /// Adds business layer services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddBusinessServices(this IServiceCollection services)
  {
    //services.TryAddScoped<ICreateClientBusinessService, CreateClientBusinessService>();

    return services;
  }


  /// <summary>
  /// Adds data access layer services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddDataServices(this IServiceCollection services)
  {
    //services.TryAddScoped<IGetConfigDataService, GetConfigDataService>();

    return services;
  }

  /// <summary>
  /// Adds generic services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddGenericServices(this IServiceCollection services)
  {
    //services.TryAddScoped<IGetClientGenericService, GetClientGenericService>();

    return services;
  }

  /// <summary>
  /// Adds security services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddSecurityServices(this IServiceCollection services)
  {
    //services.TryAddScoped<IEncryptionSecurityService, EncryptionSecurityService>();

    return services;
  }

  /// <summary>
  /// Adds system services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddSystemServices(this IServiceCollection services)
  {
    //services.TryAddScoped<IJsonSerialiserSystemService, JsonSerialiserSystemService>();

    return services;
  }

  /// <summary>
  /// Adds third party services to the application's service collection.
  /// </summary>
  /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
  /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
  public static IServiceCollection AddThirdPartyServices(this IServiceCollection services)
  {
    //services.TryAddScoped<IThirdPartyService, ThirdPartyService>();

    return services;
  }
}