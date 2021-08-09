using System;
using BenchmarkDotNet.Running;

namespace SimpleStackBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StackBenchmarks>();
        }
    }
}