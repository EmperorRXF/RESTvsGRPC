using Grpc.Core;
using ModelLibrary.GRPC;
using System.Threading.Tasks;

namespace GrpcAPI
{
    public class MeteoriteLandingServer
    {
        private readonly Server server;

        public MeteoriteLandingServer()
        {
            server = new Server
            {
                Services = { MeteoriteLandingsService.BindService(new MeteoriteLandingsServiceImpl()) },
                Ports = { new ServerPort("localhost", 6000, ServerCredentials.Insecure) }
            };
        }

        public void Start()
        {
            server.Start();
        }

        public async Task ShutdownAsync()
        {
            await server.ShutdownAsync();
        }
    }
}
