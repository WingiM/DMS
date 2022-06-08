using DMS.Core;
using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Dormitory;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.Rooms;
using DMS.Data.Resources;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DMS.Data;

public static class ServiceExtension
{
    public static IServiceCollection AddData(
        this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddDbContext<ApplicationContext>(options =>
            options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"))
                .UseSnakeCaseNamingConvention());

        serviceCollection.AddStackExchangeRedisCache(options =>
        {
            options.Configuration =
                configuration.GetConnectionString("RedisDefaultConnection");
        });

        serviceCollection.AddTransient<IDormitoryResource, DormitoryResource>();
        serviceCollection.AddTransient<IDocumentsResource, DocumentsResource>();
        serviceCollection.AddTransient<IResidentResource, ResidentResource>();
        serviceCollection.AddTransient<IRoomResource, RoomResource>();
        serviceCollection.AddTransient<IDataContext, EfDataContext>();
        
        return serviceCollection;
    }
}