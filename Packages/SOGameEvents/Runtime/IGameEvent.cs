namespace RaCoding.GameEvents
{
    public interface IGameEvent<T>
    {
        public void Raise(T t);

        public void RegisterListener(IGameEventListener<T> listener);

        public void UnregisterListener(IGameEventListener<T> listener);
    }
}
