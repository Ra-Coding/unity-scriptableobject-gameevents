using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector2IntGameEventListener : GameEventListener<Vector2Int>
    {
        public Vector2IntGameEventListener() : base() { }

        public Vector2IntGameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private Vector2IntGameEvent vector2intEvent;
        [SerializeField] private Vector2IntUnityEvent vector2intResponse;

        public override GameEvent<Vector2Int> Event => vector2intEvent;
        public override UnityEvent<Vector2Int> Response => vector2intResponse;
    }
}