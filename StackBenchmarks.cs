using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StackBenchmarks
{
    private static readonly DoubleStack testStack = new DoubleStack(null);
    
    [Benchmark]
    public void Count()
    {
        testStack.Count();
    }

    [Benchmark]
    public void PushPop()
    {
        testStack.Push(1.1);
        testStack.Pop();
    }
}