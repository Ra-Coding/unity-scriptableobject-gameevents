using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class EmptyGameEventListener : GameEventListener<EmptyType> 
    {
        public EmptyGameEventListener() : base() {}
        
        public EmptyGameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private EmptyGameEvent emptyTypeEvent;
        [SerializeField] private EmptyUnityEvent emptyTypeResponse;

        public override GameEvent<EmptyType> Event => emptyTypeEvent;
        public override UnityEvent<EmptyType> Response => emptyTypeResponse;
    }
}