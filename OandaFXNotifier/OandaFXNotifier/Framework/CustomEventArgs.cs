namespace OandaFXNotifier.Framework
{
    public class CustomEventArgs<T>
    {
        public CustomEventArgs(T content)
        {
            item = content;
        }

        public T item { get; private set; }
    }
}
