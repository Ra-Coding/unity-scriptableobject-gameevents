using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class UShortArrayGameEventListener : GameEventListener<ushort[]>
    {
        public UShortArrayGameEventListener() : base() {}

        public UShortArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private UShortArrayGameEvent uShortArrayEvent;
        [SerializeField] private UShortArrayUnityEvent uShortArrayResponse;

        public override GameEvent<ushort[]> Event => uShortArrayEvent; 
        public override UnityEvent<ushort[]> Response => uShortArrayResponse; 
    }
}
