using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ShortArrayGameEventListener : GameEventListener<short[]>
    {
        public ShortArrayGameEventListener() : base() {}

        public ShortArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private ShortArrayGameEvent shortArrayEvent;
        [SerializeField] private ShortArrayUnityEvent shortArrayResponse;

        public override GameEvent<short[]> Event => shortArrayEvent; 
        public override UnityEvent<short[]> Response => shortArrayResponse; 
    }
}
