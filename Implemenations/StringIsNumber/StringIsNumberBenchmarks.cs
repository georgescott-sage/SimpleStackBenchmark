using System.Collections;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SimpleStackBenchmark.Implemenations.StringIsNumber;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringIsNumberBenchmarks
{
    [Benchmark]
    public void HashSetStringIsNumber()
    {
        
        StringIsNumber.IsNumberHashSet("1234567890j");
    }

    [Benchmark]
    public void ListStringIsNumber()
    {
        StringIsNumber.IsNumberHashSet("1234567890j");
    }
}