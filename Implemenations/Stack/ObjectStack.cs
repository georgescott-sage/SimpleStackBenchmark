public class ObjectStack
{
    private object[] stack;
    private const int DEFAULT_SIZE = 10;
    private int stackIndex = -1;
    public ObjectStack(int? size)
    {
        int stackSize = size ?? DEFAULT_SIZE;
        stack = new object[stackSize];
    }

    public void Push(object item) => stack[++stackIndex] = item;

    public object Pop() => stack[stackIndex--];

    public int Count() => stackIndex + 1;
}