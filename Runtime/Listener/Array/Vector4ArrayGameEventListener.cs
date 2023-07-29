using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector4ArrayGameEventListener : GameEventListener<Vector4[]>
    {
        public Vector4ArrayGameEventListener() : base() {}

        public Vector4ArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private Vector4ArrayGameEvent vector4ArrayEvent;
        [SerializeField] private Vector4ArrayUnityEvent vector4ArrayResponse;

        public override GameEvent<Vector4[]> Event => vector4ArrayEvent; 
        public override UnityEvent<Vector4[]> Response => vector4ArrayResponse; 
    }
}
