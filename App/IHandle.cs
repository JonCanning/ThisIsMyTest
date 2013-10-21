namespace App
{
    public interface IHandle<T>
    {
        void Handle(T command);
    }
}