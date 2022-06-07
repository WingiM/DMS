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
        serviceCollection.AddTransient<IResidentService, ResidentService>();
        serviceCollection.AddTransient<IDocumentService, DocumentService>();
        serviceCollection.AddTransient<IDormitoryService, DormitoryService>();
        serviceCollection.AddTransient<IRoomService, RoomService>();

        return serviceCollection;
    }
}