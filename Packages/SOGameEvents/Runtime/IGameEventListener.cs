namespace RaCoding.GameEvents
{
    public interface IGameEventListener<T>
    {
        public void Register();

        public void Unregister();
        
        public void OnEventRaised(T t);

        public string ParentName
        {
            get;
        }
    }
}
