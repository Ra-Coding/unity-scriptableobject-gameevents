using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class CharGameEventListener : GameEventListener<char> 
    {
        public CharGameEventListener() : base() {}
        
        public CharGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private CharGameEvent charEvent;
        [SerializeField] private CharUnityEvent charResponse;

        public override GameEvent<char> Event => charEvent;
        public override UnityEvent<char> Response => charResponse;
    }
}