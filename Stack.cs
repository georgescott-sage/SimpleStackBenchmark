public class Stack<T>
{
    private T[] stack;
    private const int DEFAULT_SIZE = 10;
    private int stackIndex = -1;
    public Stack(int? size)
    {
        int stackSize = size ?? DEFAULT_SIZE;
        stack = new T[stackSize];
    }

    public void Push(T item) => stack[++stackIndex] = item;

    public T Pop() => stack[stackIndex--];

    public int Count() => stackIndex + 1;
}