using System;

class Stack
{
    private int[] items;
    private int top;
    private const int DEFAULT_CAPACITY = 10;

    public Stack()
    {
        items = new int[DEFAULT_CAPACITY];
        top = -1;
    }

    public void Push(int item)
    {
        if (top == items.Length - 1)
        {
            // Stack is full, double its capacity
            Array.Resize(ref items, items.Length * 2);
        }
        items[++top] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return items[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return items[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(40);

        Console.WriteLine("Top element of stack: " + stack.Peek());
        Console.WriteLine(stack.Pop());
        
    }
}
