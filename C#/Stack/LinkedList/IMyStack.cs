namespace CSharp.Stack.LinkedList
{
    public interface IMyStack<T>
    {
        Node<T> Peek();
        Node<T> Push(T item);
        Node<T> Pop();
    }
}