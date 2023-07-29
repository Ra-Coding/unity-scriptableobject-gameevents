using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector3ArrayGameEventListener : GameEventListener<Vector3[]>
    {
        public Vector3ArrayGameEventListener() : base() {}

        public Vector3ArrayGameEventListener(IRegisterListener registerListener) : base(registerListener) {}

        [SerializeField] private Vector3ArrayGameEvent vector3ArrayEvent;
        [SerializeField] private Vector3ArrayUnityEvent vector3ArrayResponse;

        public override GameEvent<Vector3[]> Event => vector3ArrayEvent; 
        public override UnityEvent<Vector3[]> Response => vector3ArrayResponse; 
    }
}
