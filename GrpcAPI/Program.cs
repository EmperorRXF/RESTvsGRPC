using System;
using System.Threading.Tasks;

namespace GrpcAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            StartServer().GetAwaiter().GetResult();
        }

        private static async Task StartServer()
        {
            var server = new MeteoriteLandingServer();
            server.Start();

            Console.WriteLine("GRPC MeteoriteLandingServer Running on localhost:6000");
            Console.ReadKey();

            await server.ShutdownAsync();
        }
    }
}
