using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class EmptyGameEventListener : GameEventListener<EmptyType> 
    {
        [SerializeField] private EmptyGameEvent emptyTypeEvent;
        [SerializeField] private EmptyUnityEvent emptyTypeResponse;

        public override GameEvent<EmptyType> Event => emptyTypeEvent;
        public override UnityEvent<EmptyType> Response => emptyTypeResponse;
    }
}