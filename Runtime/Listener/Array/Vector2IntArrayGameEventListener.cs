using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector2IntArrayGameEventListener : GameEventListener<Vector2Int[]>
    {
        public Vector2IntArrayGameEventListener() : base() {}

        public Vector2IntArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private Vector2IntArrayGameEvent vector2IntArrayEvent;
        [SerializeField] private Vector2IntArrayUnityEvent vector2IntArrayResponse;

        public override GameEvent<Vector2Int[]> Event => vector2IntArrayEvent; 
        public override UnityEvent<Vector2Int[]> Response => vector2IntArrayResponse; 
    }
}
