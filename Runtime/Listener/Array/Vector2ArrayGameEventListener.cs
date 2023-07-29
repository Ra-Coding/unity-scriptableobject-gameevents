using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector2ArrayGameEventListener : GameEventListener<Vector2[]>
    {
        public Vector2ArrayGameEventListener() : base() {}

        public Vector2ArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private Vector2ArrayGameEvent vector2ArrayEvent;
        [SerializeField] private Vector2ArrayUnityEvent vector2ArrayResponse;

        public override GameEvent<Vector2[]> Event => vector2ArrayEvent; 
        public override UnityEvent<Vector2[]> Response => vector2ArrayResponse; 
    }
}
