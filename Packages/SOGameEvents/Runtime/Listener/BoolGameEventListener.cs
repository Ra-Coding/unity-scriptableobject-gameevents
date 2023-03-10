using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class BoolGameEventListener : GameEventListener<bool> 
    {
        public BoolGameEventListener() : base() {}
        
        public BoolGameEventListener(IRegisterListener registerListener)  : base(registerListener) {}

        [SerializeField] private BoolGameEvent boolEvent;
        [SerializeField] private BoolUnityEvent boolResponse;

        public override GameEvent<bool> Event => boolEvent;
        public override UnityEvent<bool> Response => boolResponse;
    }
}