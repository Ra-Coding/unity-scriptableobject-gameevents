using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class TransformArrayGameEventListener : GameEventListener<Transform[]>
    {
        public TransformArrayGameEventListener() : base() {}

        public TransformArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private TransformArrayGameEvent transformArrayEvent;
        [SerializeField] private TransformArrayUnityEvent transformArrayResponse;

        public override GameEvent<Transform[]> Event => transformArrayEvent; 
        public override UnityEvent<Transform[]> Response => transformArrayResponse; 
    }
}
