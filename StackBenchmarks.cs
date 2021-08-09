using System.Collections;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StackBenchmarks
{
    private static readonly DoubleStack testStack = new DoubleStack(null);
    private static readonly Stack testStackDotnet = new Stack();

    [Benchmark]
    public void PushPopDoubleStack()
    {
        testStack.Push(1.1);
        testStack.Pop();
    }

    [Benchmark]
    public void PushPopDotnetStack()
    {
        testStackDotnet.Push(1.1);
        testStackDotnet.Pop();
    }
}