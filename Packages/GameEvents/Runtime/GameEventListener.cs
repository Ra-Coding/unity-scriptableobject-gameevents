using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    public abstract class GameEventListener<T> : IGameEventListener<T>
    {
        public GameEventListener() {}

        public GameEventListener(IRegisterListener registerListener) 
        {
            registerListener.onEnableGameEventListener += Register;
            registerListener.onDisableGameEventListener += Unregister;
        }

        [Tooltip("Event to register with.")]
        public abstract GameEvent<T> Event { get; }

        [Tooltip("Response to invoke when Event is raised.")]
        public abstract UnityEvent<T> Response { get; }

        public void Register()
        {
            Event.RegisterListener(this);
        }

        public void Unregister()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T t)
        {
            Response.Invoke(t);
        }
    }
}
