using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Dormitory;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.Rooms;
using DMS.Core.Objects.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DMS.Core;

public static class ServiceExtension
{
    public static IServiceCollection AddCore(
        this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IResidentService, ResidentService>();
        serviceCollection.AddScoped<IDocumentService, DocumentService>();
        serviceCollection.AddScoped<IDormitoryService, DormitoryService>();
        serviceCollection.AddScoped<IRoomService, RoomService>();

        return serviceCollection;
    }
}