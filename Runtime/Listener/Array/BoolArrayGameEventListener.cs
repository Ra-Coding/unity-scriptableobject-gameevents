using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class BoolArrayGameEventListener : GameEventListener<bool[]>
    {
        public BoolArrayGameEventListener() : base() {}

        public BoolArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private BoolArrayGameEvent boolArrayEvent;
        [SerializeField] private BoolArrayUnityEvent boolArrayResponse;

        public override GameEvent<bool[]> Event => boolArrayEvent; 
        public override UnityEvent<bool[]> Response => boolArrayResponse; 
    }
}
