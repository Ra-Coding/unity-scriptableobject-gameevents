using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector4GameEventListener : GameEventListener<Vector4>
    {
        public Vector4GameEventListener() : base() { }

        public Vector4GameEventListener(IRegisterListener registerListener, GameObject gameObject) : base(registerListener, gameObject) { }

        [SerializeField] private Vector4GameEvent vector4Event;
        [SerializeField] private Vector4UnityEvent vector4Response;

        public override GameEvent<Vector4> Event => vector4Event;
        public override UnityEvent<Vector4> Response => vector4Response;
    }
}