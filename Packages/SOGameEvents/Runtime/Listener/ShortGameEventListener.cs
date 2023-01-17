using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ShortGameEventListener : GameEventListener<short> 
    {
        public ShortGameEventListener() : base() {}
        
        public ShortGameEventListener(IRegisterListener registerListener)  : base(registerListener) {}

        [SerializeField] private ShortGameEvent shortEvent;
        [SerializeField] private ShortUnityEvent shortResponse;

        public override GameEvent<short> Event => shortEvent;
        public override UnityEvent<short> Response => shortResponse;
    }
}