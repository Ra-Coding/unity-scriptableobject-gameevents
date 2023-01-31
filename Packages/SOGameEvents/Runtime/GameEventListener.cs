using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    public abstract class GameEventListener<T> : IGameEventListener<T>
    {
        private GameObject _parentGameObject;
        public GameObject ParentGameObject
        {
            private get { return _parentGameObject; }
            set
            {
                if (value != null && _parentGameObject == null)
                {
                    _parentGameObject = value;
                }
            }
        }

        public string ParentName
        {
            get 
            { 
                if (_parentGameObject != null)
                {
                    return _parentGameObject.name;
                }
                return "Parent not set!";
            }
        }

        // Constructor for ComponentGameEventListeners
        public GameEventListener() {}

        // Constructor for GameEventListener used as a field
        public GameEventListener(IRegisterListener registerListener, GameObject parent) 
        {
            ParentGameObject = parent;
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
