using Microsoft.Azure.Devices.Applications.RemoteMonitoring.Simulator.SimulatorCore.Devices;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.Simulator.SimulatorCore.Transport.Factory
{
    public interface ITransportFactory
    {
        ITransport CreateTransport(IDevice device);
    }
}
