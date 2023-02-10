using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class ColorGameEventListener : GameEventListener<Color> 
    {
        public ColorGameEventListener() : base() {}
        
        public ColorGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private ColorGameEvent colorEvent;
        [SerializeField] private ColorUnityEvent colorResponse;

        public override GameEvent<Color> Event => colorEvent;
        public override UnityEvent<Color> Response => colorResponse;
    }
}