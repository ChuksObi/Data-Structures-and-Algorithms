namespace CSharp.Queue.LinkedList
{
    public interface IMyQueue<T>
    {
        Node<T> Peek();
        Node<T> Enqueue(T item);
        Node<T> Dequeue();
    }
}