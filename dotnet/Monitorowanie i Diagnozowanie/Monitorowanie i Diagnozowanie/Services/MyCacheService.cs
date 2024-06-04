using System.Collections.Concurrent;

namespace Monitorowanie_i_Diagnozowanie.Services
{
    public record Device(Guid Id, string Name, string Kind);
    public class MyCacheService
    {
        private readonly ConcurrentDictionary<Guid, Device> _devices = new();

        public void AddDevice(Device device) =>
            _devices.TryAdd(device.Id, device);
    }
}
