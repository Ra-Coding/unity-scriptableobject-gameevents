using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector2GameEventListener : GameEventListener<Vector2> 
    {
        public Vector2GameEventListener() : base() {}
        
        public Vector2GameEventListener(IRegisterListener registerListener)  : base(registerListener) {}

        [SerializeField] private Vector2GameEvent vector2Event;
        [SerializeField] private Vector2UnityEvent vector2Response;

        public override GameEvent<Vector2> Event => vector2Event;
        public override UnityEvent<Vector2> Response => vector2Response;
    }
}