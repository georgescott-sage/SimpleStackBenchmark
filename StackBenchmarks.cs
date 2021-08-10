using System.Collections;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StackBenchmarks
{
    private static readonly DoubleStack testStack = new DoubleStack(null);
    private static readonly Stack testStackDotnet = new Stack();
    private static readonly GenericStack<double> genericStack = new GenericStack<double>(null);

    [Benchmark]
    public void PushPopDoubleStack()
    {
        testStack.Push(1.1);
        testStack.Push(1.1);
        testStack.Pop();
        testStack.Pop();
    }

    [Benchmark]
    public void PushPopDotnetStack()
    {
        testStackDotnet.Push(1.1);
        testStackDotnet.Push(1.1);
        testStackDotnet.Pop();
        testStackDotnet.Pop();
    }

     [Benchmark]
    public void GenericStackImplementation()
    {
        genericStack.Push(1.1);
        genericStack.Push(1.1);
        genericStack.Pop();
        genericStack.Pop();
    }
}