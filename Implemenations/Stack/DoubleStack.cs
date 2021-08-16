public class DoubleStack
{
    private double[] stack;
    private const int DEFAULT_SIZE = 10;
    private int stackIndex = -1;
    public DoubleStack(int? size)
    {
        int stackSize = size ?? DEFAULT_SIZE;
        stack = new double[stackSize];
    }

    public void Push(double item) => stack[++stackIndex] = item;

    public double Pop() => stack[stackIndex--];

    public int Count() => stackIndex + 1;
}