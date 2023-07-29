using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class UIntArrayGameEventListener : GameEventListener<uint[]>
    {
        public UIntArrayGameEventListener() : base() {}

        public UIntArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private UIntArrayGameEvent uIntArrayEvent;
        [SerializeField] private UIntArrayUnityEvent uIntArrayResponse;

        public override GameEvent<uint[]> Event => uIntArrayEvent; 
        public override UnityEvent<uint[]> Response => uIntArrayResponse; 
    }
}
