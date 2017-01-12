using Microsoft.Azure.Devices.Applications.RemoteMonitoring.Common.Configurations;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.Simulator.SimulatorCore.Devices;
using Microsoft.Azure.Devices.Applications.RemoteMonitoring.Simulator.SimulatorCore.Logging;

namespace Microsoft.Azure.Devices.Applications.RemoteMonitoring.Simulator.SimulatorCore.Transport.Factory
{
    public class IotHubTransportFactory : ITransportFactory
    {
        private readonly ILogger _logger;
        private readonly IConfigurationProvider _configurationProvider;

        public IotHubTransportFactory(ILogger logger,
            IConfigurationProvider configurationProvider)
        {
            _logger = logger;
            _configurationProvider = configurationProvider;
        }

        public ITransport CreateTransport(IDevice device)
        {
            return new IoTHubTransport(_logger, _configurationProvider, device);
        }
    }
}
