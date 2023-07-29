using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ColorArrayGameEventListener : GameEventListener<Color[]>
    {
        public ColorArrayGameEventListener() : base() {}

        public ColorArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private ColorArrayGameEvent colorArrayEvent;
        [SerializeField] private ColorArrayUnityEvent colorArrayResponse;

        public override GameEvent<Color[]> Event => colorArrayEvent; 
        public override UnityEvent<Color[]> Response => colorArrayResponse; 
    }
}
