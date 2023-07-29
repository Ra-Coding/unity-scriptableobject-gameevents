using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class SByteArrayGameEventListener : GameEventListener<sbyte[]>
    {
        public SByteArrayGameEventListener() : base() {}

        public SByteArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private SByteArrayGameEvent sByteArrayEvent;
        [SerializeField] private SByteArrayUnityEvent sByteArrayResponse;

        public override GameEvent<sbyte[]> Event => sByteArrayEvent; 
        public override UnityEvent<sbyte[]> Response => sByteArrayResponse; 
    }
}
