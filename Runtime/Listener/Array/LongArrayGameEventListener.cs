using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class LongArrayGameEventListener : GameEventListener<long[]>
    {
        public LongArrayGameEventListener() : base() {}

        public LongArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private LongArrayGameEvent longArrayEvent;
        [SerializeField] private LongArrayUnityEvent longArrayResponse;

        public override GameEvent<long[]> Event => longArrayEvent; 
        public override UnityEvent<long[]> Response => longArrayResponse; 
    }
}
