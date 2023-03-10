using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class UShortGameEventListener : GameEventListener<ushort>
    {
        public UShortGameEventListener() : base() { }

        public UShortGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private UShortGameEvent ushortEvent;
        [SerializeField] private UShortUnityEvent ushortResponse;

        public override GameEvent<ushort> Event => ushortEvent;
        public override UnityEvent<ushort> Response => ushortResponse;
    }
}