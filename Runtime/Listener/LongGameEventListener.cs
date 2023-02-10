using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class LongGameEventListener : GameEventListener<long> 
    {
        public LongGameEventListener() : base() {}
        
        public LongGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private LongGameEvent longEvent;
        [SerializeField] private LongUnityEvent longResponse;

        public override GameEvent<long> Event => longEvent;
        public override UnityEvent<long> Response => longResponse;
    }
}