using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class StringArrayGameEventListener : GameEventListener<string[]>
    {
        public StringArrayGameEventListener() : base() {}

        public StringArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private StringArrayGameEvent stringArrayEvent;
        [SerializeField] private StringArrayUnityEvent stringArrayResponse;

        public override GameEvent<string[]> Event => stringArrayEvent; 
        public override UnityEvent<string[]> Response => stringArrayResponse; 
    }
}
