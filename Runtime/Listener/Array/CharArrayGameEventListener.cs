using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class CharArrayGameEventListener : GameEventListener<char[]>
    {
        public CharArrayGameEventListener() : base() {}

        public CharArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private CharArrayGameEvent charArrayEvent;
        [SerializeField] private CharArrayUnityEvent charArrayResponse;

        public override GameEvent<char[]> Event => charArrayEvent; 
        public override UnityEvent<char[]> Response => charArrayResponse; 
    }
}
