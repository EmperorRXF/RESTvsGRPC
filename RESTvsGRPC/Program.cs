using BenchmarkDotNet.Running;
using System;

namespace RESTvsGRPC
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkHarness>();
            Console.ReadKey();
        }
    }
}
