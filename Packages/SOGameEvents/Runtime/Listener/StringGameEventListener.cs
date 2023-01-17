using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class StringGameEventListener : GameEventListener<string> 
    {
        public StringGameEventListener() : base() {}
        
        public StringGameEventListener(IRegisterListener registerListener)  : base(registerListener) {}

        [SerializeField] private StringGameEvent stringEvent;
        [SerializeField] private StringUnityEvent stringResponse;

        public override GameEvent<string> Event => stringEvent;
        public override UnityEvent<string> Response => stringResponse;
    }
}