using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    public abstract class GameEventListener<T> : IGameEventListener<T>
    {
        [Tooltip("Event to register with.")]
        public abstract GameEvent<T> Event { get; }

        [Tooltip("Response to invoke when Event is raised.")]
        public abstract UnityEvent<T> Response { get; }

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T t)
        {
            Response.Invoke(t);
        }
    }
}
