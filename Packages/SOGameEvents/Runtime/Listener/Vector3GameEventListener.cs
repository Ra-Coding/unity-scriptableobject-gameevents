using UnityEngine;
using UnityEngine.Events;

namespace RaCoding.GameEvents
{
    [System.Serializable]
    public class Vector3GameEventListener : GameEventListener<Vector3> 
    {
        public Vector3GameEventListener() : base() {}
        
        public Vector3GameEventListener(IRegisterListener registerListener) : base(registerListener) { }

        [SerializeField] private Vector3GameEvent vector3Event;
        [SerializeField] private Vector3UnityEvent vector3Response;

        public override GameEvent<Vector3> Event => vector3Event;
        public override UnityEvent<Vector3> Response => vector3Response;
    }
}