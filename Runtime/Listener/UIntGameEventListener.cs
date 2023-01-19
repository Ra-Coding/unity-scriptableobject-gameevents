using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class UIntGameEventListener : GameEventListener<uint>
    {
        public UIntGameEventListener() : base() { }

        public UIntGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private UIntGameEvent uintEvent;
        [SerializeField] private UIntUnityEvent uintResponse;

        public override GameEvent<uint> Event => uintEvent;
        public override UnityEvent<uint> Response => uintResponse;
    }
}