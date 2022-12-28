namespace RaCoding.GameEvents
{
    public interface IGameEventListener<T>
    {
        public void OnEventRaised(T t);
    }
}
