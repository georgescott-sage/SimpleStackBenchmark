using System;
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
    private Random random = new Random();

    [Benchmark]
    public void HashSetStringIsNumber()
    {
        StringIsNumber.IsNumberHashSet(GetNumber(100));
    }

    [Benchmark]
    public void ListStringIsNumber()
    {
        StringIsNumber.IsNumberList(GetNumber(100));
    }

    private string GetNumber(int digits)
    {
        if (digits <= 1) return "";

        var _min = (int)Math.Pow(10, digits - 1);
        var _max = (int)Math.Pow(10, digits) - 1;
        return random.Next(_min, _max).ToString();
    }
}